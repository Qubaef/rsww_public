<template>
  <div>
    <h2>Orders</h2>
    <OrderList />
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import OrderList from "@/components/OrderList/OrderList.vue";

export default defineComponent({
  components: {
    OrderList,
  },
  props: {},
  setup(props) {
    return {};
  },
});
</script>
