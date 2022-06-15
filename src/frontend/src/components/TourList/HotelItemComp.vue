<template>
  <div :class="$style.container">
    <div :class="$style.nameAndLocation">
      <div :class="$style.nameContainer">
        <span>({{ hotelItem.id }})</span>
        <span :class="$style.name">{{ hotelItem.name }}</span>
        <span :class="$style.stars">{{ hotelItem.stars }}★</span>
      </div>
      <span :class="$style.location">{{ hotelItem.city }}</span>
    </div>
    <p :class="$style.description">{{ description }}</p>

    <span
      v-for="offerItem in offers"
      v-bind:key="offerItem.id"
      :class="$style.superMsg">
        {{ offerItem.msg }}
        <br/>
        {{ offerItem.hotelMsg }}
        <br/>
        {{ offerItem.transportBackMsg }}
        <br/>
        {{ offerItem.transportToMsg }}
      </span>
    <OfferList :offers="offers" />
  </div>
</template>

<script lang="ts">
import { HotelDataResp, OfferResp } from "@/utils/requests";
import { defineComponent, PropType, computed } from "vue";
import OfferList from "@/components/OfferList/OfferList.vue";

export default defineComponent({
  components: {
    OfferList,
  },
  props: {
    hotelItem: {
      type: Object as PropType<HotelDataResp>,
      required: true,
    },
    offers: {
      type: Array as PropType<Array<OfferResp>>,
      required: true,
    },
  },
  setup(props) {
    const description = computed(
      () => props.hotelItem.description.substring(0, 400) + "..."
    );

    return {
      description,
    };
  },
});
</script>

<style module>
.container {
  border: 1px solid #0f5545;
  padding: 15px;
}

.nameContainer {
  display: flex;
  flex-direction: row;
  gap: 5px;
  align-items: center;
}

.nameAndLocation {
  display: flex;
  flex-direction: column;
}

.location {
  font-size: 0.9em;
  color: #cdcdcd;
}

.name {
  font-size: 1.5em;
  font-weight: 600;
}

.stars {
  color: #ffff00;
}

.dates {
  display: flex;
  flex-direction: column;
}

.price {
  color: #ff5656;
}

.superMsg {
  color: #ff6666;
}

button {
  padding: 10px;
}
</style>
