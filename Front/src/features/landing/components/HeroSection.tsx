import heroBanner from "/hero-banner.png";

const HeroSection = () => {
  return (
    <div className="mx-auto flex max-w-[1440px] flex-col items-center justify-between px-4 sm:px-8 md:px-[4rem] lg:px-[6.8rem] pb-10 md:flex-row md:items-start md:pb-[3.5rem]">
      {/* بخش متن و دکمه */}
      <div className="order-2 mt-10 flex flex-col items-center text-center md:order-1 md:mt-0 md:items-start md:text-left">
        <div>
          <h1 className="text-primary-700 mb-3 text-4xl font-semibold md:mt-[2.2rem] md:mb-[1.3rem] md:text-[3rem] lg:text-[3.5rem]">
            Tech Heim
          </h1>
          <div className="text-md text-primary-700 font-semibold md:text-[1.2rem] lg:text-[1.8rem]">
            "Join the{" "}
            <span className="text-secondary-400">digital revolution</span>"
          </div>
        </div>

        <button className="bg-secondary-400 hover:bg-opacity-90 mt-8 h-[3rem] w-48 rounded-[8px] text-white transition-colors md:mt-[6rem] md:w-[15rem]">
          Explore More
        </button>
      </div>

      {/* بخش تصویر */}
      <div className="order-1 w-full max-w-[20rem] shrink-0 md:order-2 md:max-w-[32.5rem]">
        <img
          src={heroBanner}
          alt="heroBanner"
          className="h-auto w-full object-contain md:mt-2"
        />
      </div>
    </div>
  );
};

export default HeroSection;
