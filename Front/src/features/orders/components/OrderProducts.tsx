import test from "/table-test.png";

const OrderProducts = () => {
  return (
    <div className="mt-[1rem]">
      {/* دسکتاپ: ردیف تفصیلی با قیمت */}
      <div className="hidden md:flex justify-between border-b border-gray-100 px-2 pb-3 pt-2">
        <div className="flex items-center gap-3">
          <img src={test} alt="test" />
          <div className="flex flex-col font-semibold text-[0.8rem]">
            <span className="text-gray-700">
              MacBook Pro M2 MNEJ3 2022 LLA 13.3 inch
            </span>
            <span className="text-gray-400">Black</span>
            <span className="text-gray-400">x1</span>
          </div>
        </div>

        <span className="self-end text-gray-700 font-semibold text-[0.8rem]">
          $433.00 from $1299.00
        </span>
      </div>

      {/* موبایل: گرید فشرده تصویر + تعداد + رنگ */}
      <div className="flex md:hidden gap-[0.75rem] px-2 pb-3 pt-2 border-b border-gray-100">
        <div className="flex flex-col items-center gap-[0.25rem]">
          <img src={test} alt="test" className="w-[3.5rem] rounded-[0.4rem]" />
          <span className="text-[0.75rem] text-gray-500">x1</span>
          <span className="w-[0.5rem] h-[0.5rem] rounded-full bg-black"></span>
        </div>
      </div>
    </div>
  );
};

export default OrderProducts;