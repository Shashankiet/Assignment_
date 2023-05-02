<template>
  <div class="container search">
    <input
      class="inputsearch"
      type="text"
      v-model.trim="input"
      placeholder="Search Product..."
    />
    <button @click="goToSearch(input)">
      <font-awesome-icon icon="search" />
    </button>
  </div>
</template>

<script>
export default {
  name: "SearchBox",
  data() {
    return {
      input: "",
    };
  },
  methods: {
    async goToSearch(name) {
      await this.$router.push({
        name: "home",
        params: {
          name: name ? name : "**",
        },
      });
      this.$emit("refresh-list");
    },
  },
};
</script>

<style scoped>
.search button {
  width: 7%;
  padding: 3px;
  background: #ddd;
  font-size: 16px;
  border: none;
  cursor: pointer;
}

.search button:hover {
  background: #bbb;
}
.inputsearch {
  width: 30%;

  text-align: left;
  margin-left: 5%;
}
</style>
