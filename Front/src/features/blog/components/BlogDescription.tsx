import test from "/blog-test1.png";
import editIcon from "/icons/edit.svg";

const BlogDescription = () => {
  return (
    <div className="border-b-2 border-gray-200 pb-5 text-[0.9rem] md:text-base">
      <div className="flex flex-col">
        <div className="flex flex-col gap-[0.6rem]">
          <h2 className="font-semibold text-[1.1rem] md:text-[1.25rem]">
            5 Things You Probably Didn't Know About Headphones
          </h2>
          <span className="text-gray-400 text-[0.8rem]">
            By Geaorge larens on March , 28 , 2023
          </span>
          <img src={test} alt="Blog pucture" className="w-full h-auto rounded-[0.5rem]" />
        </div>
        <div>
          <p className="mt-2">
            Headphones have become an integral part of our daily lives, allowing
            us to enjoy music, podcasts, and calls with convenience and privacy.
            While most of us are familiar with their basic functions, there are
            several intriguing facts about headphones that might surprise you.
            In this article, we'll delve into eight things you probably didn't
            know about headphones, shedding light on their history, technology,
            and unique features.
          </p>

          <p className="mt-5">
            <h4 className="text-[0.9rem] font-semibold">
              1-Stereo Sound Perception
            </h4>
            Ever wondered how headphones manage to create a three-dimensional
            sound experience? This phenomenon is called binaural perception,
            which utilizes the slight time differences it takes for sound to
            reach each ear, thus tricking the brain into perceiving depth and
            direction in audio.
          </p>

          <p className="mt-5">
            <h4 className="text-[0.9rem] font-semibold">
              2-Noise-Canceling Magic
            </h4>
            Noise-canceling headphones use a sophisticated technology that
            analyzes external sounds and emits an "anti-noise" signal to
            counteract them. This process results in the suppression of unwanted
            background noise, offering a peaceful listening experience even in
            bustling environments.
          </p>
          <p className="mt-5">
            <h4 className="text-[0.9rem] font-semibold">
              3-Bone Conduction Technology
            </h4>
            Some headphones, particularly designed for sports and outdoor
            activities, employ bone conduction technology. Instead of covering
            or inserting into the ears, these headphones sit on your cheekbones
            and transmit sound vibrations through your bones directly to the
            inner ear, leaving your ears open to hear ambient sounds.
          </p>

          <p className="mt-5">
            <h4 className="text-[0.9rem] font-semibold">
              4-Virtual Surround Sound
            </h4>
            High-end headphones offer virtual surround sound, which simulates a
            multi-speaker setup for a cinema-like experience. This is achieved
            by using advanced algorithms to manipulate audio signals, creating
            the illusion that sound is coming from various directions.
          </p>

          <p className="mt-5">
            <h4 className="text-[0.9rem] font-semibold">
              5-Wired vs. Wireless
            </h4>
            While wireless headphones are incredibly convenient, wired
            headphones can still offer superior audio quality due to the lack of
            data compression and transmission loss associated with wireless
            technology.
          </p>
        </div>

        <div className="flex self-end gap-8 mt-[1.5rem]">
          <div className="flex items-center gap-2">
            <img src={editIcon} alt="Edit icon" className="w-[18px]" />
            <span className="text-[0.8rem]">3 Comment</span>
          </div>
          <div className="flex items-center gap-2">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 32 32"
              className="w-[18px]"
            >
              <path
                d="M27 11h-8.52L19 9.8A6.42 6.42 0 0 0 13 1a1 1 0 0 0-.93.63L8.32 11H5a3 3 0 0 0-3 3v14a3 3 0 0 0 3 3h18.17a3 3 0 0 0 2.12-.88l3.83-3.83a3 3 0 0 0 .88-2.12V14a3 3 0 0 0-3-3zM4 28V14a1 1 0 0 1 1-1h3v16H5a1 1 0 0 1-1-1zm24-3.83a1 1 0 0 1-.29.71l-3.83 3.83a1.05 1.05 0 0 1-.71.29H10V12.19l3.66-9.14a4.31 4.31 0 0 1 3 1.89 4.38 4.38 0 0 1 .44 4.12l-1 2.57A1 1 0 0 0 17 13h10a1 1 0 0 1 1 1z"
                data-name="thumb up android app aplication phone"
              />
            </svg>
            <span className="text-[0.8rem]">18 Likes</span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BlogDescription;