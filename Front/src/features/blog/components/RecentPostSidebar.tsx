import test from "/blog-test2.png";
import calendarIcon from "/icons/calendar.svg";

const RecentPostSidebar = () => {
  return (
    <div className="flex flex-col gap-[1rem] md:gap-[1.5rem]">
      <h4 className="font-semibold text-[1.1rem] md:text-[1.2rem]">Recent Posts</h4>
      <div className="flex shadow-[-2px_2px_15px_-1px_#7171712b] rounded-r-[0.5rem]">
        <img
          src={test}
          alt="Recent post picture"
          className="rounded-l-[0.5rem] w-[6rem] md:w-auto object-cover shrink-0"
        />
        <div className="px-[0.8rem] md:px-[1rem] py-[0.8rem] md:py-[1.2rem]">
          <h3 className="font-semibold text-[0.95rem] md:text-[1.1rem]">Should You Buy The...</h3>
          <p className="mt-[0.2rem] text-gray-400 text-[0.8rem] md:text-base">Be it an iPhone or any other Apple device, they...</p>
          <div className="flex items-center gap-2 mt-[0.5rem]">
            <img src={calendarIcon} alt="Calendar icon" />
            <span className="text-gray-400 text-[0.8rem] md:text-base">August , 7 , 2023</span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RecentPostSidebar;