import { VueSignalR } from "@dreamonkey/vue-signalr";
import { HubConnectionBuilder } from "@microsoft/signalr";
import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import ElementPlus from "element-plus";
import "element-plus/dist/index.css";

// Create your connection
// See https://docs.microsoft.com/en-us/javascript/api/@microsoft/signalr/hubconnectionbuilder
const connection = new HubConnectionBuilder()
  .withUrl("http://localhost:82/messenger")
  .build();

createApp(App)
  .use(VueSignalR, { connection })
  .use(router)
  .use(ElementPlus)
  .mount("#app");
