export interface Product {
  id: number;
  name: string;
  price: number;
  description: string;
  brand: string;
  discount: number;
  subCategoryId: number;
  averageRating: number;
  salesCount: number;
  imagePath: string[];
  isDeleted: boolean;
}
