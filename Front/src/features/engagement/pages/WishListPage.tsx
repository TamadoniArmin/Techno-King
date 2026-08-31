import WishItem from "../components/WishItem";

const WishListPage = () => {
  return (
    <div className="flex-1 mt-[1.5rem]">
      <div>
        <h3 className="font-semibold">Wish list</h3>
        <span className="text-gray-400">See your favorites list here</span>
      </div>

      <div className="grid grid-cols-3 gap-[1.5rem] mt-[2.5rem]">
        <WishItem />
        <WishItem />
        <WishItem />
      </div>
    </div>
  );
};

export default WishListPage;
