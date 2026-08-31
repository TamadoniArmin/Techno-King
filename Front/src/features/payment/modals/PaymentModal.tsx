import CloseIcon from "../../../shared/components/CloseIcon";
import americanLogo from "/icons/americanExp.svg";
import visaLogo from "/icons/visa.svg";
import masterCardLogo from "/icons/master-card.svg";

interface PaymentModalProps {
  closeHandler: () => void;
}

const PaymentModal = ({ closeHandler }: PaymentModalProps) => {
  return (
    <div className="flex justify-center items-center fixed inset-0 bg-[#1d1c1c8d] lg:p-4">
      <div className="w-full h-full lg:h-auto lg:max-w-[37rem] lg:max-h-[25rem] bg-white rounded-none lg:rounded-[0.5rem] px-[1.5rem] lg:px-[2rem] py-[1.5rem] flex flex-col">
        <div className="flex justify-between items-center">
          <h3 className="text-[1.1rem] font-semibold">
            Add your payment method
          </h3>
          <div onClick={closeHandler} className="cursor-pointer">
            <CloseIcon color="#444444" />
          </div>
        </div>

        {/* دسکتاپ: عنوان و زیرعنوان کنار هم، لوگوها سمت راست */}
        <div className="hidden lg:flex items-center justify-between mt-[1.5rem]">
          <div className="flex flex-col">
            <span className="text-gray-700 font-semibold">
              Credit or debit cards cards
            </span>
            <span className="text-gray-400">
              Techno King accepts major credit and debit.
            </span>
          </div>

          <div className="flex items-center gap-2">
            <img src={americanLogo} alt="american express logo" />
            <img src={masterCardLogo} alt="master card logo" />
            <img src={visaLogo} alt="visa logo" />
          </div>
        </div>

        {/* موبایل: عنوان و لوگوها هم‌ردیف، زیرعنوان تمام‌عرض زیرش */}
        <div className="lg:hidden mt-[1rem]">
          <div className="flex items-center justify-between">
            <span className="text-gray-700 font-semibold">
              Credit or debit cards
            </span>
            <div className="flex items-center gap-2">
              <img src={americanLogo} alt="american express logo" className="h-4" />
              <img src={masterCardLogo} alt="master card logo" className="h-4" />
              <img src={visaLogo} alt="visa logo" className="h-4" />
            </div>
          </div>
          <span className="text-gray-400 text-sm">
            Tech Heim accepts major credit and debit cards.
          </span>
        </div>

        <div className="flex flex-col gap-[1rem] mt-[1.5rem] flex-1">
          <div className="flex items-center justify-between border border-gray-200 rounded-[0.5rem] h-[3rem] p-[0.8rem]">
            <input type="number" placeholder="Card number" className="w-full" />
            <CloseIcon color="#b4b4b4" />
          </div>
          <div className="flex items-center justify-between border border-gray-200 rounded-[0.5rem] h-[3rem] p-[0.8rem]">
            <input type="text" placeholder="Name on card" className="w-full" />
            <CloseIcon color="#b4b4b4" />
          </div>

          <div className="flex gap-5">
            <div className="flex items-center justify-between border border-gray-200 h-[3rem] rounded-[0.5rem] w-[50%] p-[0.8rem]">
              <input
                type="text"
                placeholder="Expiration date (MM/YY)"
                className="w-full"
              />
              <CloseIcon color="#b4b4b4" />
            </div>
            <div className="flex items-center justify-between border border-gray-200 h-[3rem] rounded-[0.5rem] w-[50%] p-[0.8rem]">
              <input type="text" placeholder="CVV" className="w-full" />
              <CloseIcon color="#b4b4b4" />
            </div>
          </div>

          {/* دکمه‌ها: موبایل تمام‌عرض و چسبیده به پایین، دسکتاپ سمت راست با عرض ۵۰٪ */}
          <div className="flex gap-2 mt-auto pt-[1rem] lg:pt-0 lg:self-end lg:w-[50%] lg:pl-[0.8rem]">
            <button
              onClick={closeHandler}
              className="text-primary-300 border-2 border-primary-300 w-full h-[3rem] rounded-[0.5rem]"
            >
              Cancel
            </button>
            <button className="text-white border-2 border-primary-300 bg-primary-300 w-full h-[3rem] rounded-[0.5rem]">
              Save
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default PaymentModal;