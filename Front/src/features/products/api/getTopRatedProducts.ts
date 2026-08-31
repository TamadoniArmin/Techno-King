import { apiClient } from "../../../shared/api/client";

export async function getTopRatedProducts(n: number) {
  const { data } = await apiClient.get("/api/products/TopRated", {
    params: { n },
  });
  return data;
}
