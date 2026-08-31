import { NavLink } from "react-router-dom";
import profilePicture from "/icons/profile-circle2.svg";
import userEditIcon from "/icons/user-edit.svg";
import dollarIcon from "/icons/dollar-circle.svg";
import orderIcon from "/icons/bag.svg";
import favoriteIcon from "/icons/heart.svg";
import giftIcon from "/icons/gift.svg";
import securityIcon from "/icons/security-safe.svg";
import notificationIcon from "/icons/notification.svg";
import supportIcon from "/icons/24-support.svg";
import logoutIcon from "/icons/logout.svg";

const menuItems = [
  { to: "/user/payment", icon: dollarIcon, label: "Payment & Instalments" },
  { to: "/user/orders", icon: orderIcon, label: "Orders" },
  { to: "/user/favorites", icon: favoriteIcon, label: "Whish list" },
  { to: "/user/discount", icon: giftIcon, label: "Discounts" },
  { to: "/user/security", icon: securityIcon, label: "Security & access" },
  { to: "/user/notification", icon: notificationIcon, label: "Notification" },
  { to: "/contact", icon: supportIcon, label: "Contact us" },
];

interface AccountSidebarProps {
  mobile?: boolean;
}

const AccountSidebar = ({ mobile = false }: AccountSidebarProps) => {
  if (mobile) {
    return (
      <div className="w-full">
        <div className="text-sm text-gray-400 mb-2">
          Home <span className="mx-1">›</span>
          <span className="text-primary">Account</span>
        </div>

        <h3 className="font-semibold mb-3">User</h3>

        <div className="flex items-center justify-between border-b py-3 gap-3">
          <div className="flex items-center gap-3 min-w-0">
            <img
              src={profilePicture}
              className="w-10 h-10 rounded-full shrink-0"
              alt="Profile picture"
            />
            <span className="font-medium truncate">Jimmy Smith</span>
          </div>
          <NavLink
            to="/user/personal"
            className="text-primary text-sm flex items-center gap-1 shrink-0"
          >
            <img src={userEditIcon} className="w-4 h-4" alt="" />
            Personal data
          </NavLink>
        </div>

        <ul>
          {menuItems.map((item) => (
            <li key={item.to} className="border-b">
              <NavLink
                to={item.to}
                className="flex items-center justify-between py-3 gap-3"
              >
                <span className="flex items-center gap-3 min-w-0">
                  <img src={item.icon} alt="" className="w-5 h-5 shrink-0" />
                  <span className="truncate">{item.label}</span>
                </span>
                <span className="text-gray-300 shrink-0">›</span>
              </NavLink>
            </li>
          ))}
          <li className="py-3">
            <NavLink to="/" className="flex items-center gap-3 text-error">
              <img src={logoutIcon} alt="Log out icon" className="w-5 h-5" />
              Log out
            </NavLink>
          </li>
        </ul>
      </div>
    );
  }

  // نسخه دسکتاپ
  return (
    <div className="w-full pl-[1rem] bg-gray-50 rounded-[0.5rem] py-4">
      <div className="flex items-center gap-3">
        <img src={profilePicture} alt="Profile picture" className="shrink-0" />
        <h2 className="font-semibold">Jimmy smith</h2>
      </div>

      <ul className="flex flex-col">
        {menuItems.map((item) => (
          <li key={item.to} className="flex gap-3 py-[0.8rem] items-center">
            <img src={item.icon} alt="" className="shrink-0" />
            <NavLink to={item.to} className="truncate">
              {item.label}
            </NavLink>
          </li>
        ))}
        <li className="flex gap-3 py-[0.8rem] items-center">
          <img src={logoutIcon} alt="Log out icon" className="shrink-0" />
          <NavLink to="/" className="text-error">
            Log out
          </NavLink>
        </li>
      </ul>
    </div>
  );
};

export default AccountSidebar;