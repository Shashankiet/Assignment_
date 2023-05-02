import { createStore } from "vuex";
import {
  DeleteProduct,
  AddProduct,
  GetProductById,
  UpdateProductById,
  SearchProduct,
} from "./api.js";

export default createStore({
  state: {
    SearchedProduct: [],
    Product: {},
  },
  getters: {},
  mutations: {
    SearchProducts(state, Products) {
      state.SearchedProduct = Products;
    },
    GetProductById(state, Product) {
      state.Product = Product;
    },
  },
  actions: {
    async UpdateProduct({ commit }, updatedProduct) {
      await UpdateProductById(
        "https://localhost:7288/api/Products/" + updatedProduct.id,
        updatedProduct
      );
      commit("GetProductById", {});
    },
    async GetProductById({ commit }, id) {
      let response = await GetProductById(
        "https://localhost:7288/api/Products/" + id
      );
      commit("GetProductById", response);
    },
    async SearchProduct({ commit }, payload) {
      let response = await SearchProduct(
        "https://localhost:7288/api/Products/Search/" +
          payload.title +
          "?pageNumber=" +
          payload.pageNumber +
          "&pageSize=" +
          payload.pageSize
      );
      commit("SearchProducts", response);
    },
    async DeleteProduct({ commit }, id) {
      await DeleteProduct("https://localhost:7288/api/Products/" + id);
      commit("GetProductById", {});
    },
    async AddProduct({ commit }, NewProduct) {
      await AddProduct("https://localhost:7288/api/Products", NewProduct);

      commit("GetProductById", {});
    },
  },
  modules: {},
});
