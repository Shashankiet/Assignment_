<template>
  <div class="col-12 text-center">
    <h4 class="pt-3">Edit Product</h4>
  </div>
  <div class="container main">
    <form @submit.prevent class="text-center">
      <div class="form-group row">
        <label for="title" class="col-sm-2 col-form-label">Title:</label>
        <div class="col-sm-6">
          <input
            type="text"
            id="title"
            v-model="form.title"
            class="form-control"
          />
        </div>
      </div>

      <div class="form-group row">
        <label for="brand" class="col-sm-2 col-form-label">Brand:</label>
        <div class="col-sm-6">
          <input
            type="text"
            id="brand"
            v-model="form.brand"
            class="form-control"
          />
        </div>
      </div>
      <div class="form-group row">
        <label for="category" class="col-sm-2 col-form-label">Category:</label>
        <div class="col-sm-6">
          <select id="category" v-model="form.category" class="form-control">
            <option value="">Select Category</option>
            <option value="Laptop">Laptop</option>
            <option value="Smartphone">Smartphone</option>
            <option value="Miscellaneous">Miscellaneous</option>
          </select>
        </div>
      </div>

      <div class="form-group row">
        <label for="price" class="col-sm-2 col-form-label">Price:</label>
        <div class="col-sm-6">
          <input
            type="number"
            id="price"
            v-model="form.price"
            class="form-control"
          />
        </div>
      </div>

      <div class="form-group row">
        <label for="description" class="col-sm-2 col-form-label"
          >Description:</label
        >
        <div class="col-sm-6">
          <input
            type="text"
            id="Category"
            v-model="form.description"
            class="form-control"
          />
        </div>
      </div>

      <div class="form-group row">
        <label for="discount" class="col-sm-2 col-form-label">Discount:</label>
        <div class="col-sm-6">
          <input
            type="number"
            id="discount"
            v-model="form.discount"
            class="form-control"
          />
        </div>
      </div>

      <div class="form-group row">
        <label for="imageurl" class="col-sm-2 col-form-label">Image URL:</label>
        <div class="col-sm-6">
          <input
            type="text"
            id="imageurl"
            v-model="form.imageUrl"
            class="form-control"
          />
        </div>
      </div>

      <div class="form-group row">
        <div class="col-sm-12">
          <button
            type="submit"
            :disabled="!isComplete"
            class="btn btn-primary"
            @click="editProduct"
          >
            Update</button
          >&nbsp;
          <button type="button" class="btn btn-danger" @click="gotoHomePage">
            Cancel
          </button>
        </div>
      </div>
    </form>
  </div>
</template>

<script>
import { useRoute } from "vue-router";

export default {
  data() {
    return {
      form: {},
    };
  },
  async mounted() {
    const route = useRoute();
    await this.$store.dispatch("GetProductById", route.params.id);
    this.form = this.$store.state.Product;
  },

  computed: {
    isComplete() {
      return (
        this.form.title &&
        this.form.brand &&
        this.form.category &&
        this.form.price &&
        this.form.discount &&
        this.form.description &&
        this.form.imageUrl
      );
    },
  },

  methods: {
    gotoHomePage() {
      this.$router.push({
        name: "home",
        params: {
          name: "**",
        },
      });
    },
    async editProduct() {
      await this.$store.dispatch("UpdateProduct", this.form);
      this.gotoHomePage();
    },
  },
};
</script>

<style>
label {
  display: inline-block;
  max-width: 100%;
  margin-bottom: 2px;
  font-weight: 700;
}

.main {
  text-align: center;
  margin-left: 200px;
  margin-top: 50px;
}
</style>
