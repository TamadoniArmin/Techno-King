import searchIcon from "/icons/search-normal.svg";
import bagIcon from "/icons/bag.svg";
import userIcon from "/icons/user.svg";
import { NavLink } from "react-router-dom";

const HeaderIcons = () => {
  return (
    <div className="flex gap-[0.5rem]">
      <NavLink to="/">
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
