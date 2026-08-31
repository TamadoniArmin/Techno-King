import { apiClient } from "../../../shared/api/client";

export async function getByBrandProducts(brand: string) {
  const { data } =await apiClient.get("/api/products/ByBrand", {
    params: { brand },
  });
  return data;
}
