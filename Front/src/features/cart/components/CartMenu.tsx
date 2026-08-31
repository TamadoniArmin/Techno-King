import CartTest from "/cart-test.png";
import truckIcon from "/icons/truck.svg";
import verifyIcon from "/icons/verify.svg";
import trashIcon from "/icons/trash.svg";
import shoppingIcon from "/icons/shopping-cart.svg";

const CartMenu = () => {
  return (
    <div className="my-10 w-[32rem] bg-white px-[2rem] pb-[1.5rem] rounded-b-[0.8rem]">
      <h4 className="pt-[1.5rem] pb-[1rem] text-[1.2rem]">3 items</h4>
      <div className="flex gap-[1.5rem] items-center px-[0.625rem] py-[0.5rem] mb-[0.8rem] shadow-[-2px_2px_20px_#2924241f] rounded-[0.5rem]">
        <img src={CartTest} alt=" Cart image" />
        <div className="flex flex-col">
          <h3 className="font-semibold text-[1.1rem]">
            MacBook Pro M2 MNEJ3 2022 LLA 13.3 inch
          </h3>
          <span className="text-gray-400 text-sm">Black</span>
          <span className="text-gray-400 text-sm">×1</span>
          <div className="mt-[1rem]">
            <div className="flex gap-1 items-center">
              <img src={truckIcon} alt=" Truck icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Free Delivery
              </span>
            </div>
            <div className="flex gap-1 items-center">
              <img src={verifyIcon} alt="Verify icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Guaranteed
              </span>
            </div>
          </div>
          <div className="flex justify-between mt-1">
            <span className="font-thin self-end">$433.00</span>
            <div className="flex gap-2 items-center">
              <img src={trashIcon} alt="Trash icon" />
              <div className="flex gap-4 items-center border-b-[2px] border-gray-200 text-gray-400">
                <button>-</button>
                <span className="font-thin">1</span>
                <button>+</button>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div className="flex gap-[1.5rem] items-center px-[0.625rem] py-[0.5rem] mb-[0.8rem] shadow-[-2px_2px_20px_#2924241f] rounded-[0.5rem]">
        <img src={CartTest} alt=" Cart image" />
        <div className="flex flex-col">
          <h3 className="font-semibold text-[1.1rem]">
            MacBook Pro M2 MNEJ3 2022 LLA 13.3 inch
          </h3>
          <span className="text-gray-400 text-sm">Black</span>
          <span className="text-gray-400 text-sm">×1</span>
          <div className="mt-[1rem]">
            <div className="flex gap-1 items-center">
              <img src={truckIcon} alt=" Truck icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Free Delivery
              </span>
            </div>
            <div className="flex gap-1 items-center">
              <img src={verifyIcon} alt="Verify icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Guaranteed
              </span>
            </div>
          </div>
          <div className="flex justify-between mt-1">
            <span className="font-thin self-end">$433.00</span>
            <div className="flex gap-2 items-center">
              <img src={trashIcon} alt="Trash icon" />
              <div className="flex gap-4 items-center border-b-[2px] border-gray-200 text-gray-400">
                <button>-</button>
                <span className="font-thin">1</span>
                <button>+</button>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div className="flex gap-[1.5rem] items-center px-[0.625rem] py-[0.5rem] mb-[0.8rem] shadow-[-2px_2px_20px_#2924241f] rounded-[0.5rem]">
        <img src={CartTest} alt=" Cart image" />
        <div className="flex flex-col">
          <h3 className="font-semibold text-[1.1rem]">
            MacBook Pro M2 MNEJ3 2022 LLA 13.3 inch
          </h3>
          <span className="text-gray-400 text-sm">Black</span>
          <span className="text-gray-400 text-sm">×1</span>
          <div className="mt-[1rem]">
            <div className="flex gap-1 items-center">
              <img src={truckIcon} alt=" Truck icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Free Delivery
              </span>
            </div>
            <div className="flex gap-1 items-center">
              <img src={verifyIcon} alt="Verify icon" />
              <span className="text-gray-400 text-[0.8rem] font-semibold">
                Guaranteed
              </span>
            </div>
          </div>
          <div className="flex justify-between mt-1">
            <span className="font-thin self-end">$433.00</span>
            <div className="flex gap-2 items-center">
              <img src={trashIcon} alt="Trash icon" />
              <div className="flex gap-4 items-center border-b-[2px] border-gray-200 text-gray-400">
                <button>-</button>
                <span className="font-thin">1</span>
                <button>+</button>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div className="flex justify-between mt-[1rem]">
        <div className="flex flex-col items-center justify-center">
          <span className="font-thin">Grand total</span>
          <span className="font-semibold">$543.02</span>
        </div>

        <button className="w-[70%] flex gap-2 items-center justify-center bg-primary-300 rounded-[0.5rem]">
          <span className="text-white">Proceed to Cart</span>
          <img src={shoppingIcon} alt="Shop icon" />
        </button>
      </div>
    </div>
  );
};

export default CartMenu;
