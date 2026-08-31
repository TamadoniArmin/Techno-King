import { apiClient } from "../../../shared/api/client";

export async function getOnSaleProducts() {
  const { data } =await apiClient.get("/api/Products/GetHighDiscountProducts(More%20than%2015%20%)");
  return data;
}
