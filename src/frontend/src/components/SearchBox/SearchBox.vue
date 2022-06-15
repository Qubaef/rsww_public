<template>
  <div :class="$style.container">
    <div :class="$style.selectInputForm">
      <label for="destinationInput">Destination</label>
      <el-select v-model="searchOptions.destination">
        <el-option
          v-for="(loc, idx) in locations"
          :key="idx"
          :label="loc"
          :value="loc"
        />
      </el-select>
    </div>
    <div :class="$style.selectInputForm">
      <label for="departureFromInput">Departure from</label>
      <el-select v-model="searchOptions.departureFrom">
        <el-option
          v-for="(loc, idx) in locations"
          :key="idx"
          :label="loc"
          :value="loc"
        />
      </el-select>
    </div>
    <div :class="$style.selectInputForm">
      <label for="dateFromInput">Departure date</label>
      <Datepicker
        v-model="searchOptions.dateFrom"
        :enableTimePicker="false"
        :clearable="false"
      />
    </div>
    <div :class="$style.selectInputForm">
      <label for="dateToInput">Return date</label>
      <Datepicker
        v-model="searchOptions.dateTo"
        :enableTimePicker="false"
        :clearable="false"
      />
    </div>
    <div :class="$style.selectInputForm">
      <label for="adultsNumberInput">Adults</label>
      <input
        id="adultsNumberInput"
        type="number"
        v-model="searchOptions.adultsNumber"
      />
    </div>
    <div :class="$style.selectInputForm">
      <label for="childrenTo3NumberInput">Children up to 3 y/o</label>
      <input
        id="childrenTo3NumberInput"
        type="number"
        v-model="searchOptions.childrenTo3Number"
      />
    </div>
    <div :class="$style.selectInputForm">
      <label for="childrenTo10NumberInput">Children up to 10 y/o</label>
      <input
        id="childrenTo10NumberInput"
        type="number"
        v-model="searchOptions.childrenTo10Number"
      />
    </div>
    <div :class="$style.selectInputForm">
      <label for="childrenTo18NumberInput">Children up to 18 y/o</label>
      <input
        id="childrenTo18NumberInput"
        type="number"
        v-model="searchOptions.childrenTo18Number"
      />
    </div>
    <el-button type="primary" @click="handleSearch()" :loading="searching"
      >Search</el-button
    >
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
import { exampleSearchOptions } from "./models";
import Datepicker from "@vuepic/vue-datepicker";
import "@vuepic/vue-datepicker/dist/main.css";
import moment from "moment";
import { getLocations } from "@/utils/requests";

export default defineComponent({
  props: {
    searching: {
      type: Boolean,
      required: true,
    },
  },
  components: {
    Datepicker,
  },
  setup(props, context) {
    const searchOptions = ref(exampleSearchOptions);

    const locations = ref<string[]>([]);
    getLocations()
      .then((res) => {
        locations.value = res.data;
      })
      .catch((err) => {
        console.log(err);
      });

    const handleSearch = () => {
      const reqParams = {
        From: searchOptions.value.departureFrom,
        To: searchOptions.value.destination,
        DepartDate: moment(searchOptions.value.dateFrom).format("YYYY-MM-DD"),
        ReturnDate: moment(searchOptions.value.dateTo).format("YYYY-MM-DD"),
        MinAdultsCount: searchOptions.value.adultsNumber,
        MinChildrenLT3Count: searchOptions.value.childrenTo3Number,
        MinChildrenLT10Count: searchOptions.value.childrenTo10Number,
        MinChildrenLT18Count: searchOptions.value.childrenTo18Number,
        TransportTypes: [0, 1],
      };

      context.emit("searchRequested", reqParams);
    };

    return { searchOptions, handleSearch, locations };
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
  max-width: 500px;
}

.selectInputForm {
  display: grid;
  grid-template-columns: 1fr 1fr;
}
</style>
