import addLocationIcon from "/icons/location-add.svg";
import smsIcon from "/icons/sms2.svg";
import callIcon from "/icons/call-incoming.svg";

const Communication = () => {
  return (
    <div className="flex justify-around gap-[0.5rem] mt-[2.5rem] text-[0.8rem] md:text-[1rem]">
      <div className="flex flex-col items-center text-center">
        <img
          src={addLocationIcon}
          alt="Location icon"
          className="w-[1.5rem] md:w-auto"
        />
        <span className="font-semibold">Office</span>
        <div className="flex flex-col items-center text-gray-400 font-thin">
          <span>123 Main Street,</span>
          <span>Anytown,USA</span>
        </div>
      </div>
      <div className="flex flex-col items-center text-center">
        <img src={smsIcon} alt="sms icon" className="w-[1.5rem] md:w-auto" />
        <span className="font-semibold">Email</span>
        <span className="text-gray-400 font-thin">info@techheim.com</span>
      </div>
      <div className="flex flex-col items-center text-center">
        <img src={callIcon} alt="Call icon" className="w-[1.5rem] md:w-auto" />
        <span className="font-semibold">Phone</span>
        <span className="text-gray-400 font-thin">+1 (555) 123-4567</span>
      </div>
    </div>
  );
};

export default Communication;