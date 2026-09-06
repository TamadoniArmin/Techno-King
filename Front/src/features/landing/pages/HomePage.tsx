import ProductSegmentation from "../../../shared/components/ProductSegmentation";
import ProductOnSale from "../../products/components/ProductOnSale";
import { useGetTopSellingProducts } from "../../products/hooks/useGetTopSellingProducts";
import ProductSearch from "../../search/components/ProductSearch";
import Brands from "../components/Brands";
import CategoryList from "../components/CategoryList";
import FeaturedProducts from "../components/FeaturedProducts";
import HeroSection from "../components/HeroSection";
import OurBlogs from "../components/OurBlogs";
import PromoBanner from "../components/PromoBanner";
import Services from "../components/Services";

const HomePage = () => {
  const { data } = useGetTopSellingProducts(4);

  return (
    <div>
      <HeroSection />

      {/* <ProductSearch /> */}
      <CategoryList />
      {/* <ProductOnSale /> */}
      <ProductSegmentation data={data} title="New Products" />
      <FeaturedProducts />
      <ProductSegmentation data={data} title="Best Sellers" />
      <Brands />
      <PromoBanner />
      <OurBlogs />
      <Services />
    </div>
  );
};

export default HomePage;
