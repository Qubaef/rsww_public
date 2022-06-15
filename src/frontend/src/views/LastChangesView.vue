<template>
  <h2>Last changes in offers</h2>
  <ul>
    <li v-for="(e, idx) in mevents" :key="idx">{{ e }}</li>
  </ul>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  props: {
    mevents: {
      type: Array,
      required: true,
    },
  },
  setup(props) {
    return {};
  },
});
</script>

<style scoped></style>
