<template>
  <ProductCard :product="getProduct"></ProductCard>
</template>

<script>
import { useRoute } from "vue-router";
import ProductCard from "./ProductCard.vue";

export default {
  name: "ProductDetails",
  components: {
    ProductCard,
  },
  computed: {
    getProduct() {
      return this.$store.state.Product;
    },
  },
  async mounted() {
    const route = useRoute();
    await this.$store.dispatch("GetProductById", route.params.id);
  },
};
</script>
