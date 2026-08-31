import UserInfoField from "../components/UserInfoField";
import { NavLink, useOutletContext } from "react-router-dom";

import userIcon from "/icons/user-3.svg";
import directIcon from "/icons/direct.svg";
import keyIcon from "/icons/key2.svg";
import callIcon from "/icons/call.svg";
import homeIcon from "/icons/home-2.svg";
import postIcon from "/icons/signpost.svg";

interface UserOutletContext {
  setActiveField: React.Dispatch<React.SetStateAction<string>>;
}

const UserData = () => {
  const { setActiveField } = useOutletContext<UserOutletContext>();

  return (
    <div className="mt-6 lg:mt-[1.5rem]">
      {/* breadcrumb فقط موبایل */}
      <div className="lg:hidden text-sm text-gray-400 mb-2">
        Home <span className="mx-1">›</span>
        <NavLink to="/user" className="text-primary">
          Account
        </NavLink>
        <span className="mx-1">›</span>
        <span className="text-primary">Personal data</span>
      </div>

      <h4 className="font-semibold">Identification</h4>
      <span className="text-gray-400">Verify your identity</span>

      <div className="flex flex-col lg:grid lg:grid-cols-2 gap-y-3 lg:gap-x-[1.5rem] mt-[2rem]">
        <UserInfoField
          className="order-1"
          title="Full name"
          icon={userIcon}
          text="Jimmy Smith"
          onClick={() => setActiveField("name")}
        />
        <UserInfoField
          className="order-2"
          title="E-mail Address"
          icon={directIcon}
          text="Jimmy.smith1996@gmail.com"
          onClick={() => setActiveField("email")}
        />
        {/* در موبایل Phone number قبل از Password می‌آید */}
        <UserInfoField
          className="order-3 lg:order-4"
          title="Phone number"
          icon={callIcon}
          text="+12345678910"
          onClick={() => setActiveField("phone")}
        />
        <UserInfoField
          className="order-4 lg:order-3"
          title="Password"
          icon={keyIcon}
          text="*********"
          onClick={() => setActiveField("password")}
        />
        <UserInfoField
          className="order-5"
          title="Address"
          icon={homeIcon}
          text="HubSpot, 25 First Street, Camb..."
          onClick={() => setActiveField("address")}
        />
        <UserInfoField
          className="order-6"
          title="Postal code"
          icon={postIcon}
          text="124-3045-20"
          onClick={() => setActiveField("postalCode")}
        />
      </div>
    </div>
  );
};

export default UserData;