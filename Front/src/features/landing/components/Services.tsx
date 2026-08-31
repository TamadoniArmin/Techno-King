import tech from "/icons/tech.svg";
import guarantee from "/icons/guarantee.svg";
import shipping from "/icons/shipping.svg";
import support from "/icons/support.svg";

const Services = () => {
  return (
    <section className="flex flex-col gap-4 px-4 py-4 md:flex-row md:items-center md:justify-between md:gap-0 md:px-12 md:py-6 lg:px-[6.8rem] lg:py-[1.5rem]">
      <div className="flex items-center gap-2 md:gap-[0.5rem]">
        <img src={tech} alt="tech" className="h-6 w-6 md:h-10 md:w-10" />
        <span className="text-sm font-semibold md:text-[0.9rem] md:font-normal">Latest and Greatest Tech</span>
      </div>
      <div className="flex items-center gap-2 md:gap-[0.5rem]">
        <img src={guarantee} alt="guarantee" className="h-6 w-6 md:h-10 md:w-10" />
        <span className="text-sm font-semibold md:text-[0.9rem] md:font-normal">Guarantee</span>
      </div>
      <div className="flex items-center gap-2 md:gap-[0.5rem]">
        <img src={shipping} alt="shipping" className="h-6 w-6 md:h-10 md:w-10" />
        <span className="text-sm font-semibold md:text-[0.9rem] md:font-normal">Free Shipping over 1000$</span>
      </div>
      <div className="flex items-center gap-2 md:gap-[0.5rem]">
        <img src={support} alt="support" className="h-6 w-6 md:h-10 md:w-10" />
        <span className="text-sm font-semibold md:text-[0.9rem] md:font-normal">24/7 Support</span>
      </div>
    </section>
  );
};

export default Services;