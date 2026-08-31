import meta from "/meta-blog.png";
import calendar from "/icons/calendar.svg";
import timer from "/icons/timer.svg";

const TopBlogs = () => {
  return (
    <div className="grid grid-cols-1 md:grid-cols-2 gap-[1.2rem]">
      <div className="flex flex-col gap-[0.5rem] rounded-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img src={meta} alt="Meata picture" className="rounded-t-[0.5rem]"/>
        <div className="px-[0.5rem] pb-[0.5rem] flex flex-col gap-[0.5rem]">
          <div className="flex justify-between">
            <div className="flex items-center">
              <img src={calendar} alt="Calender icon" />
              <span className="text-gray-400  text-[0.8rem]">
                August , 8 , 2023
              </span>
            </div>
            <div className="flex items-center">
              <img src={timer} alt="Timer icon" />
              <span className="text-gray-400  text-[0.8rem]">3 min read</span>
            </div>
          </div>
          <h3 className="font-semibold">
            Meta Platforms plans to release free...
          </h3>
          <p className="text-[0.9rem]">
            The parent company of Facebook, Meta Platforms, is introducing
            software to help deve...
          </p>
        </div>
      </div>

      <div className="flex flex-col gap-[0.5rem] rounded-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img src={meta} alt="Meata picture" className="rounded-t-[0.5rem]"/>
        <div className="px-[0.5rem] pb-[0.5rem] flex flex-col gap-[0.5rem]">
          <div className="flex justify-between">
            <div className="flex items-center">
              <img src={calendar} alt="Calender icon" />
              <span className="text-gray-400  text-[0.8rem]">
                August , 8 , 2023
              </span>
            </div>
            <div className="flex items-center">
              <img src={timer} alt="Timer icon" />
              <span className="text-gray-400  text-[0.8rem]">3 min read</span>
            </div>
          </div>
          <h3 className="font-semibold">
            Meta Platforms plans to release free...
          </h3>
          <p className="text-[0.9rem]">
            The parent company of Facebook, Meta Platforms, is introducing
            software to help deve...
          </p>
        </div>
      </div>

      <div className="flex flex-col gap-[0.5rem] rounded-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img src={meta} alt="Meata picture" className="rounded-t-[0.5rem]"/>
        <div className="px-[0.5rem] pb-[0.5rem] flex flex-col gap-[0.5rem]">
          <div className="flex justify-between">
            <div className="flex items-center">
              <img src={calendar} alt="Calender icon" />
              <span className="text-gray-400  text-[0.8rem]">
                August , 8 , 2023
              </span>
            </div>
            <div className="flex items-center">
              <img src={timer} alt="Timer icon" />
              <span className="text-gray-400 text-[0.8rem]">3 min read</span>
            </div>
          </div>
          <h3 className="font-semibold">
            Meta Platforms plans to release free...
          </h3>
          <p className="text-[0.9rem]">
            The parent company of Facebook, Meta Platforms, is introducing
            software to help deve...
          </p>
        </div>
      </div>

      <div className="flex flex-col gap-[0.5rem] rounded-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img src={meta} alt="Meata picture" className="rounded-t-[0.5rem]"/>
        <div className="px-[0.5rem] pb-[0.5rem] flex flex-col gap-[0.5rem]">
          <div className="flex justify-between">
            <div className="flex items-center">
              <img src={calendar} alt="Calender icon" />
              <span className="text-gray-400  text-[0.8rem]">
                August , 8 , 2023
              </span>
            </div>
            <div className="flex items-center">
              <img src={timer} alt="Timer icon" />
              <span className="text-gray-400  text-[0.8rem]">3 min read</span>
            </div>
          </div>
          <h3 className="font-semibold">
            Meta Platforms plans to release free...
          </h3>
          <p className="text-[0.9rem]">
            The parent company of Facebook, Meta Platforms, is introducing
            software to help deve...
          </p>
        </div>
      </div>
    </div>
  );
};

export default TopBlogs;
