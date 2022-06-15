<template>
  <div :class="$style.tableHeader">
    <span>Departure from</span>
    <span>From</span>
    <span>To</span>
    <span>Num. of days</span>
    <span>Accomodation</span>
    <span>Transport to</span>
    <span>Transport back</span>
    <span>Board type</span>
    <span>Price</span>
    <span>Book</span>
  </div>
  <OfferItemComp
    v-for="offerItem in offers"
    :offerItem="offerItem"
    v-bind:key="offerItem.id"
  />
</template>

<script lang="ts">
import { OfferResp } from "@/utils/requests";
import { defineComponent, PropType } from "vue";
import OfferItemComp from "./OfferItemComp.vue";

export default defineComponent({
  props: {
    offers: {
      type: Array as PropType<Array<OfferResp>>,
      required: true,
    },
  },
  components: {
    OfferItemComp,
  },
  setup(props) {
    return {};
  },
});
</script>

<style module>
.container {
  border: 1px solid #0f5545;
}

.tableHeader {
  border: 1px dotted #dddddd;
  font-size: 0.9rem;
  padding: 10px;
  display: grid;
  grid-template-columns: repeat(10, 1fr);
  gap: 10;
}
</style>
