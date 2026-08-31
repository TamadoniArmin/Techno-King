import CircleShape from "../../../shared/components/CircleShape";
import CircleShapePlayStation from "../../../shared/components/CircleShapePlayStation";
import iphone15 from "/iphone-15.png";
import playStation from "/ps5.png";

const FeaturedProducts = () => {
  return (
    <div className="relative my-[3rem] gap-[1.5rem] px-4 sm:px-8 md:flex md:px-[4rem] lg:px-[6.8rem]">
      <h1 className="absolute top-[10%] left-[15%] z-10 text-[1.3rem] font-semibold">
        <span>Iphone</span>
        <span className="ml-1 text-white">15 Series</span>
      </h1>
      <div className="relative h-[20rem] grow-[1.7] overflow-hidden rounded-[0.5rem] bg-gradient-to-br from-[#1975B9] via-[#1FB6CF] to-[#B0E9C9]">
        <div className="absolute right-[-1.25rem] bottom-[-1.25rem] h-[6rem] w-[6rem] rounded-[50%] border-[16px] border-[#ffffff75]"></div>
        <div className="absolute top-[-3rem] left-[14rem] h-[6rem] w-[6rem] rounded-[50%] border-[16px] border-[#ffffff75]"></div>
        <div className="absolute top-[1rem] left-[-3.5rem] h-[6rem] w-[6rem] rounded-[50%] border-[16px] border-[#ffffff75]"></div>
        <div className="absolute bottom-[-1.5rem] left-[6.8rem]">
          <CircleShape />
        </div>
        <div className="absolute right-[4.2rem] bottom-[2rem]">
          <CircleShape />
        </div>
        <img
          src={iphone15}
          alt="iphone-15"
          className="absolute bottom-[10%] left-[8%] w-[45%]"
        />
        <div className="items-left absolute left-[60%] mt-5 flex flex-col pr-5">
          <div className="flex gap-2">
            <div className="flex aspect-square w-1/4 flex-col items-center rounded-[0.5rem] border">
              <span className="font-bold">8</span>
              <span className="text-[0.8rem] md:text-[1rem]">Days</span>
            </div>
            <div className="flex aspect-square w-1/4 flex-col items-center rounded-[0.5rem] border">
              <span className="font-bold">8</span>
              <span className="text-[0.8rem] md:text-[1rem]">Days</span>
            </div>
            <div className="flex aspect-square w-1/4 flex-col items-center rounded-[0.5rem] border">
              <span className="font-bold">8</span>
              <span className="text-[0.8rem] md:text-[1rem]">Days</span>
            </div>
            <div className="flex aspect-square w-1/4 flex-col items-center rounded-[0.5rem] border">
              <span className="font-bold">8</span>
              <span className="text-[0.8rem] md:text-[1rem]">Days</span>
            </div>
          </div>
          <div className="mt-4">
            <h4 className="text-xs font-semibold whitespace-nowrap lg:text-base">
              It feels good to be the first
            </h4>
            <p className="ml-2 text-sm font-thin text-[#2D2D2D] lg:text-[1rem]">
              Get ready for the future of smartphones.Experience innovation like
              never before. Stay tuned for the big iPhone 15 pre-sale.
            </p>
          </div>
          <button className="mt-2 w-[50%] rounded-[0.5rem] bg-[#0C68F4] py-[0.6rem] text-[0.8rem] font-thin text-white">
            Register Now
          </button>
        </div>
      </div>

      <div className="relative my-20 h-[20rem] grow-1 overflow-hidden rounded-[0.5rem] bg-[#005690] md:hidden">
        <div className="absolute top-[-7rem] left-[-7rem] h-[12.5rem] w-[12.5rem] rounded-[50%] bg-[#FCC870]"></div>
        <div className="absolute bottom-[-50%] left-1/2 h-[130%] w-[120%] -translate-x-1/2 transform rounded-[50%] bg-[#FCC870]"></div>
        <div className="absolute bottom-[20%] left-[0.3rem]">
          <CircleShapePlayStation direction="vertical" />
        </div>
        <div className="absolute right-[0.5rem] bottom-[52%]">
          <CircleShapePlayStation direction="horizontal" />
        </div>
        <h2 className="mt-[2%] text-center text-[1.3rem] text-[#FCC870]">
          Play Station 5
        </h2>
        <h4 className="absolute bottom-[30%] left-1/2 z-10 -translate-x-1/2 text-[1.2rem] font-semibold whitespace-nowrap text-[#005690] md:bottom-[32%] md:left-[10%] md:translate-x-0 md:text-[1.8rem]">
          Digital Edition + 2TB
        </h4>
        <button className="absolute bottom-[12%] left-1/2 -translate-x-1/2 rounded-[0.5rem] bg-[#0C68F4] px-[2rem] py-[0.7rem] text-[0.8rem] font-thin text-white">
          Buy Now
        </button>
        <img
          src={playStation}
          alt="play station"
          className="absolute bottom-[40%] left-1/2 w-[50%] -translate-x-1/2 min-[400px]:w-[40%] min-[500px]:w-[28%]"
        />
      </div>

      <div className="relative hidden h-[20rem] grow-1 overflow-hidden rounded-[0.5rem] bg-[#005690] md:block">
        <div className="absolute top-[-7rem] left-[-7rem] h-[12.5rem] w-[12.5rem] rounded-[50%] bg-[#FCC870]"></div>
        <div className="absolute bottom-[-40%] left-1/2 h-[20rem] w-[30rem] -translate-x-1/2 transform rounded-[50%] bg-[#FCC870]"></div>
        <div className="absolute bottom-[20%] left-[0.3rem]">
          <CircleShapePlayStation direction="vertical" />
        </div>
        <div className="absolute right-[0.5rem] bottom-[52%]">
          <CircleShapePlayStation direction="horizontal" />
        </div>
        <h2 className="absolute left-1/2 mt-[25%] -translate-x-1/2 transform text-[1.3rem] whitespace-nowrap text-[#FCC870] min-[900px]:mt-[10%]">
          Play Station 5
        </h2>
        <h4 className="absolute bottom-[34%] left-[1%] z-10 text-[0.8rem] font-semibold text-[#005690] lg:left-[5%] lg:text-[1rem]">
          Digital Edition + 2TB
        </h4>
        <button className="absolute bottom-[12%] left-[3rem] rounded-[0.5rem] bg-[#0C68F4] px-[1.7rem] py-[0.5rem] text-[0.8rem] font-thin text-white">
          Buy Now
        </button>
        <img
          src={playStation}
          alt="play station"
          className="absolute top-[38%] right-[2%] w-[11rem]"
        />
      </div>
    </div>
  );
};

export default FeaturedProducts;
