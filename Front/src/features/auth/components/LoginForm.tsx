import userIcon from "/icons/user-2.svg";
import smsIcon from "/icons/sms.svg";
import PasswordIcon from "/icons/key.svg";
import eyeIcon from "/icons/eye-slash.svg";
import facebookIcon from "/icons/facebook2.svg";
import googleIcon from "/icons/google.svg";
import { useState } from "react";

const LoginForm = () => {
  const [isRegistered, setIsRegistered] = useState(true);

  return (
    <div className="w-[30rem] bg-white mx-auto py-[2rem] rounded-[0.5rem]">
      <div className="flex flex-col items-center mx-auto">
        <div className="flex justify-between border-b-[2px] border-gray-200 w-[65%]">
          <div className="border-b-[2px] border-primary-300 text-center w-[45%] text-gray-400 mb-[-2px]">
            Login
          </div>
          <div className="text-center w-[45%] text-gray-400">
            Create Account
          </div>
        </div>

        <h3 className="mt-[1.4rem] mb-[1rem] font-semibold text-[1.5rem]">
          {isRegistered ? "Log in to Tech Heim" : "Create your account"}
        </h3>

        <div className="w-[65%] flex flex-col gap-[1rem]">
          {!isRegistered && (
            <div className="flex gap-1 items-center p-[0.5rem] border border-gray-200 rounded-[0.5rem]">
              <img src={userIcon} alt="User icon" />
              <input
                type="text"
                placeholder="Full Name"
                className="w-full outline-none border-none text-gray-400"
              />
            </div>
          )}

          <div className="flex gap-1 items-center p-[0.5rem] border border-gray-200 rounded-[0.5rem]">
            <img src={smsIcon} alt="Email icon" />
            <input
              type="text"
              placeholder="E-mail"
              className="w-full outline-none border-none text-gray-400"
            />
          </div>

          <div className="flex items-center justify-between border border-gray-200 rounded-[0.5rem]">
            <div className="flex gap-1 items-center p-[0.5rem] items-center w-full">
              <img src={PasswordIcon} alt="Password icon" />
              <input
                type="password"
                placeholder="Password"
                className="w-full outline-none border-none text-gray-400"
              />
            </div>

            <img src={eyeIcon} alt="Eye icon" className="pr-[0.5rem]" />
          </div>
        </div>

        {isRegistered && (
          <span className="w-[65%] text-right text-[0.8rem] text-primary-300 mt-[0.6rem]">
            Forgot Password?
          </span>
        )}

        <div className="w-[65%] flex gap-2 items-center mb-[0.6rem] mt-[0.8rem] ml-5">
          <div className="w-[1rem] h-[1rem] border-[2px] border-gray-500 rounded-[0.3rem]"></div>
          {isRegistered ? (
            <span className="text-gray-400 text-sm">Keep me logged in</span>
          ) : (
            <div className="text-sm">
              <span className="text-gray-400">I agree to all </span>
              <span className="text-primary-300">Terms & Conditions</span>
            </div>
          )}
        </div>

        <button className="w-[65%] bg-primary-300 text-white py-[0.5rem] rounded-[0.5rem]">
          {isRegistered ? "Log In" : "Create Account"}
        </button>

        <div className="w-[65%] flex items-center justify-center">
          <div className="grow border border-gray-200"></div>
          <div className="my-[1rem] px-1">
            {isRegistered ? "Or Log In with" : "Or Sign Up with"}
          </div>
          <div className=" grow border border-gray-200"></div>
        </div>

        <div className="w-[65%] flex justify-between items-center text-primary-300">
          <button className="w-[45%] flex gap-1 justify-center items-center py-[0.4rem] border-[2px] border-primary-300 rounded-[0.5rem] ">
            <img src={googleIcon} alt="Google icon" />
            <span className="">Google</span>
          </button>
          <button className="w-[45%] flex gap-1 justify-center items-center py-[0.4rem] border-[2px] border-primary-300 rounded-[0.5rem]">
            <img src={facebookIcon} alt="Facebook icon" />
            <span className="">Facebook</span>
          </button>
        </div>

        <div className="pt-[0.4rem] mt-[1rem] flex gap-2">
          <span className="text-gray-400">Don’t have an account ?</span>
          <span className="text-primary-300">
            {isRegistered ? "sign up" : "sign in"}
          </span>
        </div>
      </div>
    </div>
  );
};

export default LoginForm;
