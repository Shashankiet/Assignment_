<template>
  <Header></Header>
  <SideBar></SideBar>

  <router-view />
  <Footer></Footer>
</template>

<script>
import Footer from "./components/Footer.vue";
import SideBar from "./components/SideBar.vue";
import Header from "./components/Header.vue";

export default {
  name: "App",
  components: {
    Footer,
    SideBar,
    Header,
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

.search {
  margin: 20px;
  text-align: left;
}
</style>
