import direct from "/icons/direct2.svg";
import truck from "/icons/truck2.svg";
import sms from "/icons/sms3.svg";
import story from "/icons/story.svg";
import NotificationItems from "../components/NotificationItems";

const NotificationPage = () => {
  return (
    <div className="flex-1 flex flex-col gap-[2.5rem] mt-[1.5rem]">
      <div className="flex flex-col gap-[0.5rem]">
        <h3 className="font-semibold">Notification</h3>
        <span className="text-gray-400">Manage your notification settings</span>
      </div>

      <div className="grid grid-cols-2 gap-x-[1.5rem] gap-y-[2rem]">
        <NotificationItems
          title="Email"
          icon={direct}
          description="We write emails to let you know what's important, like: new order, confirmations"
        />
        <NotificationItems
          title="Order Delivered"
          icon={truck}
          description="You will be noticed once the order is delivered"
        />
        <NotificationItems
          title="Push  to your Device"
          icon={sms}
          description="Receive notifications about your order status, promotions and other updates"
        />
        <NotificationItems
          title="Product's availibilty"
          icon={story}
          description="You will be noticed when product gets available"
        />
      </div>
    </div>
  );
};

export default NotificationPage;
