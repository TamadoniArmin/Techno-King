import { useQuery } from "@tanstack/react-query";
import { getByNameProducts } from "../api/getByNameProducts";

export function useGetByNameProducts(name: string) {
  return useQuery({
    queryKey: ["products", "searchByName", name],
    queryFn: () => getByNameProducts(name),
    enabled: name.trim().length > 0,
  });
}
