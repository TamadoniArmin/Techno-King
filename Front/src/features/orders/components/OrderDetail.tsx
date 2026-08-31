const OrderDetail = () => {
  const rows = [
    { label: "order code", value: "#1050486" },
    { label: "Placed on", value: "2023/04/15" },
    { label: "Sent to", value: "31,Albuquerque,New York" },
    { label: "Payment type", value: "Net Banking" },
    { label: "Transaction id", value: "2345678910" },
    { label: "Amount Paid", value: "$543.02" },
  ];

  return (
    <div className="mt-[1.5rem]">
      {rows.map((row) => (
        <div
          key={row.label}
          className="flex odd:bg-gray-25 min-h-[2.5rem] items-center pl-2 pr-2 py-2 gap-2"
        >
          <span className="flex-1 font-semibold text-[0.85rem] md:text-base">
            {row.label}
          </span>
          <span className="flex-1 text-gray-600 text-[0.85rem] md:text-base">
            {row.value}
          </span>
        </div>
      ))}
    </div>
  );
};

export default OrderDetail;