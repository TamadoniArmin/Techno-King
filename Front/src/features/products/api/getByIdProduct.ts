import { apiClient } from "../../../shared/api/client";

export async function getByIdProduct(id: number) {
  const { data } = await apiClient.get("/api/product/GetById", {
    params: { id },
  });
  return data;
}
