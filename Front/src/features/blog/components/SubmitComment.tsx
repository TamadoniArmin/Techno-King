const SubmitComment = () => {
  return (
    <div className="flex flex-col">
      <h4 className="font-semibold text-[1rem] md:text-[1.1rem]">Leave a Comment</h4>
      <textarea
        placeholder="Share your thoughts about this product here"
        className="border border-gray-300 w-full h-[10rem] md:h-[15rem] pt-[1.2rem] pl-[1rem] mt-[0.8rem] rounded-[0.5rem] text-[0.9rem]"
      ></textarea>
      <button className="bg-primary-300 self-end py-[0.5rem] px-8 md:px-12 rounded-[0.5rem] text-[#ffffffe8] mt-[0.5rem]">
        Submit
      </button>
    </div>
  );
};

export default SubmitComment;