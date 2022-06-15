<template>
  <div :class="$style.container">
    <span v-if="hotels.length === 0">-</span>
    <HotelItemComp
      v-for="hotel in hotels"
      :hotelItem="hotel"
      :offers="offersForHotel(hotel.id)"
      v-bind:key="hotel.id"
    />
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import HotelItemComp from "./HotelItemComp.vue";
import { HotelDataResp, OfferResp } from "@/utils/requests";

export default defineComponent({
  props: {
    hotels: {
      type: Array as PropType<Array<HotelDataResp>>,
      required: true,
    },
    offers: {
      type: Array as PropType<Array<OfferResp>>,
      required: true,
    },
  },
  components: {
    HotelItemComp,
  },
  setup(props) {
    const offersForHotel = (id: number) => {
      return props.offers.filter((o) => o.hotel.hotelId === id);
    };
    return { offersForHotel };
  },
});
</script>

<style module>
.container {
  border: 1px dotted #dddddd;
  padding: 15px;
  display: flex;
  flex-direction: column;
  gap: 10px;
}
</style>
