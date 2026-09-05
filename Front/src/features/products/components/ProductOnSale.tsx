import { Swiper, SwiperSlide } from "swiper/react";
import "swiper/css";
import randomShape from "/random-shape.svg";
import arrowRight from "/icons/arrow-circle-right.svg";
import leftSliderIcon from "/icons/left-slider-arrow.svg";
import rightSliderIcon from "/icons/right-slider-arrow.svg";
import { Navigation } from "swiper/modules";
import { useGetOnSaleProducts } from "../hooks/useGetOnSaleProducts";
import { BASE_URL } from "../../../shared/api/base";

const ProductOnSale = () => {
  const { data: productsOnSale, isLoading } = useGetOnSaleProducts();

  if (isLoading) return <span>LOADING ... </span>;

  return (
    <section className="box-border w-full overflow-hidden px-4 py-6 sm:px-6 md:px-8 xl:px-[6.8rem]">
      <div className="bg-primary-500 relative flex w-full flex-col gap-4 rounded-[0.5rem] p-4 sm:gap-6 sm:p-6 md:flex-row md:gap-[1rem] md:p-0">
        <img
          src={randomShape}
          alt="shape image"
          className="pointer-events-none absolute top-0 left-[-1.5rem] z-10 w-[110px] opacity-40 sm:left-[-2rem] sm:w-[150px] sm:opacity-50 md:w-[340px] md:opacity-100"
        />

        
        <div className="z-20 flex shrink-0 flex-row items-center justify-between md:w-[14.5rem] md:flex-col md:justify-start">
          <div className="flex flex-col items-start text-white md:mt-[3rem] md:items-center">
            <h3 className="text-lg font-bold sm:text-xl md:text-[1.5rem]">
              Product On Sale
            </h3>
            <span className="text-xs font-light sm:text-sm md:text-[1.25rem]">
              Shop Now!
            </span>
          </div>

          <div className="flex cursor-pointer items-center gap-2 text-white md:mt-auto md:mb-[2.75rem]">
            <span className="text-xs sm:text-sm md:text-base">View all</span>
            <img
              src={arrowRight}
              alt="arrow icon"
              className="w-4 sm:w-5 md:w-auto"
            />
          </div>
        </div>

        <div className="relative z-20 w-full min-w-0 flex-1 overflow-hidden pb-12 md:pb-0">
          <Swiper
            className="h-full w-full"
            modules={[Navigation]}
            navigation={{
              nextEl: ".my-button-next",
              prevEl: ".my-button-prev",
            }}
            slidesPerView="auto"
            spaceBetween={12}
            breakpoints={{
              480: { spaceBetween: 16 },
              768: { spaceBetween: 20 },
              1024: { spaceBetween: 24 },
              1280: { spaceBetween: 24 },
            }}
          >
            {productsOnSale.map((item) => (
              <SwiperSlide
                key={item.id}
                className="xs:!w-[9.5rem] flex !w-[8.5rem] justify-center sm:!w-[10rem] md:!w-[11.5rem]"
              >
                <div className="my-2 w-full md:my-[2.75rem]">
                  <div className="relative flex flex-col rounded-[0.25rem] bg-white p-[0.5rem] shadow-sm">
                    <span className="absolute top-2 left-0 z-10 rounded-r-[0.625rem] bg-[#FDDBC9] px-[0.37rem] py-[0.25rem] text-xs text-[#F45E0C] sm:text-sm">
                      -{item.discountPercentage}%
                    </span>

                    <img
                      src={`${BASE_URL}/${item.ImageUrl1}`}
                      alt={item.name}
                      className="mt-6 mb-2 h-20 w-full object-contain sm:h-24 md:h-28"
                    />

                    <span className="mb-[0.5rem] text-sm font-medium text-gray-800 md:text-base">
                      {item.name}
                    </span>

                    <div className="flex justify-between text-sm font-semibold md:text-base">
                      <span>${item.originalPrice}</span>
                      <span>${item.finalPrice}</span>
                    </div>
                  </div>
                </div>
              </SwiperSlide>
            ))}
          </Swiper>

          <div className="absolute right-0 bottom-0 z-30 flex gap-2 md:right-[0.5rem] md:bottom-[0.5rem]">
            <button
              aria-label="Previous products"
              className="my-button-prev transition-opacity hover:opacity-80"
            >
              <img
                src={leftSliderIcon}
                alt=""
                className="w-6 sm:w-[1.5rem] md:w-[1.8rem]"
              />
            </button>

            <button
              aria-label="Next products"
              className="my-button-next transition-opacity hover:opacity-80"
            >
              <img
                src={rightSliderIcon}
                alt=""
                className="w-6 sm:w-[1.5rem] md:w-[1.8rem]"
              />
            </button>
          </div>
        </div>
      </div>
    </section>
  );
};

export default ProductOnSale;
