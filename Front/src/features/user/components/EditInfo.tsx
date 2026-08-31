import CloseIcon from "../../../shared/components/CloseIcon";

const EditInfo = ({ title,closeHandler }) => {
  return (
    <div className="flex justify-between items-center">
      <h4 className="font-semibold text-[1.1rem]">{title}</h4>
      <div onClick={closeHandler}>
        <CloseIcon color="#444444" />
      </div>
    </div>
  );
};

export default EditInfo;
