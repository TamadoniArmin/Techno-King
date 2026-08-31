import arrowDown from "/icons/arrow-down.svg";

type CurrentPageProps = {
  pageNumber?: number;
  curPage: string;
  prevPage?: string;
};

const CurrentPage = ({
  pageNumber = 1,
  curPage,
  prevPage,
}: CurrentPageProps) => {
  if (pageNumber === 1)
    return (
      <div className="mt-6 flex items-center gap-2">
        <span className="text-gray-400">Home</span>
        <img src={arrowDown} alt="Arrow down icon" />
        <span className="text-primary-300 border-primary-300 border-b">
          {curPage}
        </span>
      </div>
    );
  if (pageNumber === 2)
    return (
      <div className="mt-6 flex items-center gap-2">
        <span className="text-gray-400">Home</span>
        <img src={arrowDown} alt="Arrow down icon" />
        <span className="text-gray-400">{prevPage}</span>
        <img src={arrowDown} alt="Arrow down icon" />
        <span className="text-primary-300 border-primary-300 border-b">
          {curPage}
        </span>
      </div>
    );
};

export default CurrentPage;