import pamentPicture from "/no-order.png";
import test from "/test-order.png";

const CurrentOrder = () => {
  // return (
  //   <div className="flex flex-col items-center mt-[4rem]">
  //     <img src={pamentPicture} alt="picture" />
  //     <span>You have not placed any orders yet</span>
  //   </div>
  // );

  return (
    <div className="p-[1rem] flex flex-col gap-[1.5rem]">
      <div className="flex flex-col gap-[0.75rem] bg-gray-50 p-[1rem] mt-[1.5rem] rounded-[0.4rem] md:flex-row md:items-center md:justify-between md:gap-[1rem]">
        <div className="flex justify-between md:flex-col md:gap-[1rem] md:justify-start">
          <span className="font-semibold">order code</span>
          <span>#1050486</span>
        </div>
        <div className="flex justify-between md:flex-col md:gap-[1rem] md:justify-start">
          <span className="font-semibold">Placed on</span>
          <span>2023/04/15</span>
        </div>
        <div className="flex justify-between md:flex-col md:gap-[1rem] md:justify-start">
          <span className="font-semibold">Total</span>
          <span>$543.02</span>
        </div>
        <div className="flex justify-between md:flex-col md:gap-[1rem] md:justify-start">
          <span className="font-semibold">Sent to</span>
          <span>Jimmy Smith</span>
        </div>
        <div className="flex items-center justify-end md:justify-center">
          <span className="text-primary-300">Order Status</span>
          <svg
            width="24"
            height="24"
            viewBox="0 0 24 24"
            fill="none"
            xmlns="http://www.w3.org/2000/svg"
          >
            <path
              d="M10.74 16.2799C10.55 16.2799 10.36 16.2099 10.21 16.0599C9.91999 15.7699 9.91999 15.2899 10.21 14.9999L13.21 11.9999L10.21 8.99991C9.91999 8.70991 9.91999 8.22991 10.21 7.93991C10.5 7.64991 10.98 7.64991 11.27 7.93991L14.8 11.4699C15.09 11.7599 15.09 12.2399 14.8 12.5299L11.27 16.0599C11.12 16.2099 10.93 16.2799 10.74 16.2799Z"
              fill="#0C68F4"
            />
          </svg>
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

export default CurrentOrder;