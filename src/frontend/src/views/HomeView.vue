<template>
  <div class="home">
    <div class="pref-stats">
      <SearchBox
        :searching="searching"
        @search-requested="(data) => handleSearch(data)"
      />
      <prefs-box :stats="stats" />
    </div>
    <TourList :hotels="hotels" :offers="offers" />
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType, ref } from "vue";
import SearchBox from "@/components/SearchBox/SearchBox.vue";
import TourList from "@/components/TourList/TourList.vue";
import PrefsBox from "@/components/PrefsBox/PrefsBox.vue";

import { HotelDataResp, OfferResp } from "@/utils/requests";
import _ from "lodash";

export default defineComponent({
  name: "HomeView",
  components: {
    SearchBox,
    TourList,
    PrefsBox,
  },
  props: {
    stats: {
      type: Object,
      required: true,
    },
    hotels: {
      type: Array as PropType<Array<HotelDataResp>>,
      required: true,
    },
    offers: {
      type: Array as PropType<Array<OfferResp>>,
      required: true,
    },
    searching: {
      type: Boolean,
      required: true,
    },
  },
  setup(props, context) {
    const handleSearch = (data: any) => {
      context.emit("searchRequested", data);
    };
    return { handleSearch };
  },
});
</script>

<style scoped>
.home {
  display: flex;
  flex-direction: column;
  gap: 10px;
}

.pref-stats {
  display: flex;
  flex-direction: row;
  gap: 5px;
}
</style>
