const SearchPanelSugestions = () => {
  return (
    <div className="flex gap-[3rem]">
      <div className="flex flex-col gap-[1.5rem]">
        <h3 className="font-semibold text-[1.1rem]">The Most Searched Items</h3>
        <ul className="grid grid-cols-2 gap-x-[2rem] gap-y-[1.5rem]">
          <li>MacBook Pro </li>
          <li>JBL speaker</li>
          <li>AirPods Pro</li>
          <li>Canon</li>
          <li>Samsung S9</li>
          <li>AirPods Max</li>
          <li>Tablet</li>
          <li>Asus </li>
          <li>Xiaomi </li>
          <li>MagSafe</li>
        </ul>
      </div>

      <div className="flex flex-col gap-[1.5rem]">
        <h3 className="font-semibold text-[1.1rem]">Most used keywords</h3>
        <ul className="grid grid-cols-2 gap-x-[2rem] gap-y-[1.5rem]">
          <li>Tablets</li>
          <li>Laptops</li>
          <li>Headphones</li>
          <li>USB Drive</li>
          <li>Smartphones</li>
          <li>Phone Cases</li>
          <li>Smartwatch</li>
        </ul>
      </div>
    </div>
  );
};

export default SearchPanelSugestions;
