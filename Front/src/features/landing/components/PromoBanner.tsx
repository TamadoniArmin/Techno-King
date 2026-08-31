import smartWatch from "/smart-watch.png";

const PromoBanner = () => {
  return (
    <section className="px-4 mb-5 md:px-12 lg:px-[6.8rem]">
      <div className="relative flex h-[14rem] items-center justify-between overflow-hidden rounded-lg bg-[#223949] px-6 md:h-[17rem] md:px-10 lg:h-[20rem] lg:px-15">
        <div className="absolute left-[55%] top-1/2 h-[300px] w-[380px] -translate-y-1/2 rounded-full bg-[#FF6951] md:h-[420px] md:w-[550px] lg:left-[65%] lg:h-[550px] lg:w-[700px]"></div>

        <div className="flex flex-col items-start justify-center lg:items-center">
          <h2 className="mb-2 text-xl font text-white md:text-3xl lg:text-[2.2rem]">
            SMART WATCH
          </h2>
          <span className="text-sm text-white md:text-base lg:text-[1.1rem]">
            Various designs and brands
          </span>
          <button className="mt-4 rounded-lg bg-[#FF6951] px-3 py-1 text-xs text-white md:text-sm lg:mt-6 lg:text-[0.9rem]">
            Shop Now
          </button>
        </div>

        <img
          src={smartWatch}
          alt="smart watch"
          className="z-10 w-[55%] scale-100 md:w-[45%] lg:w-auto lg:scale-85"
        />
      </div>
    </section>
  );
};

export default PromoBanner;