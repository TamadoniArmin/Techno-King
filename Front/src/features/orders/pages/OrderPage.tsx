import { Outlet, useMatch } from "react-router-dom";
import OrderHistory from "../components/OrderHistory";

const OrderPage = () => {
  const isOrderStatus = useMatch("/user/orders/status");

  return (
    <div className="flex-1">
      {!isOrderStatus && <OrderHistory />}
      <Outlet />
    </div>
  );
};

export default OrderPage;
