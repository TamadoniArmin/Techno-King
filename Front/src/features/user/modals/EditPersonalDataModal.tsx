import EditInfo from "../components/EditInfo";
import EditInput from "../components/EditInput";

interface EditPersonalProps {
  title: string;
  text?: string;
  isName?: boolean;
  closeHandler: () => void;
}

const EditPersonalDataModal = ({
  title,
  text = "",
  isName = false,
  closeHandler,
}: EditPersonalProps) => {
  return (
    <div className="flex justify-center items-center fixed inset-0 bg-[#1d1c1c8d]">
      <div className="bg-white flex flex-col w-full max-w-[24rem] h-[18rem] rounded-[0.5rem] p-[1.5rem]">
        <EditInfo title={title} closeHandler={closeHandler} />
        {isName ? (
          <EditInput isName={isName} />
        ) : (
          <EditInput isName={isName} text={text} />
        )}

        <button className="bg-primary-300 text-white self-end w-[50%] h-[3rem] rounded-[0.5rem] mt-[2rem]">
          save
        </button>
      </div>
    </div>
  );
};

export default EditPersonalDataModal;
