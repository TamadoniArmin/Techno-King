import test from "/iphone15.png";

interface SearchPanelResultsProps {
  products?: unknown[]; // 
  isLoading: boolean;
  isError: boolean;
}

const SearchPanelResults = ({
  products,
  isLoading,
  isError,
}: SearchPanelResultsProps) => {
  if (isLoading) {
    return <p className="py-8 text-center text-sm text-gray-500">Loading...</p>;
  }

  if (isError) {
    return (
      <p className="py-8 text-center text-sm text-red-500">
        Something went wrong. Please try again.
      </p>
    );
  }

  return (
    <div className="flex flex-col gap-8 md:flex-row md:justify-between md:gap-10">
      <div className="flex flex-1 flex-col gap-4 sm:gap-5">
        <h4 className="text-sm font-medium sm:text-base">
          view 17 out of 30 results
        </h4>
        <ul className="grid grid-cols-2 gap-x-6 gap-y-3 sm:gap-x-8 sm:gap-y-4">
          <li className="text-sm">X Case</li>
          <li className="text-sm">13 Case</li>
          <li className="text-sm">11 Case</li>
          <li className="text-sm">13 Pro Case</li>
          <li className="text-sm">11 Pro Case</li>
          <li className="text-sm">13 Promax Case</li>
          <li className="text-sm">11 Promax Case</li>
          <li className="text-sm">SE Case</li>
          <li className="text-sm">12 Case</li>
          <li className="text-sm">14 Case</li>
          <li className="text-sm">12 mini Case</li>
          <li className="text-sm">14 Plus Case</li>
          <li className="text-sm">12 Pro Case</li>
          <li className="text-sm">14 Pro Case</li>
          <li className="text-sm">12 Promax Case</li>
          <li className="text-sm">14 Promax Case</li>
          <li className="text-sm">13 mini Case</li>
          <li className="text-primary-300 col-span-2 text-sm sm:col-span-1">
            Tap for more
          </li>
        </ul>
      </div>

      <ul className="grid flex-1 grid-cols-2 gap-3 sm:grid-cols-3 sm:gap-4 md:flex-[0.8]">
        {[1, 2, 3, 4, 5, 6].map((item) => (
          <li
            key={item}
            className="flex flex-col items-center justify-center rounded-lg p-2 text-center text-xs shadow-[-2px_2px_20px_#2924241f] sm:text-sm"
          >
            <img src={test} alt="Cases & Protection" className="w-full max-w-[60px] sm:max-w-[80px]" />
            <span>Cases & Protection</span>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default SearchPanelResults;