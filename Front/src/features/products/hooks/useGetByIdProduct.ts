import { useQuery } from "@tanstack/react-query";
import { getByIdProduct } from "../api/getByIdProduct";

export function useGetByIdProduct(id: number) {
  return useQuery({
    queryKey: ["product","getById",id],
    queryFn: () => getByIdProduct(id),
  });
}
