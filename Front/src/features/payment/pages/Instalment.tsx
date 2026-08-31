import { NavLink } from "react-router-dom";
import test from "/table-test.png";

const Instalment = () => {
  return (
    <div className="flex flex-col gap-[2rem] px-4 lg:px-[6.8rem] my-[2rem]">
      <div className="text-sm text-gray-400">
        Home <span className="mx-1">›</span>
        <NavLink to="/user" className="text-primary">
          Account
        </NavLink>
        <span className="mx-1">›</span>
        <NavLink to="/user/payment" className="text-primary">
          Payment &amp; Instalments
        </NavLink>
        <span className="mx-1">›</span>
        <span className="text-primary underline">Instalment</span>
      </div>

      <div className="border border-gray-75 rounded-[0.5rem] overflow-x-auto">
        <table className="w-full min-w-[700px] whitespace-nowrap [&_td]:px-4">
          <thead className="bg-gray-25 text-gray-700">
            <tr className="text-center">
              <td className="py-[1rem]">Description</td>
              <td>Due Amount</td>
              <td>Due Date</td>
              <td>Actual Amount</td>
              <td>Payment Date</td>
              <td>Status</td>
              <td>Total</td>
            </tr>
          </thead>

          <tbody>
            <tr className="text-center">
              <td>
                <div className="flex items-center justify-center py-[0.8rem]">
                  <input
                    type="checkbox"
                    disabled
                    checked={false}
                    className="w-[1rem] h-[1rem] mr-3 accent-primary-300 shrink-0"
                  />
                  <div className="flex items-center mr-[1rem]">
                    <img
                      src={test}
                      alt="test"
                      className="w-8 h-8 lg:w-10 lg:h-10 rounded shrink-0 object-cover"
                    />
                    <span className="text-[0.6rem] font-semibold">+2</span>
                  </div>
                  <span>#8967856</span>
                </div>
              </td>
              <td className="text-secondary-400">$543.02</td>
              <td>2023/08/20</td>
              <td>$543.02</td>
              <td>2023/08/15</td>
              <td>
                <span className="border border-success text-success bg-success-light px-[4px] rounded-[0.3rem]">
                  Paid
                </span>
              </td>
              <td className="text-gray-700 font-semibold">$1385.52</td>
            </tr>

            <tr className="text-center">
              <td>
                <div className="flex items-center justify-center py-[0.8rem]">
                  <input
                    type="checkbox"
                    disabled
                    checked={true}
                    className="w-[1rem] h-[1rem] mr-3 accent-primary-300 shrink-0"
                  />
                  <div className="flex items-center mr-[1rem]">
                    <img
                      src={test}
                      alt="test"
                      className="w-8 h-8 lg:w-10 lg:h-10 rounded shrink-0 object-cover"
                    />
                    <span className="text-[0.6rem] font-semibold">+2</span>
                  </div>
                  <span>#8967856</span>
                </div>
              </td>
              <td className="text-secondary-400">$433.00</td>
              <td>2023/09/20</td>
              <td>-</td>
              <td>-</td>
              <td>
                <span className="border border-primary-300 text-primary-300 bg-primary-25 px-[4px] rounded-[0.3rem]">
                  On schedule
                </span>
              </td>
              <td className="text-gray-700 font-semibold">$842.50</td>
            </tr>

            <tr className="text-center">
              <td>
                <div className="flex items-center justify-center py-[0.8rem]">
                  <input
                    type="checkbox"
                    disabled
                    checked={true}
                    className="w-[1rem] h-[1rem] mr-3 accent-primary-300 shrink-0"
                  />
                  <div className="flex items-center mr-[1rem]">
                    <img
                      src={test}
                      alt="test"
                      className="w-8 h-8 lg:w-10 lg:h-10 rounded shrink-0 object-cover"
                    />
                    <span className="text-[0.6rem] font-semibold">+2</span>
                  </div>
                  <span>#8967856</span>
                </div>
              </td>
              <td className="text-secondary-400">$433.00</td>
              <td>2023/10/20</td>
              <td>-</td>
              <td>-</td>
              <td>
                <span className="border border-primary-300 text-primary-300 bg-primary-25 px-[4px] rounded-[0.3rem]">
                  On schedule
                </span>
              </td>
              <td className="text-gray-700 font-semibold">$409.50</td>
            </tr>
          </tbody>
        </table>
      </div>

      <div className="flex flex-col sm:flex-row gap-3">
        <div className="flex items-center justify-between bg-gray-25 border border-gray-50 px-[1.5rem] py-[0.8rem] sm:py-0 w-full sm:w-[30%] rounded-[0.5rem]">
          <span className="font-semibold">Subtotal</span>
          <span>842.50</span>
        </div>
        <button className="bg-primary-300 text-white px-15 py-[0.6rem] rounded-[0.5rem] font-thin">
          Pay
        </button>
      </div>
    </div>
  );
};

export default Instalment;