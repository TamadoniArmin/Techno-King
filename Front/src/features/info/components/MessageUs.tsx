const MessageUs = () => {
  return (
    <div className="flex flex-col md:flex-row justify-around gap-[1.5rem] md:gap-0 mt-[3rem] md:mt-[6rem]">
      <div className="w-full md:w-[40%] flex flex-col gap-[1.2rem]">
        <h4 className="font-semibold text-[1.2rem]">Message us</h4>
        <p className="text-gray-400">
          We're here to assist you every step of the way. Whether you have a
          question, need technical support, or simply want to share your
          feedback, our dedicated team is ready to listen and provide prompt
          assistance.
        </p>
      </div>

      <div className="w-full md:w-[35%] flex flex-col gap-[1rem]">
        <input
          type="text"
          placeholder="*Your name"
          className="border border-gray-200 rounded-[0.5rem] h-[2.5rem] pl-2 text-[0.9rem]"
        />
        <input
          type="text"
          placeholder="*Email"
          className="border border-gray-200 rounded-[0.5rem] h-[2.5rem] pl-2 text-[0.9rem]"
        />
        <textarea
          placeholder="Message"
          rows={7}
          className="border border-gray-200 rounded-[0.5rem] pl-3 text-[0.9rem]"
        ></textarea>
        <button className="w-[45%] self-end text-center mt-[0.5rem] text-white font-thin py-[0.4rem] bg-primary-300 rounded-[0.5rem]">
          Submit
        </button>
      </div>
    </div>
  );
};

export default MessageUs;