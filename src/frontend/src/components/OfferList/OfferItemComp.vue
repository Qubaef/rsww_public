<template>
  <div :class="$style.container">
    <span :class="$style.departureFrom">{{ offerItem.transportTo.from }}</span>
    <span :class="$style.dateFrom">{{ dateFrom }}</span>
    <span :class="$style.dateTo">{{ dateTo }}</span>
    <span :class="$style.numberOfDays">{{ numberOfDays }}</span>
    <div :class="$style.rooms">
      <div
        v-for="(peopleNumber, room) in offerItem.hotel.offerRoomCounts"
        v-bind:key="room"
      >
      <span v-if="peopleNumber >= 1" :class="$style.room">
        {{ room }} (for {{ peopleNumber }})
      </span>
      </div>
    </div>
    <span :class="$style.transportType">{{ transportTypeTo }}</span>
    <span :class="$style.transportType">{{ transportTypeBack }}</span>
    <span :class="$style.foodBoardType">{{ meal }}</span>
    <span :class="$style.price">{{ offerItem.finalPrice }} PLN</span>
    <div>
      <button @click="handleBook()" :disabled="!offerItem.isAvailable">
        Book
      </button>
      <span :class="$style.hiperMsg">{{ offerItem.msg }}</span>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType, computed } from "vue";
import moment from "moment";
import { bookOffer, OfferResp } from "@/utils/requests";
import router from "@/router";
import { ElNotification } from "element-plus";

export default defineComponent({
  props: {
    offerItem: {
      type: Object as PropType<OfferResp>,
      required: true,
    },
  },
  setup(props) {
    const numberOfDays = computed(() => {
      const from = new Date(props.offerItem.hotel.from);
      const to = new Date(props.offerItem.hotel.to);
      return moment(to).diff(moment(from), "days");
    });
    const dateFrom = computed(() =>
      new Date(props.offerItem.hotel.from).toLocaleDateString()
    );
    const dateTo = computed(() =>
      new Date(props.offerItem.hotel.to).toLocaleDateString()
    );
    const meal = computed(() => {
      switch (props.offerItem.mealOffer.type) {
        case 0: {
          return "no meals";
        }
        case 1: {
          return "breakfast";
        }
        case 2: {
          return "breakfast and dinner";
        }
        case 3: {
          return "3 meals";
        }
        case 4: {
          return "all inclusive";
        }
      }

      return "no meals";
    });
    const parseTransportType = (type: any) => {
      switch (type) {
        case 0: {
          return "bus";
        }
        case 1: {
          return "train";
        }
        case 2: {
          return "plane";
        }
      }

      return "bus";
    };
    const transportTypeTo = computed(() => {
      return parseTransportType(props.offerItem.transportTo.transportType);
    });
    const transportTypeBack = computed(() => {
      return parseTransportType(props.offerItem.transportBack.transportType);
    });

    const handleBook = () => {
      bookOffer(props.offerItem)
        .then((res) => {
          if (res.data.success) {
            const offerId = res.data.orderId;
            router.push({ name: "pay", params: { offerId: offerId } });
          } else {
            ElNotification({
              title: "Error",
              message: "Offer is not available anymore. ¯\\_(ツ)_/¯",
              type: "error",
            });
          }
        })
        .catch((err) => {
          ElNotification({
            title: "Error",
            message: "You must be logged in.",
            type: "error",
          });
          console.log(err);
        });
    };

    return {
      numberOfDays,
      dateFrom,
      dateTo,
      meal,
      transportTypeBack,
      transportTypeTo,
      handleBook,
    };
  },
});
</script>

<style module>
.container {
  border: 1px dotted #dddddd;
  padding: 10px;
  display: grid;
  grid-template-columns: repeat(10, 1fr);
  gap: 10;
}

.container > span {
  padding: 5px;
  border: 1px solid grey;
}
.container > div {
  border: 1px solid grey;
}

.price {
  color: red;
}

.hiperMsg {
  color: #ff6666;
  font-size: 0.8rem;
}
</style>
