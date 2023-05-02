import { createRouter, createWebHashHistory } from "vue-router";
const routes = [
  {
    path: "/:name?",
    name: "home",
    component: () =>
      import(/* webpackChunkName: "Home" */ "../views/HomeView.vue"),
  },
  {
    path: "/edit/:id",
    name: "EditProduct",
    component: () =>
      import(
        /* webpackChunkName: "EditProduct" */ "../components/Product/EditProduct.vue"
      ),
  },
  {
    path: "/AddProduct",
    name: "AddProduct",
    component: () =>
      import(
        /* webpackChunkName: "Add Product" */ "../components/Product/AddProduct.vue"
      ),
  },
  {
    path: "/details/:id",
    name: "details",
    component: () =>
      import(
        /* webpackChunkName: "Product Details" */ "../components/Product/ProductDetails.vue"
      ),
  },
  {
    path: "/:pathMatch(.*)*",
    name: "PageNotFound",
    component: () =>
      import(
        /* webpackChunkName: "PageNotFound" */ "../views/PageNotFound.vue"
      ),
  },
];

const router = createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
