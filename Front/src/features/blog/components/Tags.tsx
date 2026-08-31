const Tags = () => {
  return (
    <div className="flex flex-col gap-[1rem] md:gap-[1.5rem]">
      <h4 className="font-semibold text-[1.1rem] md:text-[1.2rem]">Tags</h4>
      <div className="grid grid-cols-2 md:grid-cols-3 gap-x-[0.5rem] gap-y-[0.8rem] md:gap-y-[1rem]">
        <button className="border-2 border-primary-300 text-primary-300 rounded-[0.5rem] py-[0.5rem] md:py-[0.6rem] text-[0.85rem] md:text-base">
          Technology
        </button>
        <button className="border-2 border-primary-300 text-primary-300 rounded-[0.5rem] py-[0.5rem] md:py-[0.6rem] text-[0.85rem] md:text-base">
          Headset
        </button>
        <button className="border-2 border-primary-300 text-primary-300 rounded-[0.5rem] py-[0.5rem] md:py-[0.6rem] text-[0.85rem] md:text-base">
          Phone
        </button>
        <button className="border-2 border-primary-300 text-primary-300 rounded-[0.5rem] py-[0.5rem] md:py-[0.6rem] text-[0.85rem] md:text-base">
          Wireless
        </button>
        <button className="border-2 border-primary-300 text-primary-300 rounded-[0.5rem] py-[0.5rem] md:py-[0.6rem] text-[0.85rem] md:text-base">
          Apple
        </button>
      </div>
    </div>
  );
};

export default Tags;