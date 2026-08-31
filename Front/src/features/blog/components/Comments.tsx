import profile from "/profile.jpg";
import star from "/icons/star2.svg";

const Comments = () => {
  return (
    <div className="my-[2rem] md:my-[2.5rem]">
      <h4 className="font-semibold mb-[1rem] md:mb-[1.5rem]">Comments</h4>
      <div className="flex flex-col p-[1rem] bg-gray-25 border border-gray-75 rounded-[0.5rem]">
        <div className="flex justify-between items-center gap-2">
          <div className="flex items-center gap-2 md:gap-3">
            <img
              src={profile}
              alt="Profile picture"
              className="w-[45px] md:w-[60px] rounded-[50%] shrink-0"
            />
            <div>
              <h4 className="font-semibold text-[1rem] md:text-[1.2rem]">Anna Ley</h4>
              <span className="text-gray-300 text-[0.75rem] md:text-[0.8rem]">
                March 30, 2023
              </span>
            </div>
          </div>

          <div className="flex gap-1 items-center bg-primary-500 px-2 py-[4px] rounded-[0.5rem] shrink-0">
            <img src={star} alt="Star icon" />
            <span className="text-white text-[0.85rem] md:text-base">4.6</span>
          </div>
        </div>

        <div className="my-[0.8rem]">
          <p className="text-[0.85rem] md:text-base">
            This article deepened my appreciation for headphones as not only
            devices of entertainment but also as a blend of science and
            innovation that enrich our auditory experiences.
          </p>
        </div>

        <div className="self-end">
          <div className="flex items-center gap-2">
            <span className="text-primary-300 font-semibold text-[0.85rem] md:text-[0.9rem]">
              Show More
            </span>
            <svg
              width="22"
              height="22"
              viewBox="0 0 24 24"
              fill="none"
              xmlns="http://www.w3.org/2000/svg"
            >
              <path
                d="M11.9995 16.8C11.2995 16.8 10.5995 16.53 10.0695 16L3.54953 9.48001C3.25953 9.19001 3.25953 8.71001 3.54953 8.42001C3.83953 8.13001 4.31953 8.13001 4.60953 8.42001L11.1295 14.94C11.6095 15.42 12.3895 15.42 12.8695 14.94L19.3895 8.42001C19.6795 8.13001 20.1595 8.13001 20.4495 8.42001C20.7395 8.71001 20.7395 9.19001 20.4495 9.48001L13.9295 16C13.3995 16.53 12.6995 16.8 11.9995 16.8Z"
                fill="#0C68F4"
              />
            </svg>
          </div>
          <div className="flex gap-3 mt-[1.2rem]">
            <div className="flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 32 32"
                className="w-[18px]"
              >
                <path
                  d="M27 11h-8.52L19 9.8A6.42 6.42 0 0 0 13 1a1 1 0 0 0-.93.63L8.32 11H5a3 3 0 0 0-3 3v14a3 3 0 0 0 3 3h18.17a3 3 0 0 0 2.12-.88l3.83-3.83a3 3 0 0 0 .88-2.12V14a3 3 0 0 0-3-3zM4 28V14a1 1 0 0 1 1-1h3v16H5a1 1 0 0 1-1-1zm24-3.83a1 1 0 0 1-.29.71l-3.83 3.83a1.05 1.05 0 0 1-.71.29H10V12.19l3.66-9.14a4.31 4.31 0 0 1 3 1.89 4.38 4.38 0 0 1 .44 4.12l-1 2.57A1 1 0 0 0 17 13h10a1 1 0 0 1 1 1z"
                  data-name="thumb up android app aplication phone"
                  fill="#0c68f4"
                />
              </svg>
              <span className="text-gray-400">10</span>
            </div>
            <span className="text-gray-400">|</span>
            <div className="flex items-center gap-2">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 32 32"
                className="w-[18px] scale-[-1]"
              >
                <path
                  d="M27 11h-8.52L19 9.8A6.42 6.42 0 0 0 13 1a1 1 0 0 0-.93.63L8.32 11H5a3 3 0 0 0-3 3v14a3 3 0 0 0 3 3h18.17a3 3 0 0 0 2.12-.88l3.83-3.83a3 3 0 0 0 .88-2.12V14a3 3 0 0 0-3-3zM4 28V14a1 1 0 0 1 1-1h3v16H5a1 1 0 0 1-1-1zm24-3.83a1 1 0 0 1-.29.71l-3.83 3.83a1.05 1.05 0 0 1-.71.29H10V12.19l3.66-9.14a4.31 4.31 0 0 1 3 1.89 4.38 4.38 0 0 1 .44 4.12l-1 2.57A1 1 0 0 0 17 13h10a1 1 0 0 1 1 1z"
                  data-name="thumb up android app aplication phone"
                  fill="#0c68f4"
                />
              </svg>
              <span className="text-gray-400">2</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Comments;