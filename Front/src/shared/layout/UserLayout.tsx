import { Outlet, useLocation, useMatches } from "react-router-dom";
import AccountSidebar from "../../features/user/components/AccountSidebar";
import Header from "../components/layout/Header";
import PaymentModal from "../../features/payment/modals/PaymentModal";
import EditPersonalDataModal from "../../features/user/modals/EditPersonalDataModal";
import { useState } from "react";

interface RouteHandle {
  fullWidth?: boolean;
}

const UserLayout = () => {
  const [activeField, setActiveField] = useState("");
  const [activePayment, setActivePayment] = useState(false);
  const location = useLocation();
  const matches = useMatches();

  const isMenuRoot = location.pathname.replace(/\/$/, "") === "/user";

  // اگر route فعال handle.fullWidth داشته باشد، سایدبار به‌طور کامل حذف می‌شود
  const isFullWidthPage = matches.some(
    (match) => (match.handle as RouteHandle | undefined)?.fullWidth
  );

  function closeHandler() {
    setActiveField("");
  }

  function closePaymentModal() {
    setActivePayment(false);
  }

  return (
    <div>
      <Header />
      {activePayment && <PaymentModal closeHandler={closePaymentModal} />}

      {activeField === "name" && (
        <EditPersonalDataModal
          isName={true}
          title="First name and Last name"
          closeHandler={closeHandler}
        />
      )}
      {activeField === "email" && (
        <EditPersonalDataModal
          title="Email"
          text="Email"
          closeHandler={closeHandler}
        />
      )}
      {activeField === "phone" && (
        <EditPersonalDataModal
          title="Phone number"
          text="Phone number"
          closeHandler={closeHandler}
        />
      )}
      {activeField === "password" && (
        <EditPersonalDataModal
          title="Password"
          text="Password"
          closeHandler={closeHandler}
        />
      )}
      {activeField === "address" && (
        <EditPersonalDataModal
          title="Address"
          text="Address"
          closeHandler={closeHandler}
        />
      )}
      {activeField === "postalCode" && (
        <EditPersonalDataModal
          title="Postal code"
          text="Postal code"
          closeHandler={closeHandler}
        />
      )}

      <div className="px-4 lg:px-[6.8rem] flex flex-col lg:flex-row gap-6 lg:gap-[1.5rem] mt-6 lg:mt-[2.5rem] mb-10 lg:mb-[5rem]">
        {/* دسکتاپ: سایدبار فقط زمانی نمایش داده شود که صفحه fullWidth نباشد */}
        {!isFullWidthPage && (
          <div className="hidden lg:block lg:w-[280px] lg:shrink-0">
            <AccountSidebar />
          </div>
        )}

        {/* موبایل: لیست منو فقط دقیقاً روی /user و فقط اگر fullWidth نباشد */}
        {isMenuRoot && !isFullWidthPage && (
          <div className="lg:hidden">
            <AccountSidebar mobile />
          </div>
        )}

        {/* محتوای زیرصفحه */}
        <div
          className={
            isMenuRoot && !isFullWidthPage
              ? "hidden lg:block flex-1 min-w-0"
              : "flex-1 min-w-0"
          }
        >
          <Outlet context={{ setActivePayment, setActiveField }} />
        </div>
      </div>
    </div>
  );
};

export default UserLayout;