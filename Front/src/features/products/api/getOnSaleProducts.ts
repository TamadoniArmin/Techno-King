import { apiClient } from "../../../shared/api/client";

export async function getOnSaleProducts() {
  const { data } =await apiClient.get("/api/Products/GetHighDiscountProducts");
  return data;
}
