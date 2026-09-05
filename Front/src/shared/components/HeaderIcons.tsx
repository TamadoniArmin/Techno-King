import searchIcon from "/icons/search-normal.svg";
import bagIcon from "/icons/bag.svg";
import userIcon from "/icons/user.svg";
import { NavLink } from "react-router-dom";

interface HeaderIconsProps {
  onSearchClick?: () => void;
}

const HeaderIcons = ({ onSearchClick }: HeaderIconsProps) => {
  return (
    <div className="flex gap-[0.5rem]">
      <NavLink to="/" onClick={onSearchClick} className="hidden md:block">
        <img src={searchIcon} className="w-[1.5rem]" />
      </NavLink>
      <NavLink to="/">
        <img src={bagIcon} className="w-[1.5rem]" />
      </NavLink>
      <NavLink to="/">
        <img src={userIcon} className="w-[1.5rem]" />
      </NavLink>
    </div>
  );
};

export default HeaderIcons;
