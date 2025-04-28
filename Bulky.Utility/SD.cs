using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public  static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Company = "Company";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";

		public const string StatusPending = "Pending";
		public const string StatusApproved = "Approved";
		public const string StatusInProcess = "Process";
		public const string StatusShipping = "Shipping";
		public const string StatusCancelled = "Cancelled";
		public const string StatusRefunded = "Refunded";


		public const string PamentStatusPending = "Pending";
		public const string PamentStatusApproved = "Approved";
		public const string PamentStatusDelayedPayment= "ApprovedForDelayedPayment";
		public const string PamentStatusRejected = "Rejected";

	}
}
