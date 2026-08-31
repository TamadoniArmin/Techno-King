import mobileIcon from "/icons/mobile.svg";
import monitorIcon from "/icons/monitor.svg";
import watchIcon from "/icons/watch.svg";
import headphoneIcon from "/icons/headphone.svg";
import cameraIcon from "/icons/camera.svg";
import gameIcon from "/icons/game.svg";
import networkIcon from "/icons/data.svg";
import accessoriesIcon from "/icons/devices.svg";

import test from "/test.png";

const ProductsMegaMenu = () => {
  return (
    <div className="px-[6.8rem]">
      <div className="bg-white flex items-center rounded-[0.5rem]">
        <ul className="flex flex-col gap-[1rem] px-[1rem] py-[1.5rem] border-r border-gray-300">
          <li className="flex items-center gap-[0.8rem]">
            <img src={mobileIcon} alt="mobileIcon" />
            <span>Mobile Phones</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={monitorIcon} alt="monitorIcon" />
            <span>Laptops & Computers</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={mobileIcon} alt="mobileIcon" />
            <span>Tablets & E-reader</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={watchIcon} alt="watchIcon" />
            <span>Wearables</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={headphoneIcon} alt="headphoneIcon" />
            <span>Audio</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={cameraIcon} alt="cameraIcon" />
            <span>Cameras</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={gameIcon} alt="gameIcon" />
            <span>Gaming</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={networkIcon} alt="networkIcon" />
            <span> Networking</span>
          </li>
          <li className="flex items-center gap-[0.8rem]">
            <img src={accessoriesIcon} alt="accessoriesIcon" />
            <span>Accessories</span>
          </li>
        </ul>

        <div className="flex flex-1 justify-between px-[0.5rem]">
          <div className="text-primary-300">View all</div>

          <div className="flex gap-[1rem]">
            <div className="flex flex-col justify-center items-center  rounded shadow-[-2px_2px_20px_#7171711f]">
              <img src={test} alt="test" />
              <span className="mt-1">Watch & Earpods</span>
            </div>
            <div className="flex flex-col justify-center items-center  rounded shadow-[-2px_2px_20px_#7171711f]">
              <img src={test} alt="test" />
              <span className="mt-1">Watch & Earpods</span>
            </div>
            <div className="flex flex-col justify-center items-center  rounded shadow-[-2px_2px_20px_#7171711f]">
              <img src={test} alt="test" />
              <span className="mt-1">Watch & Earpods</span>
            </div>
            <div className="flex flex-col justify-center items-center  rounded shadow-[-2px_2px_20px_#7171711f]">
              <img src={test} alt="test" />
              <span className="mt-1">Watch & Earpods</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ProductsMegaMenu;
