import axios from "axios";

export async function DeleteProduct(url) {
  const response = await axios.delete(url);
  return response.data;
}

export async function AddProduct(url, Product) {
  const response = await axios.post(url, Product);
  return response.data;
}

export async function GetProductById(url) {
  const response = await axios(url);
  return response.data;
}

export async function UpdateProductById(url, updatedProduct) {
  const response = await axios.put(url, updatedProduct);
  return response.data;
}

export async function SearchProduct(url) {
  const response = await axios(url);
  return response.data;
}
