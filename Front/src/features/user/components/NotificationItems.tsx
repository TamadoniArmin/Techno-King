import { Switch } from "@headlessui/react";
import { useState } from "react";

const NotificationItems = ({ title, icon, description }) => {
  const [enabled, setEnabled] = useState(false);

  return (
    <div>
      <div className="flex items-center justify-between">
        <div className="flex items-center gap-2">
          <img src={icon} alt="icon" />
          <span>{title}</span>
        </div>

        <Switch
          checked={enabled}
          onChange={setEnabled}
          className="group inline-flex h-6 w-11 items-center rounded-full bg-gray-200 transition data-checked:bg-blue-600"
        >
          <span className="size-4 translate-x-1 rounded-full bg-white transition group-data-checked:translate-x-6" />
        </Switch>
      </div>
      <p className="text-gray-400">{description}</p>
    </div>
  );
};

export default NotificationItems;
