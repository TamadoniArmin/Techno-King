import { useQuery } from "@tanstack/react-query";
import { getAllProducts } from "../api/getAllProducts";

export function useGetAllProducts() {
  return useQuery({
    queryKey: ["products", "getAll"],
    queryFn: getAllProducts,
  });
}
