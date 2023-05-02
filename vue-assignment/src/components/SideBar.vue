<template>
  <div class="sidenav">
    <a href="#/**">Home</a>

    <a href="#/AddProduct">Add Product</a>
  </div>
</template>

<script>
export default {
  name: "SideBar",
};
</script>

<style scoped>
.sidenav {
  height: 100%;
  width: 85px;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  background-color: #e8f4f8;
  overflow-x: hidden;
  padding-top: 20px;
  margin-top: 42px;
}

.sidenav a {
  padding: 6px 8px 6px 16px;
  text-decoration: none;
  font-size: 15px;
  color: black;
  display: block;
  font-weight: bold;
  text-align: left;
  text-decoration: none;
  margin: 5px;
}

.sidenav a:hover {
  color: blue;
}
</style>
