import CurrentPage from "../../../shared/components/CurrentPage";
import aboutUs from "/about-us.png";

const AboutUs = () => {
  return (
    <div>
      <div className="px-[1.5rem] md:px-[6.8rem]">
        <CurrentPage curPage="About us" />
        <img
          src={aboutUs}
          alt="about us"
          className="my-[1.5rem] md:my-[2.5rem] mx-auto w-full h-auto md:w-auto rounded-[0.5rem] md:rounded-none"
        />
        <div className="pb-[2rem] md:pb-[3rem] text-[0.85rem] md:text-[0.9rem]">
          <p>
            Tech Heim is an innovative online store that offers a diverse
            selection of digital gadgets, available for purchase in both cash
            and installment options. Embodying the motto "Join the digital
            revolution today" the website not only provides a seamless
            shopping experience but also features a captivating blog section
            filled with insightful reviews, articles, and videos about
            cutting-edge technology and digital gadgets. Users can actively
            engage with the content through comments and a question-answer
            section, fostering a dynamic community of tech enthusiasts.
          </p>

          <h4 className="font-semibold my-[1rem]">Tech Heim Meaning</h4>

          <p>
            The name "Tech Heim" cleverly combines two languages (English &
            German), signifying a home of technology that provides all the
            essential tech products and services, making it a one-stop
            destination for tech-savvy individuals seeking the latest and
            most exciting gadgets.
          </p>

          <h4 className="font-semibold my-[1rem]">
            Some of Tech Heim's impressive features :
          </h4>

          <p>
            Diverse digital gadgets for purchase in cash or installments A
            blog with reviews and articles about the latest technology and
            gadgets User comments and Q&A section for community interaction
            Represents a tech-savvy "home" with all necessary technology
            Easy-to-use interface for a great user experience Consistent and
            visually appealing design A hub for tech enthusiasts to connect
            and share insights Helps users make informed purchase decisions
          </p>
        </div>
      </div>
    </div>
  );
};

export default AboutUs;