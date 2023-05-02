import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "bootstrap/dist/css/bootstrap.min.css";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import { library } from "@fortawesome/fontawesome-svg-core";
import {
  faPhone,
  faEdit,
  faDeleteLeft,
  faAngleRight,
  faAngleLeft,
  faAlignLeft,
  faTrash,
  faPencilSquare,
  faHome,
  faForward,
  faBackward,
  faSearch,
} from "@fortawesome/free-solid-svg-icons";
import "bootstrap";
library.add(
  faPhone,
  faEdit,
  faDeleteLeft,
  faAngleRight,
  faAngleLeft,
  faAlignLeft,
  faTrash,
  faPencilSquare,
  faHome,
  faForward,
  faBackward,
  faSearch
);
createApp(App)
  .component("font-awesome-icon", FontAwesomeIcon)
  .use(store)
  .use(router)
  .mount("#app");
import "bootstrap/dist/js/bootstrap.js";
