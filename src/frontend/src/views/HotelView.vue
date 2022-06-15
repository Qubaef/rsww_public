<template>
  <div>
    <OfferList />
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import OfferList from "@/components/OfferList/OfferList.vue";

export default defineComponent({
  props: {},
  components: {
    OfferList,
  },
  setup(props) {
    return {};
  },
});
</script>
