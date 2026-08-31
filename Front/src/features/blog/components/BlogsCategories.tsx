const BlogsCategories = () => {
  return (
    <div className="flex flex-col gap-[1rem] md:gap-[1.5rem]">
      <h4 className="font-semibold text-[1.1rem] md:text-[1.2rem]">Categories</h4>
      <ul className="flex flex-col gap-[0.8rem] md:gap-[1rem] text-[0.9rem] md:text-base">
        <li>Technology Trends and News</li>
        <li>Gaming Insights</li>
        <li>Security and Privacy</li>
        <li>Tech Lifestyle and Productivity</li>
        <li>Product Spotlight</li>
        <li>How-to Guides and Tutorials</li>
        <li>Buying Guides and Tips</li>
      </ul>
    </div>
  );
};

export default BlogsCategories;