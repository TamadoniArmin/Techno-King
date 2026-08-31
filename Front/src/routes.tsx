import { createBrowserRouter } from "react-router-dom";
import AppLayout from "./shared/layout/AppLayout";
import HomePage from "./features/landing/pages/HomePage";
import BlogsPage from "./features/blog/pages/BlogsPage";
import Faq from "./features/info/pages/Faq";
import ContactUs from "./features/info/pages/ContactUs";
import AboutUs from "./features/info/pages/AboutUs";
import BlogDetailPage from "./features/blog/pages/BlogDetailPage";
import UserLayout from "./shared/layout/UserLayout";
import UserData from "./features/user/pages/UserData";
import Payment from "./features/payment/pages/Payment";
import Instalment from "./features/payment/pages/Instalment";
import OrderPage from "./features/orders/pages/OrderPage";
import CurrentOrder from "./features/orders/components/CurrentOrder";
import DeliveredOrder from "./features/orders/components/DeliveredOrder";
import OrderStatus from "./features/orders/components/OrderStatus";
import WishListPage from "./features/engagement/pages/WishListPage";
import DiscountPage from "./features/engagement/pages/DiscountPage";
import SecurityPage from "./features/user/pages/SecurityPage";
import NotificationPage from "./features/user/pages/NotificationPage";
import ProductsPage from "./features/products/pages/ProductsPage";

const router = createBrowserRouter([
  {
    path: "/",
    element: <AppLayout />,
    children: [
      { index: true, element: <HomePage /> },
      { path: "/blogs", element: <BlogsPage /> },
      { path: "/blogs/:id/:slug", element: <BlogDetailPage /> },
      { path: "/faq", element: <Faq /> },
      { path: "/contact", element: <ContactUs /> },
      { path: "/about", element: <AboutUs /> },
      { path: "/products", element: <ProductsPage /> },
      { path: "/search", element: <ProductsPage /> },
    ],
  },

  {
    path: "/user",
    element: <UserLayout />,
    children: [
      { index: true, element: <UserData /> },
      { path: "personal", element: <UserData /> },
      { path: "payment", element: <Payment /> },
      {
        path: "payment/instalment",
        element: <Instalment />,
        handle: { fullWidth: true },
      },
      {
        path: "orders",
        element: <OrderPage />,
        children: [
          { path: "current", element: <CurrentOrder /> },
          { path: "delivered", element: <DeliveredOrder /> },
          { path: "status", element: <OrderStatus /> },
        ],
      },
      { path: "favorites", element: <WishListPage /> },
      { path: "discount", element: <DiscountPage /> },
      { path: "security", element: <SecurityPage /> },
      { path: "notification", element: <NotificationPage /> },
    ],
  },
]);

export default router;
