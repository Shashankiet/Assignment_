<template>
  <div class="card details" style="width: 30rem; margin: auto">
    <img class="card-img-top" :src="product.imageUrl" alt="Card image cap" />
    <div class="card-body">
      <h5 class="card-title">{{ product.title }}</h5>
      <p class="card-text">{{ product.description }}</p>
      <p class="card-text">Price {{ product.price }}</p>
      <p class="card-text">Discount {{ product.discount }}</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "ProductCard",
  props: {
    product: Object,
  },
};
</script>

<style>
.details {
  margin: 5%;
  text-align: center;
}

img {
  margin-top: 15px;
  width: 25%;
  height: 250px;
}
</style>
