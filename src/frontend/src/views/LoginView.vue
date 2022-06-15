<template>
  <div :class="$style.container">
    <label for="loginInput">Login:</label>
    <input type="text" v-model="username" id="loginInput" />
    <label for="passInpur">Password:</label>
    <input type="password" v-model="password" id="passInput" />
    <button @click="sendLoginRequest()">Log in</button>
    <p>{{ message }}</p>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
import { logIn } from "@/utils/login";

export default defineComponent({
  props: {},
  setup(props, context) {
    const username = ref("");
    const password = ref("");
    const message = ref("Fill data");

    const sendLoginRequest = () => {
      logIn(username.value, password.value).then((isOk) => {
        if (isOk) {
          message.value = "OK!";
          context.emit("loggedIn");
        } else {
          message.value = "Invalid username or password.";
        }
      });
    };

    return { username, password, sendLoginRequest, message };
  },
});
</script>

<style module>
.container {
  display: flex;
  justify-content: left;
  flex-direction: column;
  gap: 10px;
}
</style>
