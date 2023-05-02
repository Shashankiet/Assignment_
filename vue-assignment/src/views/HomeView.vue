<template>
  <SearchBox v-on:refresh-list="updatedList"></SearchBox>

  <div class="container wrapper">
    <div class="row">
      <table class="table table-bordered table-sm table-responsive-sm">
        <thead>
          <tr>
            <th class="w-25" scope="col">Title</th>
            <th class="w-25" scope="col">Brand</th>
            <th class="w-25" scope="col">Category</th>
            <th class="w-25" scope="col">Warranty</th>
            <th class="w-25" scope="col">Action</th>
          </tr>
        </thead>
        <div class="error" v-if="!getProduct.length">
          <h2>No results found!</h2>
        </div>
        <tbody v-for="(Product, index) in getProduct" :key="index">
          <tr>
            <td class="w-25" @click="goToDetails(Product.id)">
              {{ Product.title }}
            </td>
            <td class="w-25" @click="goToDetails(Product.id)">
              {{ Product.brand }}
            </td>
            <td class="w-25" @click="goToDetails(Product.id)">
              {{ Product.category }}
            </td>
            <td class="w-25" @click="goToDetails(Product.id)">
              {{ Product.warranty }}
            </td>
            <td class="w-25">
              <font-awesome-icon
                @click="editProduct(Product.id)"
                icon="pencil-square"
                size="lg"
              />&nbsp;

              <font-awesome-icon
                @click="deleteProduct(Product)"
                icon="trash"
                size="lg"
              />
            </td>
          </tr>
        </tbody>
      </table>

      <div class="flex-container">
        <button
          :disabled="current == 1"
          type="button"
          class="btn btn-primary"
          @click="prev()"
        >
          <font-awesome-icon icon="backward" />
        </button>

        <select v-model="pageSize" class="pagesize">
          <option>10</option>
          <option>20</option>
          <option>30</option>
        </select>

        <button
          :disabled="pageSize > getProduct.length"
          type="button"
          class="btn btn-primary"
          @click="next()"
        >
          <font-awesome-icon icon="forward" />
        </button>
      </div>
    </div>
  </div>
  <br />
</template>

<script>
import SearchBox from "../components/Search/SearchBox.vue";

export default {
  name: "HomeView",
  components: {
    SearchBox,
  },
  data() {
    return {
      input: "",
      current: 1,
      pageSize: 10,
    };
  },
  computed: {
    getProduct() {
      return this.$store.state.SearchedProduct;
    },
  },
  methods: {
    updatedList() {
      this.current = 1;

      this.getData();
    },
    async getData() {
      await this.$store.dispatch("SearchProduct", {
        title: this.$route.params.name ? this.$route.params.name : "**",
        pageNumber: this.current,
        pageSize: this.pageSize,
      });
    },
    prev() {
      this.current--;
      this.getData();
    },
    next() {
      this.current++;
      this.getData();
    },
    goToDetails(id) {
      this.$router.push({
        name: "details",
        params: {
          id: id,
        },
      });
    },
    async deleteProduct(Product) {
      if (confirm("Do you really want to delete?")) {
        await this.$store.dispatch("DeleteProduct", Product.id);
        this.getData();
      }
    },
    editProduct(id) {
      this.$router.push({
        name: "EditProduct",
        params: {
          id: id,
        },
      });
    },
  },
  async mounted() {
    await this.getData();
  },
  watch: {
    pageSize() {
      this.current = 1;
      this.getData();
    },
  },
};
</script>

<style scoped>
tbody {
  background-color: azure;
}

table {
  margin-left: 4%;
  overflow-y: scroll;
  height: 400px;
  display: block;
  width: 95%;
}

.wrapper {
  margin-left: 60px;
  font-size: 15px;
  padding: 0px 5px;
  overflow: hidden;
  text-align: center;
}

table th,
table td {
  overflow: hidden;
}

th {
  position: sticky;
  z-index: 2;
  top: 0;
  background-color: #ffffe0;
}

.flex-container {
  display: flex;
  justify-content: flex-end;
}

.pagesize {
  padding: 0px;
  margin: 0px;
  margin-left: 5px;
  margin-right: 5px;
}

.error {
  margin-top: 5%;
}
</style>
