import recent from "/bitcoin-blog.png";
import calendar from "/icons/calendar.svg";

const RecentPosts = () => {
  return (
    <div className="my-10 flex flex-col gap-5">
      <h2 className="text-[1.2rem] font-semibold">Recent posts</h2>
      <div className="flex w-[90%] gap-[1rem] rounded-r-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img
          src={recent}
          alt="Recent post"
          className="w-[6.5rem] shrink-0 rounded-l-[0.5rem] object-cover md:w-[9rem]"
        />
        <div className="py-[0.8rem] pr-[0.5rem] md:py-[1.2rem]">
          <h3 className="text-[0.9rem] font-semibold md:text-[1rem]">
            Encryption Keeps Kids Safe Online
          </h3>
          <p className="mt-[0.4rem] mb-[0.6rem] text-[0.75rem] text-gray-400 md:mt-[0.5rem] md:mb-[0.8rem] md:text-sm">
            Policymakers are proposing laws that will weaken encryption. The
            EARN IT Act, STOP CSAM Act, and many other proposed bills...
          </p>
          <div className="flex items-center gap-2">
            <img src={calendar} alt="Calender icon" />
            <span className="text-[0.8rem] text-gray-400">May , 17 , 2023</span>
          </div>
        </div>
      </div>
      <div className="flex w-[90%] gap-[1rem] rounded-r-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img
          src={recent}
          alt="Recent post"
          className="w-[6.5rem] shrink-0 rounded-l-[0.5rem] object-cover md:w-[9rem]"
        />
        <div className="py-[0.8rem] pr-[0.5rem] md:py-[1.2rem]">
          <h3 className="text-[0.9rem] font-semibold md:text-[1rem]">
            Encryption Keeps Kids Safe Online
          </h3>
          <p className="mt-[0.4rem] mb-[0.6rem] text-[0.75rem] text-gray-400 md:mt-[0.5rem] md:mb-[0.8rem] md:text-sm">
            Policymakers are proposing laws that will weaken encryption. The
            EARN IT Act, STOP CSAM Act, and many other proposed bills...
          </p>
          <div className="flex items-center gap-2">
            <img src={calendar} alt="Calender icon" />
            <span className="text-[0.8rem] text-gray-400">May , 17 , 2023</span>
          </div>
        </div>
      </div>
      <div className="flex w-[90%] gap-[1rem] rounded-r-[0.5rem] shadow-[-2px_2px_20px_#7171711f]">
        <img
          src={recent}
          alt="Recent post"
          className="w-[6.5rem] shrink-0 rounded-l-[0.5rem] object-cover md:w-[9rem]"
        />
        <div className="py-[0.8rem] pr-[0.5rem] md:py-[1.2rem]">
          <h3 className="text-[0.9rem] font-semibold md:text-[1rem]">
            Encryption Keeps Kids Safe Online
          </h3>
          <p className="mt-[0.4rem] mb-[0.6rem] text-[0.75rem] text-gray-400 md:mt-[0.5rem] md:mb-[0.8rem] md:text-sm">
            Policymakers are proposing laws that will weaken encryption. The
            EARN IT Act, STOP CSAM Act, and many other proposed bills...
          </p>
          <div className="flex items-center gap-2">
            <img src={calendar} alt="Calender icon" />
            <span className="text-[0.8rem] text-gray-400">May , 17 , 2023</span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RecentPosts;
