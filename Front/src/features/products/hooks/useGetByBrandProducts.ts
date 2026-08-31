import { useQuery } from "@tanstack/react-query";
import { getByBrandProducts } from "../api/getByBrandProducts";

export function useGetByBrandProducts(brand: string) {
  return useQuery({
    queryKey: ["products", "getById", brand],
    queryFn: () => getByBrandProducts(brand),
  });
}
