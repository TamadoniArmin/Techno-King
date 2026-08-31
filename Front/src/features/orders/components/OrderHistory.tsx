const OrderHistory = () => {
  return (
    <div>
      <div className="flex flex-col gap-[0.5rem]">
        <h2 className="font-semibold">Order History</h2>
        <span className="text-gray-400 text-[0.9rem]">Track, return or purchase items</span>
      </div>

      <div className="border-b-[2px] border-gray-75 flex gap-[2rem] mt-[2.5rem]">
        <div className="flex gap-1 text-gray-400">
          <span>Current</span>
          <span className="bg-gray-25 rounded-[50%] px-[3px]">0</span>
        </div>
        <div className="flex gap-1 text-gray-400">
          <span>Delivered</span>
          <span className="bg-gray-25 rounded-[50%] px-[3px]">0</span>
        </div>
        <div className="flex gap-1 text-gray-400">
          <span>Cancled</span>
          <span className="bg-gray-25 rounded-[50%] px-[3px]">0</span>
        </div>
        <div className="flex gap-1 text-gray-400">
          <span>Returned</span>
          <span className="bg-gray-25 rounded-[50%] px-[3px]">0</span>
        </div>
      </div>
    </div>
  );
};

export default OrderHistory;
