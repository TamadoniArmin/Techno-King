import faq from "/faq.png";
import arrowUp from "/icons/arrow-up.svg";

import CurrentPage from "../../../shared/components/CurrentPage";

const Faq = () => {
  return (
    <div>
      <div className="px-[1.5rem] md:px-[10rem] pt-[1.5rem]">
        <CurrentPage curPage="FAQs" />
        <img
          src={faq}
          alt="FAQ"
          className="mx-auto mt-[2.5rem] w-full h-auto md:w-auto"
        />
        <div className="flex flex-col md:flex-row gap-[1.5rem] md:gap-[2rem] mt-[2rem] mb-[3.5rem]">
          <div className="flex flex-col gap-[0.8rem] md:gap-[1rem] w-full md:w-[40%]">
            <h4 className="font-semibold text-[1.2rem] md:text-[1rem]">
              Table of Contents
            </h4>
            <ul className="flex flex-col gap-[0.6rem] text-[0.95rem] md:text-[1rem]">
              <li className="text-primary-300 font-medium">General</li>
              <li>Trusts & Safety</li>
              <li>Services</li>
              <li>Billing</li>
            </ul>
          </div>

          <div className="flex flex-col gap-[1rem] md:gap-[1.2rem] border-b border-gray-300 pb-[1.2rem] md:pb-[1.5rem] w-full">
            <div className="flex items-center justify-between text-primary-300 text-[1.1rem] md:text-[1.4rem] gap-[1rem]">
              <h3 className="font-semibold">
                Can I purchase products from Tech Heim using installment
                payments?
              </h3>
              <img
                src={arrowUp}
                alt="Arrow up icon"
                className="shrink-0 w-[1rem] md:w-auto"
              />
            </div>
            <p className="w-full md:w-[95%] text-[0.95rem] md:text-[1.1rem]">
              Yes, Tech Heim offers the option to purchase products using both
              cash and installment payments. This allows you to choose the
              payment method that suits your needs and budget.
            </p>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Faq;