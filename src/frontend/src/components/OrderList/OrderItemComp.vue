<template>
  <div :class="$style.container">
    <span>{{ orderItem.transportTo.to }}</span>
    <span>{{ orderItem.reservation.hotelOffer.from }}</span>
    <span>{{ orderItem.reservation.hotelOffer.to }}</span>
    <span>{{ orderItem.finalPrice }} PLN</span>
    <span>{{ isPaid }}</span>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType, computed } from "vue";
import moment from "moment";
import { bookOffer, OfferResp, OrderResp } from "@/utils/requests";
import router from "@/router";

export default defineComponent({
  props: {
    orderItem: {
      type: Object as PropType<OrderResp>,
      required: true,
    },
  },
  setup(props) {
    const isPaid = computed(() => {
      if (props.orderItem.isPaid) {
        return "Opłacono";
      } else {
        return "Nie opłacono";
      }
    });
    return { isPaid };
  },
});
</script>

<style module>
.container {
  border: 1px dotted #dddddd;
  padding: 10px;
  display: grid;
  grid-template-columns: repeat(5, 1fr);
  gap: 10;
}

.container > span {
  padding: 5px;
  border: 1px solid grey;
}
.container > div {
  border: 1px solid grey;
}

.rooms {
  display: flex;
  flex-direction: column;
}

.price {
  color: red;
}
</style>
