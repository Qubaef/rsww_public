<template>
  <nav :class="$style.container">
    <router-link to="/">Home</router-link>
    &nbsp;|&nbsp;
    <router-link to="/changes">Last changes</router-link>
    &nbsp;|&nbsp;
    <router-link to="/orders" v-if="isLogged">Orders</router-link>
    <div :class="$style.lastElem" v-if="!isLogged">
      <router-link to="/login">Log in</router-link>
    </div>
    <div :class="$style.lastElem" v-if="isLogged">
      <span>Logged as: {{ userData?.username ?? "..." }}</span> |
      <button @click="handleLogOut()">Log out</button>
    </div>
  </nav>
</template>

<script lang="ts">
import { logOut } from "@/utils/login";
import { defineComponent, PropType } from "vue";
import { UserData } from "./models";

export default defineComponent({
  props: {
    userData: {
      type: Object as PropType<UserData>,
      required: false,
    },
    isLogged: {
      tyhpe: Boolean,
      required: true,
    },
  },
  setup(props, context) {
    const handleLogOut = () => {
      logOut()
        .then(() => context.emit("logOut"))
        .catch(() => console.log("error logging out"));
    };
    return { handleLogOut };
  },
});
</script>

<style module>
.container {
  display: flex;
  font-size: 1.2em;
  margin-bottom: 20px;
}

.lastElem {
  margin-left: auto;
}
</style>
