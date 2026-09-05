const SearchPanelSugestions = () => {
  return (
    <div className="flex flex-col gap-8 sm:flex-row sm:gap-[3rem]">
      <div className="flex flex-col gap-3 sm:gap-[1.5rem]">
        <h3 className="text-sm font-semibold sm:text-[1.1rem]">
          The Most Searched Items
        </h3>
        <ul className="grid grid-cols-2 gap-x-4 gap-y-2 sm:gap-x-[2rem] sm:gap-y-[1.5rem]">
          <li className="whitespace-nowrap text-xs sm:text-base">MacBook Pro</li>
          <li className="whitespace-nowrap text-xs sm:text-base">JBL speaker</li>
          <li className="whitespace-nowrap text-xs sm:text-base">AirPods Pro</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Canon</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Samsung S9</li>
          <li className="whitespace-nowrap text-xs sm:text-base">AirPods Max</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Tablet</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Asus</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Xiaomi</li>
          <li className="whitespace-nowrap text-xs sm:text-base">MagSafe</li>
        </ul>
      </div>

      <div className="flex flex-col gap-3 sm:gap-[1.5rem]">
        <h3 className="text-sm font-semibold sm:text-[1.1rem]">
          Most used keywords
        </h3>
        <ul className="grid grid-cols-2 gap-x-4 gap-y-2 sm:gap-x-[2rem] sm:gap-y-[1.5rem]">
          <li className="whitespace-nowrap text-xs sm:text-base">Tablets</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Laptops</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Headphones</li>
          <li className="whitespace-nowrap text-xs sm:text-base">USB Drive</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Smartphones</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Phone Cases</li>
          <li className="whitespace-nowrap text-xs sm:text-base">Smartwatch</li>
        </ul>
      </div>
    </div>
  );
};

export default SearchPanelSugestions;