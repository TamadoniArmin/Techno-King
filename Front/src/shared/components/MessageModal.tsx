import successIcon from "/icons/success.svg";
import errorIcon from "/icons/error.svg";

const MessageModal = ({ isSuccess }) => {
  return (
    <div className="w-[30%] mx-auto pt-[1.2rem] pb-[1.5rem] bg-white flex flex-col justify-center items-center rounded-[0.5rem]">
      <img
        src={isSuccess ? successIcon : errorIcon}
        alt=""
        className="w-[35%]"
      />
      <h3
        className={`my-[rem] font-semibold text-[1.7rem] text-${
          isSuccess ? "success" : "error"
        }`}
      >
        {isSuccess ? "Well done" : "Oops"}
      </h3>
      <p className="text-center text-gray-500">
        {isSuccess
          ? "Congratulation your account has been successfully created."
          : "Unfortunately, there was a problem during creating your account. try again later."}
      </p>
    </div>
  );
};

export default MessageModal;
