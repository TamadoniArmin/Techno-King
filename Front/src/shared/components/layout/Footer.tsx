import locationIcon from "/icons/location.svg";
import callIcon from "/icons/call-calling.svg";
import smsIcon from "/icons/sms-edit.svg";
import userIcon from "/icons/user.svg";
import arrowRightIcon from "/icons/arrow-right.svg";
import facebookIcon from "/icons/Facebook.svg";
import twitterIcon from "/icons/twitter.svg";
import instagramIcon from "/icons/Instagram.svg";
import youtubeIcon from "/icons/Youtube.svg";
import paypalIcon from "/icons/paypal.svg";
import americanExpIcon from "/icons/americanExp.svg";
import visaIcon from "/icons/visa.svg";
import { Link } from "react-router-dom";

const Footer = () => {
  return (
    <footer className="relative flex w-full max-w-[1440px] flex-col bg-[#051736] px-6 py-4 md:px-[6.8rem] md:py-0">
      {/* دکمه‌های موبایل */}
      <div className="mb-8 flex w-full justify-between md:hidden">
        <button className="flex h-12 w-12 items-center justify-center rounded-full bg-[#A6C4F4]">
          <svg
            width="24"
            height="24"
            viewBox="0 0 24 24"
            fill="none"
            stroke="#051736"
            strokeWidth="2"
            strokeLinecap="round"
            strokeLinejoin="round"
          >
            <path d="M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z" />
          </svg>
        </button>

        <button className="flex h-12 w-12 items-center justify-center rounded-full bg-[#A6C4F4]">
          <svg
            width="24"
            height="24"
            viewBox="0 0 24 24"
            fill="none"
            stroke="#051736"
            strokeWidth="2"
            strokeLinecap="round"
            strokeLinejoin="round"
          >
            <path d="M18 15l-6-6-6 6" />
          </svg>
        </button>
      </div>

      {/* کانتینر اصلی */}
      <div className="flex w-full flex-col md:mt-9 md:flex-row md:justify-between md:gap-10">
        {/* Newsletter */}
        <div className="order-1 mb-10 w-full md:order-4 md:mb-0 md:w-auto">
          <h3 className="text-lg font-medium text-white md:text-base md:font-normal">
            Sign up for News and updates
          </h3>

          <div className="mt-4 flex w-full items-center justify-between gap-4 rounded-lg border border-[#F9F9F9] p-3 md:w-auto md:gap-8">
            <div className="flex items-center gap-2">
              <img src={userIcon} className="brightness-0 invert" alt="User" />
              <span className="text-sm text-[#F9F9F9] md:text-base">
                E-mail Address
              </span>
            </div>
            <img src={arrowRightIcon} alt="Arrow Right" />
          </div>

          {/* Social desktop */}
          <div className="mt-4 hidden gap-4 md:flex">
            <img src={facebookIcon} alt="Facebook" />
            <img src={twitterIcon} alt="Twitter" />
            <img src={instagramIcon} alt="Instagram" />
            <img src={youtubeIcon} alt="YouTube" />
          </div>
        </div>

        {/* Company */}
        <div className="order-2 w-full border-b border-[#ffffff1a] py-5 md:order-1 md:w-auto md:border-none md:py-0">
          <div className="flex w-full items-center justify-between md:cursor-auto">
            <h3 className="text-lg font-medium text-white md:text-base md:font-normal">
              Company
            </h3>

            <svg
              className="h-5 w-5 text-white md:hidden"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth="2"
                d="M19 9l-7 7-7-7"
              />
            </svg>
          </div>

          <ul className="mt-4 hidden space-y-2 text-sm text-gray-100 md:block">
            <li>
              <Link to="/about">About us</Link>
            </li>
            <li>Blog</li>
            <li>Returns</li>
            <li>Order status</li>
          </ul>
        </div>
        {/* Info */}
        <div className="order-3 w-full border-b border-[#ffffff1a] py-5 md:order-2 md:w-auto md:border-none md:py-0">
          <div className="flex w-full items-center justify-between md:cursor-auto">
            <h3 className="text-lg font-medium text-white md:text-base md:font-normal">
              Info
            </h3>

            <svg
              className="h-5 w-5 text-white md:hidden"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth="2"
                d="M19 9l-7 7-7-7"
              />
            </svg>
          </div>

          <ul className="mt-4 hidden space-y-2 text-sm text-gray-100 md:block">
            <li>How it works?</li>
            <li>Our promises</li>
            <li>FAQ</li>
          </ul>
        </div>

        {/* Contact us */}
        <div className="order-4 w-full border-b border-[#ffffff1a] py-5 md:order-3 md:w-auto md:border-none md:py-0">
          <div className="flex w-full items-center justify-between md:cursor-auto">
            <h3 className="text-lg font-medium text-white md:text-base md:font-normal">
              Contact us
            </h3>

            <svg
              className="h-5 w-5 text-white md:hidden"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth="2"
                d="M19 9l-7 7-7-7"
              />
            </svg>
          </div>

          <ul className="mt-4 hidden space-y-2 text-sm text-gray-100 md:block">
            <li className="flex items-center gap-2">
              <img src={locationIcon} alt="Location" />
              <span>123 Main Street, Anytown, USA</span>
            </li>

            <li className="flex items-center gap-2">
              <img src={callIcon} alt="Phone" />
              <span>+1 (555) 123-4567</span>
            </li>

            <li className="flex items-center gap-2">
              <img src={smsIcon} alt="Email" />
              <span>TechHeimSupport@gmail.com</span>
            </li>
          </ul>
        </div>

        {/* Mobile bottom footer */}
        <div className="order-5 mt-6 mb-2 flex w-full items-center justify-between md:hidden">
          {/* Payment icons */}
          <div className="flex gap-1">
            <div className="flex w-8 items-center justify-center rounded bg-white py-1">
              <img src={paypalIcon} alt="PayPal" className="max-w-[80%]" />
            </div>

            <div className="flex w-8 items-center justify-center rounded bg-white py-1">
              <img
                src={americanExpIcon}
                alt="American Express"
                className="max-w-[80%]"
              />
            </div>

            <div className="flex w-8 items-center justify-center rounded bg-white py-1">
              <img src={visaIcon} alt="Visa" className="max-w-[80%]" />
            </div>

            <div className="relative flex w-8 items-center justify-center rounded bg-white py-2">
              <div className="absolute left-[20%] h-[7px] w-[7px] rounded-full bg-[#063A88]" />
              <div className="absolute right-[20%] h-[7px] w-[7px] rounded-full bg-[#063a8896]" />
            </div>
          </div>

          {/* Social mobile */}
          <div className="flex gap-2">
            <img src={facebookIcon} alt="Facebook" className="h-6 w-6" />
            <img src={twitterIcon} alt="Twitter" className="h-6 w-6" />
            <img src={instagramIcon} alt="Instagram" className="h-6 w-6" />
            <img src={youtubeIcon} alt="YouTube" className="h-6 w-6" />
          </div>
        </div>
      </div>

      {/* Desktop payment icons */}
      <div className="mt-5 mb-2 hidden gap-1 md:flex">
        <div className="w-10 rounded bg-white py-2">
          <img src={paypalIcon} alt="PayPal" className="mx-auto" />
        </div>

        <div className="w-10 rounded bg-white py-2">
          <img
            src={americanExpIcon}
            alt="American Express"
            className="mx-auto"
          />
        </div>

        <div className="w-10 rounded bg-white py-2">
          <img src={visaIcon} alt="Visa" className="mx-auto" />
        </div>

        <div className="relative w-10 rounded bg-white py-3">
          <div className="absolute top-2 left-[30%] h-[8px] w-[8px] rounded-full bg-[#063A88]" />
          <div className="absolute top-2 right-[30%] h-[8px] w-[8px] rounded-full bg-[#063a8896]" />
        </div>
      </div>
    </footer>
  );
};

export default Footer;
