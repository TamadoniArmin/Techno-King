import ImageStatus from "./ImageStatus";
import OrderDetail from "./OrderDetail";
import OrderProducts from "./OrderProducts";

const OrderStatus = () => {
  return (
    <div className="p-[1rem] md:p-0">
      <div>
        <h4 className="font-semibold">Order Status</h4>
        <span className="text-gray-400">Track your order</span>
      </div>

      <div className="mt-[1.5rem] bg-gray-25 pt-[1.25rem] pb-[1rem] rounded-[0.5rem] md:pt-[1.5rem]">
        <div className="flex flex-col items-center gap-[1rem]">
          <h5 className="font-semibold text-[1.1rem]">50% Completed</h5>
          <div className="w-[60%] md:w-[20%] h-[2px] bg-secondary-100 relative">
            <div className="absolute bg-secondary-400 w-[50%] h-[2px]"></div>
          </div>
        </div>

        <ImageStatus />

        <div className="px-[1rem] md:px-[0.8rem]">
          <p className="text-[0.9rem] md:text-base">
            Please wait, we are still processing your order.
          </p>
          <p className="pl-0 md:pl-[4rem] text-gray-500 text-[0.85rem] md:text-base">
            We will notify you for any changes in your order.
          </p>
        </div>
      </div>

      <OrderDetail />

      <OrderProducts />
    </div>
  );
};

export default OrderStatus;