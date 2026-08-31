import { apiClient } from "../../../shared/api/client";

export async function getByNameProducts(name: string) {
  const { data } = await apiClient.get("/api/products/SearchByName", {
    params: { name },
  });
  return data;
}
