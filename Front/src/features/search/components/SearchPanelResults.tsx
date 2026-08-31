import test from "/iphone15.png";

const SearchPanelResults = () => {
  return (
    <div className="flex justify-between">
      <div className="flex flex-col gap-5">
        <h4>view 17 out of 30 results</h4>
        <ul className="grid grid-cols-2 gap-x-[2rem] gap-y-[1.5rem]">
          <li className="text-sm">X Case </li>
          <li className="text-sm">13 Case</li>
          <li className="text-sm">11 Case</li>
          <li className="text-sm">13 Pro Case</li>
          <li className="text-sm">11 Pro Case</li>
          <li className="text-sm">13 Promax Case</li>
          <li className="text-sm">11 Promax Case</li>
          <li className="text-sm">SE Case </li>
          <li className="text-sm">12 Case</li>
          <li className="text-sm">14 Case</li>
          <li className="text-sm">12 mini Case </li>
          <li className="text-sm">14 Plus Case </li>
          <li className="text-sm">12 Pro Case</li>
          <li className="text-sm">14 Pro Case</li>
          <li className="text-sm">12 Promax Case</li>
          <li className="text-sm">14 Promax Case</li>
          <li className="text-sm">13 mini Case</li>
          <li className="text-primary-300">Tap for more</li>
        </ul>
      </div>

      <ul className="grid grid-cols-3 gap-[1.5rem]">
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
        <li className="flex flex-col items-center justify-center text-center  p-2 rounded-[0.5rem] shadow-[-2px_2px_20px_#2924241f]">
          <img src={test} alt="test" />
          <span>Cases & Protection</span>
        </li>
      </ul>
    </div>
  );
};

export default SearchPanelResults;
