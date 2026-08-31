import { useQuery } from "@tanstack/react-query";
import { getTopSellingProducts } from "../api/getTopSellingProducts";

export function useGetTopSellingProducts(n: number) {
  return useQuery({
    queryKey: ["products", "topSelling", n],
    queryFn: () => getTopSellingProducts(n),
    placeholderData: [],
  });
}
