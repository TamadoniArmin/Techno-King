import test from "/test-order.png";

const DeliveredOrder = () => {
  return (
    <div className="p-[1rem] flex flex-col gap-[1.5rem]">
      <div className="grid grid-cols-2 gap-y-[0.75rem] gap-x-[0.5rem] bg-gray-50 p-[1rem] mt-[1.5rem] rounded-[0.4rem] md:grid-cols-5 md:gap-[1rem]">
        <div className="flex flex-col gap-[0.5rem] md:gap-[1rem]">
          <span className="font-semibold">order code</span>
          <span>#1050486</span>
        </div>
        <div className="flex flex-col gap-[0.5rem] md:gap-[1rem]">
          <span className="font-semibold">Placed on</span>
          <span>2023/04/15</span>
        </div>
        <div className="flex flex-col gap-[0.5rem] md:gap-[1rem]">
          <span className="font-semibold">Total</span>
          <span>$543.02</span>
        </div>
        <div className="flex flex-col gap-[0.5rem] md:gap-[1rem]">
          <span className="font-semibold">Delivered</span>
          <span>2023/08/22</span>
        </div>
        <div className="flex flex-col gap-[0.5rem] md:gap-[1rem] col-span-2 md:col-span-1">
          <span className="font-semibold">Sent to</span>
          <span>Jimmy Smith</span>
        </div>
      </div>

      <div className="grid grid-cols-4 gap-x-[0.75rem] gap-y-[0.75rem] md:grid-cols-7 md:gap-x-[1rem]">
        <div>
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div>
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div>
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div>
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div className="hidden md:block">
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div className="hidden md:block">
          <img src={test} alt="test" className="rounded-[0.4rem]" />
        </div>
        <div className="flex items-center justify-center col-span-1">
          <span>+2</span>
        </div>
      </div>
    </div>
  );
};

export default DeliveredOrder;