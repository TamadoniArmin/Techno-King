import { NavLink } from "react-router-dom";

const HeaderNav = () => {
  return (
    <div>
      <ul className="flex gap-12">
        <NavLink to="/">
          <li>Home</li>
        </NavLink>
        <NavLink to="/">
          <li>Products</li>
        </NavLink>
        <NavLink to="/blogs">
          <li>Blog</li>
        </NavLink>
        <NavLink to="/faq">
          <li>FAQ</li>
        </NavLink>
        <NavLink to="/contact">
          <li>Contact Us</li>
        </NavLink>
      </ul>
    </div>
  );
};

export default HeaderNav;
