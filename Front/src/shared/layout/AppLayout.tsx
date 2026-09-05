import { Outlet } from "react-router-dom";
import Header from "../components/layout/Header";
import Footer from "../components/layout/Footer";
import { useState } from "react";
import ProductSearch from "../../features/search/components/ProductSearch";

function AppLayout() {
  const [isSearchOpen, setIsSearchOpen] = useState(false);

  return (
    <div className="flex flex-col min-h-screen">
      <Header
        onSearchClick={() => setIsSearchOpen(true)}
        isSearchOpen={isSearchOpen}
      />
      {isSearchOpen && <ProductSearch onClose={() => setIsSearchOpen(false)} />}
      <main className="grow">
        <Outlet />
      </main>
      <Footer />
    </div>
  );
}

export default AppLayout;
