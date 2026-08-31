import arrowRight from "/icons/arrow-circle-right.svg";
import meta from "/meta-blog.png";
import headphone from "/headphone-blog.png";
import bitcoin from "/bitcoin-blog.png";
import save from "/icons/save.svg";
import calendar from "/icons/calendar.svg";
import timer from "/icons/timer.svg";

const OurBlogs = () => {
  return (
    <section className="px-4 my-8 md:px-12 lg:px-[6.8rem] lg:my-[3rem]">
      <div className="border-b-2 border-[#B4B4B4] pb-[0.7rem]">
        <div className="flex items-center justify-between">
          <h3 className="text-xl font-semibold lg:text-[1.7rem]">Our Blogs</h3>
          <div className="flex items-center px-2 py-1">
            <span className="text-sm lg:text-base">View all</span>
            <img src={arrowRight} alt="arrow icon" className="invert" />
          </div>
        </div>
      </div>

      <div className="flex flex-col gap-4 pt-8 lg:flex-row">
        {/* کارت اول - همیشه عمودی */}
        <div className="flex w-full flex-col rounded-lg shadow-[-2px_2px_20px_#7171711f] lg:w-[34%]">
          <img src={meta} alt="meta" className="rounded-t-lg" />
          <div className="mt-2 flex justify-between px-2">
            <div className="flex items-center gap-1">
              <img src={calendar} alt="calender" />
              <span className="text-xs text-[#9E9E9E]">August , 17 , 2023</span>
            </div>
            <div className="flex items-center">
              <img src={timer} alt="timer" />
              <span className="text-xs text-[#717171]">3 min read</span>
            </div>
          </div>
          <div className="mt-1 px-2 pb-2">
            <h3 className="font-semibold">Meta Platforms plans to rel...</h3>
            <p className="text-sm">
              The parent company of Facebook, Meta Platforms, is introducing
              software to help developers.
            </p>
          </div>
        </div>

        {/* ستون راست - در موبایل هم عمودی می‌شن */}
        <div className="flex grow flex-col gap-4 rounded-lg lg:gap-[1.5rem]">
          <div className="flex flex-col items-center gap-[0.7rem] rounded-lg shadow-[-2px_2px_20px_#7171711f] lg:flex-row">
            <img
              src={headphone}
              alt="headphone"
              className="w-full rounded-t-lg lg:w-[30%] lg:rounded-l-lg lg:rounded-t-none"
            />
            <div className="w-full px-2 pb-2 lg:px-0 lg:pb-0">
              <h3 className="font-semibold lg:font-normal">
                8 Things You Probably Didn't Know About Headphones
              </h3>
              <p className="mt-[0.3rem] text-sm text-[#717171]">
                Owning a headphone could mean a different thing for different
                people. For some, it act...
              </p>
              <div className="mt-[0.8rem] flex justify-between">
                <div className="flex gap-2">
                  <img src={calendar} alt="calender" />
                  <span className="text-sm text-[#9E9E9E]">
                    March , 28 , 2023
                  </span>
                </div>
                <img src={save} alt="save" className="mr-2 lg:mr-5" />
              </div>
            </div>
          </div>

          <div className="flex flex-col items-center gap-[0.7rem] rounded-lg shadow-[-2px_2px_20px_#7171711f] lg:flex-row">
            <img
              src={bitcoin}
              alt="bitcoin"
              className="w-full rounded-t-lg lg:w-[30%] lg:rounded-l-lg lg:rounded-t-none"
            />
            <div className="w-full px-2 pb-2 lg:px-0 lg:pb-0">
              <h3 className="font-semibold lg:font-normal">
                Analyzing the August 17th Bitcoin Price Drop
              </h3>
              <p className="mt-[0.3rem] text-sm text-[#717171]">
                On August 17th at 9:30PM UTC, Bitcoin's price dropped more than
                8% in a 10-min...
              </p>
              <div className="mt-[0.8rem] flex justify-between">
                <div className="flex gap-2">
                  <img src={calendar} alt="calender" />
                  <span className="text-sm text-[#9E9E9E]">
                    August , 17 , 2023
                  </span>
                </div>
                <img src={save} alt="save" className="mr-2 lg:mr-5" />
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default OurBlogs;