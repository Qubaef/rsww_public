import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import HomeView from "../views/HomeView.vue";
import HotelView from "../views/HotelView.vue";
import LoginView from "../views/LoginView.vue";
import PayView from "../views/PayView.vue";
import OrderView from "../views/OrderView.vue";
import LastChangesView from "@/views/LastChangesView.vue";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/",
    name: "home",
    component: HomeView,
    props: {
      stats: Object,
      offers: Array,
      hotels: Array,
      searching: Boolean,
    },
  },
  {
    path: "/sampleHotel",
    name: "hotel info",
    component: HotelView,
  },
  {
    path: "/login",
    name: "login",
    component: LoginView,
  },
  {
    path: "/pay/:offerId",
    name: "pay",
    component: PayView,
    props: true,
  },
  {
    path: "/orders",
    name: "orders",
    component: OrderView,
  },
  {
    path: "/changes",
    name: "changes",
    component: LastChangesView,
    props: {
      mevents: Array,
    },
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
