import { Link } from "react-router-dom";
import logo from "/logo.svg";

const Logo = () => {
  return (
    <div>
      <Link to="/">
        <img src={logo} className="w-[3rem]" />
      </Link>
    </div>
  );
};

export default Logo;
