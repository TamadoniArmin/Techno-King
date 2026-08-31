const EditInput = ({ isName, text = "" }) => {
  if (isName)
    return (
      <div className="mt-[2rem] flex flex-col gap-2">
        <div className="border border-gray-200 rounded-[0.5rem]">
          <input
            type="text"
            placeholder="First name"
            className="w-full h-[3rem] pl-3"
          />
        </div>
        <div className="border border-gray-200 rounded-[0.5rem]">
          <input
            type="text"
            placeholder="Last name"
            className="w-full h-[3rem] pl-3"
          />
        </div>
      </div>
    );

  return (
    <div className="border border-gray-200 rounded-[0.5rem] mt-[2.5rem]">
      <input type="text" placeholder={text} className="w-full h-[3rem] pl-3" />
    </div>
  );
};

export default EditInput;
