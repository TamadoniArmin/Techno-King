import searchIcon from "/icons/search-normal.svg";

interface MobileSearchTriggerProps {
  onClick: () => void;
}

const MobileSearchTrigger = ({ onClick }: MobileSearchTriggerProps) => {
  return (
    <button
      onClick={onClick}
      type="button"
      className="flex w-full items-center justify-between rounded-lg bg-accent px-4 py-3 text-left"
    >
      <span className="text-sm text-gray-400">
        What can we help you to find ?
      </span>
      <img src={searchIcon} alt="Search icon" className="h-5 w-5 shrink-0" />
    </button>
  );
};

export default MobileSearchTrigger;
