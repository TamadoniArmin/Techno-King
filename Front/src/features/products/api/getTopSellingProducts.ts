import { apiClient } from "../../../shared/api/client";

export async function getTopSellingProducts(n: number) {
  const { data } = await apiClient.get("/api/products/TopSelling", {
    params: {n},
  });
  return data;
}
