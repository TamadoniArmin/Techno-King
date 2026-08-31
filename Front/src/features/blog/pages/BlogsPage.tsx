import CurrentPage from "../../../shared/components/CurrentPage";
import RecentPosts from "../components/RecentPosts";
import TopBlogs from "../components/TopBlogs";
import VideoBlogs from "../components/VideoBlogs";

const BlogsPage = () => {
  return (
    <div className="px-[1.5rem] md:px-[6.8rem]">
      <CurrentPage curPage="Blog" />
      <div className="flex flex-col md:flex-row gap-[1.5rem] mt-[2.5rem]">
        <div className="w-full md:w-[75%]">
          <TopBlogs />
          <RecentPosts />
        </div>
        <VideoBlogs />
      </div>
    </div>
  );
};

export default BlogsPage;