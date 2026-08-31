import { useQuery } from "@tanstack/react-query";
import { getTopRatedProducts } from "../api/getTopRatedProducts";

export function useGetTopRatedProducts(n: number) {
  return useQuery({
    queryKey: ["products", "topRated", n],
    queryFn: () => getTopRatedProducts(n),
  });
}
