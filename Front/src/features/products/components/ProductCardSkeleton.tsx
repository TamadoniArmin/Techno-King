const ProductCardSkeleton = () => {
  return (
    <div className="flex flex-col rounded-xl bg-white p-6 shadow-md">
      {/* عکس - همون نسبت aspect-[4/3] کارت اصلی */}
      <div className="aspect-[4/3] w-full animate-pulse rounded-lg bg-gray-200" />

      {/* عنوان دو خطی */}
      <div className="mt-4 h-4 w-full animate-pulse rounded bg-gray-200" />
      <div className="mt-2 h-4 w-1/2 animate-pulse rounded bg-gray-200" />

      {/* قیمت */}
      <div className="mt-3 h-4 w-1/3 animate-pulse rounded bg-gray-200" />
    </div>
  );
};

export default ProductCardSkeleton;