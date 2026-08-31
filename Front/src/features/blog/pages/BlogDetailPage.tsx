import CurrentPage from "../../../shared/components/CurrentPage";
import BlogDescription from "../components/BlogDescription";
import BlogsCategories from "../components/BlogsCategories";
import Comments from "../components/Comments";
import RecentPostSidebar from "../components/RecentPostSidebar";
import SubmitComment from "../components/SubmitComment";
import Tags from "../components/Tags";

const BlogDetailPage = () => {
  return (
    <div className="pb-10">
      <div className="mb-[1.5rem] md:mb-[2rem] px-[1.5rem] md:px-[6.8rem] pt-[1.5rem] md:pt-0">
        <CurrentPage pageNumber={2} prevPage="Blog" curPage="Headphone" />
      </div>
      <div className="px-[1.5rem] md:px-[6.8rem] flex flex-col md:flex-row gap-[2rem] md:gap-[1.5rem]">
        <div className="w-full md:w-[75%]">
          <BlogDescription />
          <Comments />
          <SubmitComment />
        </div>

        <div className="flex flex-col gap-[2rem] md:gap-[3rem] md:mt-15 w-full md:w-auto">
          <BlogsCategories />
          <RecentPostSidebar />
          <Tags />
        </div>
      </div>
    </div>
  );
};

export default BlogDetailPage;