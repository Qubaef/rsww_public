<template>
  <div>
    <div class="stats-grid">
      <div>
        <h3>Destinations:</h3>
        <div
          v-for="(value, propName) in stats.destinationStats"
          :key="propName"
        >
          {{ propName }}: {{ value }}
        </div>
      </div>
      <div>
        <h3>Hotels:</h3>
        <div v-for="(value, propName) in stats.hotelsStats" :key="propName">
          {{ propName }}: {{ value }}
        </div>
      </div>
      <div>
        <h3>Room types:</h3>
        <div v-for="(value, propName) in stats.roomStats" :key="propName">
          {{ propName }}: {{ value }}
        </div>
      </div>
      <div>
        <h3>Transport types:</h3>
        <div v-for="(value, propName) in stats.transportStats" :key="propName">
          {{ propName }}: {{ value }}
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  props: {
    stats: {
      type: Object,
      required: true,
    },
  },
  setup(props) {
    return {};
  },
});
</script>

<style scoped>
.stats-grid {
  margin-left: 20px;
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 5px;
}
</style>
