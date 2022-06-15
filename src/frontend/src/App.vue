<template>
  <NavBar @log-out="handleLogOut()" :isLogged="isLogged" :userData="userData" />
  <router-view
    @logged-in="handleLoggedIn()"
    @search-requested="(data) => handleSearch(data)"
    :stats="stats"
    :hotels="hotels"
    :offers="offers"
    :searching="searching"
    :mevents="mevents"
  />
</template>

<script lang="ts">
import { defineComponent, ref, reactive } from "vue";
import NavBar from "@/components/NavBar/NavBar.vue";
import { getUserId } from "./utils/login";
import { UserData } from "./components/NavBar/models";
import router from "./router";
import { useSignalR } from "@dreamonkey/vue-signalr";
import {
  getOrderPrefs,
  HotelDataResp,
  OfferResp,
  OffersGetResuest,
  searchOffers,
  getRefreshOffer,
  HotelResp,
} from "@/utils/requests";
import _ from "lodash";

export default defineComponent({
  props: {},
  components: {
    NavBar,
  },
  setup(props) {
    const stats = reactive({
      destinationStats: [],
      hotelsStats: [],
      roomStats: [],
      transportStats: [],
    });

    const mevents = ref<Array<string>>([]);

    getOrderPrefs().then((res: any) => {
      const message = res.data;
      stats.destinationStats = message.destinationStats;
      stats.hotelsStats = message.hotelsStatistic;
      stats.roomStats = message.roomsStatistic;
      stats.transportStats = message.transportTypeStatistic;
    });

    const signalr = useSignalR();
    signalr
      .invoke("AddToGroup", "preferences") //JoinGroup is C# method name
      .then((res) => {
        signalr.on("GetPreferencesUpdate", (message) => {
          console.log(message);
          stats.destinationStats = message.destinationStats;
          stats.hotelsStats = message.hotelsStatistic;
          stats.roomStats = message.roomsStatistic;
          stats.transportStats = message.transportTypeStatistic;
        });
      })
      .catch((err) => {
        console.log(err);
      });

    const refreshOffer = (offer: any, refreshedOffer: OfferResp) => {
      const idx = offers.value.findIndex((o: OfferResp) => o == offer);
      if(idx != -1) {
        if(refreshedOffer == null) {
          offers.value[idx].msg = "This offer in no longer available";
          offers.value[idx].isAvailable = false;
        }
        else {
          refreshedOffer.transportToMsg = offers.value[idx].transportToMsg;
          refreshedOffer.transportBackMsg = offers.value[idx].transportBackMsg;
          refreshedOffer.hotelMsg = offers.value[idx].hotelMsg;
          refreshedOffer.transportToCounter = offers.value[idx].transportToCounter;
          refreshedOffer.transportBackCounter = offers.value[idx].transportBackCounter;
          refreshedOffer.hotelCounter = offers.value[idx].hotelCounter;
          refreshedOffer.isAvailable = true;
          offers.value[idx] = refreshedOffer;
        }
      }
    };

    const onGetTransportUpdate = (message: any) => {
      console.log("Refreshing transport");
      const transportId = message;
      mevents.value.push(`Transport with id ${transportId} updated.`);
      const n_offers = offers.value.filter(
        (o) =>
          o.transportTo.transportId == transportId ||
          o.transportBack.transportId == transportId
      );
      n_offers.forEach((offer) => {
        getRefreshOffer(offer)
          .then((res) => {
            refreshOffer(offer, res.data); //TODO:
          })
          .catch((err) => {
            console.log(err);
          });
      });
    };
    signalr.on("GetTransportUpdate", onGetTransportUpdate);

    const onGetHotelUpdate = (message: any) => {
      console.log("Refreshing hotel");
      const hotelId = message;
      const n_offers = offers.value.filter((o) => o.hotel.hotelId == hotelId);
      mevents.value.push(`Hotel with id ${hotelId} updated.`);
      n_offers.forEach((offer) => {
        getRefreshOffer(offer)
          .then((res) => {
            refreshOffer(offer, res.data); //TODO:
          })
          .catch((err) => {
            console.log(err);
          });
      });
    };
    signalr.on("GetHotelUpdate", onGetHotelUpdate);

    const searching = ref(false);
    const hotels = ref<HotelDataResp[]>([]);
    const offers = ref<OfferResp[]>([]);

    signalr.on("HotelPurchased", (message) => {
      const hotelId = message;
      offers.value.map((o: OfferResp) => {
        if (o.hotel.hotelId == hotelId) {
          o.hotelCounter += 1;
          if(o.hotelCounter == 1) {
            o.hotelMsg = o.hotelCounter.toString() + " person have bought a tour with this hotel since you've displayed this offer";
          }
          else {
            o.hotelMsg = o.hotelCounter.toString() + " people have bought a tour with this hotel since you've displayed this offer";
          }
        }

        return o;
      });
    });

    signalr.on("TransportToPurchased", (message) => {
      const transportId = message;
      offers.value.map((o : OfferResp) => {
        if (o.transportTo.transportId == transportId) {
          o.transportToCounter += 1;
          if(o.transportToCounter == 1) {
            o.transportToMsg = o.transportToCounter.toString() + " person have bought a tour with transport to this hotel since you've displayed it";
          }
          else {
            o.transportToMsg = o.transportToCounter.toString() + " people have bought a tour with transport to this hotel since you've displayed it";
          }
        }

        return o;
      });
    });

    signalr.on("TransportBackPurchased", (message) => {
      const transportId = message;
      offers.value.map((o) => {
        if (o.transportBack.transportId == transportId) {
          o.transportBackCounter += 1;
          if(o.transportBackCounter == 1) {
            o.transportBackMsg = o.transportBackCounter.toString() + " person have bought a tour with transport back from this hotel since you've displayed it";
          }
          else {
            o.transportBackMsg = o.transportBackCounter.toString() + " people have bought a tour with transport back from this hotel since you've displayed it";
          }
        }

        return o;
      });
    });

    const handleSearch = (data: OffersGetResuest) => {
      searching.value = true;
      searchOffers(data)
        .then((res) => {
          const _hotels = _.values(
            _.groupBy(
              res.data.map((r) => r.hotelData),
              "id"
            )
          ).map((xs) => _.first(xs));

          _hotels.forEach((h) => {
            signalr
              .invoke("AddToGroup", h?.id.toString()) //JoinGroup is C# method name
              .catch((err) => {
                console.log(err);
              });
          });

          hotels.value = _hotels as HotelDataResp[];

          const _offers = res.data.map((r) => ({
            ...r.offer,
            isAvailable: true,
            msg: "",
            transportBackMsg: "",
            transportToMsg: "",
            hotelMsg: "",
            hotelCounter: 0,
            transportToCounter: 0,
            transportBackCounter: 0
          }));

          _offers.forEach((o) => {
            signalr
              .invoke("AddToGroup", o.transportTo.transportId.toString()) //JoinGroup is C# method name
              .catch((err) => {
                console.log(err);
              });
            signalr
              .invoke("AddToGroup", o.transportBack.transportId.toString()) //JoinGroup is C# method name
              .catch((err) => {
                console.log(err);
              });
          });

          offers.value = _offers;
          searching.value = false;
        })
        .catch((err) => {
          console.log(err);
          searching.value = false;
        });
    };

    const isLogged = ref(false);
    const userData = ref<UserData>({ username: "..." });

    const user = () =>
      getUserId()
        .then((res) => {
          if (res.status == 200) {
            console.log("user logged in", res);
            isLogged.value = true;
            userData.value = { username: res.data.Name };
          } else {
            isLogged.value = false;
          }
        })
        .catch(() => {
          isLogged.value = false;
        });

    const handleLoggedIn = () => {
      console.log("logged in!");
      router.go(0);
      user();
    };

    const handleLogOut = () => {
      console.log("logged out!");
      router.go(0);
    };

    user();

    return {
      isLogged,
      userData,
      handleLoggedIn,
      handleLogOut,
      stats,
      hotels,
      offers,
      searching,
      handleSearch,
      onGetHotelUpdate,
      onGetTransportUpdate,
      mevents,
    };
  },
});
</script>

<style>
html {
  background: #0f0f0f;
  width: 100%;
}

#app {
  font-family: Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #f0f0f0;
  max-width: 1100px;
  display: flex;
  flex-direction: column;
  margin: auto;
}

h1 {
  font-size: 2.2rem;
  color: #f0c3f0;
  font-weight: bold;
}

h2 {
  color: #c28246;
  font-weight: bold;
}

p {
  text-align: justify;
}

a {
  font-weight: bold;
  color: #fff7bd;
  text-decoration: none;
}

a.router-link-exact-active {
  color: #42b983;
}
</style>
