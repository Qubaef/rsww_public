<template>
  <div :class="$style.tableHeader">
    <span>Destination</span>
    <span>From</span>
    <span>To</span>
    <span>Price</span>
    <span>Status</span>
  </div>
  <OrderItemComp
    v-for="offerItem in orders"
    :orderItem="offerItem"
    v-bind:key="offerItem.id"
  />
</template>

<script lang="ts">
import { getOrders, OrderResp } from "@/utils/requests";
import { defineComponent, ref } from "vue";
import OrderItemComp from "@/components/OrderList/OrderItemComp.vue";

export default defineComponent({
  props: {},
  components: {
    OrderItemComp,
  },
  setup(props) {
    const orders = ref<OrderResp[]>([]);
    const myOrders = () => {
      getOrders()
        .then((res) => {
          orders.value = res.data;
        })
        .catch((err) => console.log(err));
    };

    myOrders();

    return { orders };
  },
});
</script>

<style module>
.container {
  border: 1px solid #0f5545;
}

.tableHeader {
  border: 1px solid #dddddd;
  padding: 10px;
  display: grid;
  grid-template-columns: repeat(5, 1fr);
  gap: 10;
}
</style>
