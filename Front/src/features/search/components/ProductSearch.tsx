import SearchIcon from "/icons/search-2.svg";
import closehIcon from "/icons/close-circle.svg";
import SearchPanelSugestions from "./SearchPanelSuggestions";
import SearchPanelResults from "./SearchPanelResults";
import { useState } from "react";
import { useGetByNameProducts } from "../../products/hooks/useGetByNameProducts";
import { useNavigate } from "react-router-dom";

const ProductSearch = () => {
  const [inputValue, setInputValue] = useState("");
  const [searchQuery, setSearchQuery] = useState("");

  const navigate = useNavigate();

  const {
    data: products,
    isLoading,
    isError,
  } = useGetByNameProducts(searchQuery);

  function handleSearch() {
    const trimmedValue = inputValue.trim();
    setSearchQuery(trimmedValue);
    navigate(`/search?query=${encodeURIComponent(trimmedValue)}`);
  }

  function handleKeyDown(e: React.KeyboardEvent<HTMLInputElement>) {
    if (e.key === "Enter") {
      handleSearch();
    }
  }

  function handleClear() {
    setInputValue("");
    setSearchQuery("");
  }

  return (
    <div className="mx-auto w-[80%] rounded-[0.5rem] bg-white px-[3rem] pt-[2rem] pb-[3.5rem]">
      <div className="mb-[2rem] flex items-center justify-between">
        <div className="flex w-[70%] items-center justify-between rounded-[0.5rem] border-[2px] p-2">
          <input
            type="text"
            value={inputValue}
            onChange={(e) => setInputValue(e.target.value)}
            onKeyDown={handleKeyDown}
            placeholder="What can we help you to find ?"
            className="w-full border-none outline-none"
          />
          <button onClick={handleSearch} type="button">
            <img src={SearchIcon} alt="Search icon" />
          </button>
        </div>
        <button onClick={handleClear} type="button">
          <img src={closehIcon} alt="Close icon" />
        </button>
      </div>

      {searchQuery.trim().length === 0 && <SearchPanelSugestions />}

      {searchQuery.trim().length > 0 && (
        <SearchPanelResults
          products={products}
          isLoading={isLoading}
          isError={isError}
        />
      )}
    </div>
  );
};

export default ProductSearch;
