import videoCard from "/video-card.png";

const VideoBlogs = () => {
  return (
    <div className="flex flex-col gap-[1.5rem] mb-12 w-full md:w-auto">
      <h3 className="font-semibold">Videos</h3>
      <img src={videoCard} alt="Video" className="w-full" />
      <img src={videoCard} alt="Video" className="w-full" />
      <img src={videoCard} alt="Video" className="w-full" />
      <img src={videoCard} alt="Video" className="w-full" />
      <img src={videoCard} alt="Video" className="w-full" />
      <img src={videoCard} alt="Video" className="w-full" />
    </div>
  );
};

export default VideoBlogs;