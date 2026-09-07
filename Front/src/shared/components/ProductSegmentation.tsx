import arrowRight from "/icons/arrow-circle-right.svg";
import starIcon from "/icons/star.svg";
import type { Product } from "../../types/product.types";
import { BASE_URL } from "../api/base";

type ProductSegmentaionProps = { title: string; data: Product[] };

const ProductSegmentation = ({ title, data }: ProductSegmentaionProps) => {
  return (
    <section className="my-5 px-4 sm:px-8 md:px-[4rem] lg:px-[6.8rem]">
      <div className="border-b-[2px] border-gray-200 pb-[0.7rem]">
        <div className="flex flex-wrap items-center justify-between gap-2">
          <h3 className="text-lg sm:text-xl md:text-[1.7rem]">{title}</h3>
          <div className="flex items-center px-[0.5rem] py-[0.25rem]">
            <span>View all</span>
            <img src={arrowRight} alt="arrow icon" className="invert" />
          </div>
        </div>
      </div>

      <div className="mt-6 grid grid-cols-2 gap-4 sm:mt-8 sm:gap-6 lg:grid-cols-4">
        {data.map((item) => (
          <div
            key={item.id}
            className="flex flex-col rounded-lg p-3 shadow-[-2px_2px_15px_-1px_#7171712b] sm:p-4"
          >
            <div className="flex h-40 items-center justify-center sm:h-44">
              <img
                src={`${BASE_URL}/${item.imageUrl1}`}
                alt={item.name}
                className="h-full w-full max-w-[11.25rem] object-contain"
              />
            </div>

            <div className="h-px bg-[linear-gradient(to_right,rgba(68,68,68,0.1)_0%,rgba(16,16,16,0.7)_54%,rgba(68,68,68,0.1)_99%)]"></div>
            <span className="mt-4 text-xs sm:text-[0.8rem]">{item.name}</span>
            <div className="mt-4 flex items-center justify-between sm:mt-8">
              <span>${item.price}</span>
              <div className="flex items-center gap-1">
                <img src={starIcon} alt="star-icon" className="w-3" />
                <span>{item.averageRating}</span>
              </div>
            </div>
          </div>
        ))}
      </div>
    </section>
  );
};

export default ProductSegmentation;
