import CurrentPage from "../../../shared/components/CurrentPage";
import Communication from "../components/Communication";
import MessageUs from "../components/MessageUs";

const ContactUs = () => {
  return (
    <div className="flex flex-col pb-[3.5rem] px-[1.5rem] md:px-[6.8rem]">
      <CurrentPage curPage="Contact us" />
      <Communication />
      <MessageUs />
    </div>
  );
};

export default ContactUs;