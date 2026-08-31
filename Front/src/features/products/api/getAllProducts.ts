import { apiClient } from "../../../shared/api/client";

export async function getAllProducts() {
  const { data } = await apiClient.get("/api/products/GetAll");
  return data;
}
