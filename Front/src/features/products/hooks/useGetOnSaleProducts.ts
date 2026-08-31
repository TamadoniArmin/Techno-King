import { useQuery } from "@tanstack/react-query";
import { getOnSaleProducts } from "../api/getOnSaleProducts";

export function useGetOnSaleProducts() {
  return useQuery({
    queryKey: ["products","onSale"],
    queryFn: getOnSaleProducts,
  });
}
