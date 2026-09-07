import accessories from "/category/accessories.png";
import laptop from "/category/laptop.png";
import camera from "/category/camera.png";
import smartPhone from "/category/smart-phone.png";
import gaming from "/category/gaming.png";
import smartWatch from "/category/smart-watch.png";

const CategoryList = () => {
  return (
    <ul className="my-12 grid grid-cols-2 gap-6 px-4 sm:px-8 md:px-[4rem] lg:px-[6.8rem] sm:grid-cols-3 lg:grid-cols-6">
      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img
          className="h-37 w-37 object-contain"
          src={accessories}
          alt="Accessories"
        />
        <span className="mt-4 text-center font-medium">
          Accessories
        </span>
      </li>

      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img className="h-37 w-37 object-contain" src={camera} alt="Camera" />
        <span className="mt-4 text-center text-sm font-medium">Camera</span>
      </li>

      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img className="h-37 w-37 object-contain" src={laptop} alt="Laptop" />
        <span className="mt-4 text-center text-sm font-medium">Laptop</span>
      </li>

      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img
          className="h-37 w-37 object-contain"
          src={smartPhone}
          alt="Smart Phone"
        />
        <span className="mt-4 text-center text-sm font-medium">
          Smart Phone
        </span>
      </li>

      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img className="h-37 w-37 object-contain" src={gaming} alt="Gaming" />
        <span className="mt-4 text-center text-sm font-medium">Gaming</span>
      </li>

      <li className="flex min-h-[170px] flex-col items-center justify-center rounded-xl bg-white p-4 shadow-md transition duration-300 hover:-translate-y-1 hover:shadow-lg">
        <img
          className="h-37 w-37 object-contain"
          src={smartWatch}
          alt="Smart Watch"
        />
        <span className="mt-4 text-center text-sm font-medium">
          Smart Watch
        </span>
      </li>
    </ul>
  );
};

export default CategoryList;