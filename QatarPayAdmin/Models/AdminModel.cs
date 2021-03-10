using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QatarPayAdmin.Models
{
    public class AdminModel
    {

        public class VerifyPassportRequest
        {
			[Required]
            public int UserID { get; set; }
        }
		public class UserDetailsModel : ActionResponse
		{
			public string Email
			{
				get;
				set;
			}

			public string FirstName
			{
				get;
				set;
			}

			public string LastName
			{
				get;
				set;
			}

			public string PhoneNumber
			{
				get;
				set;
			}

			public string IDCardNumber
			{
				get;
				set;
			}

			public string UserType
			{
				get;
				set;
			}

			public string IsActive
			{
				get;
				set;
			}

			public string Userseq
			{
				get;
				set;
			}
            public bool IsQidVerified { get; set; }
            public bool? IsPassportVerified { get; set; }
        }

		public class GetUserData : ActionResponse
		{
			public List<UserDetailsModel> userdata
			{
				get;
				set;
			}

			public List<StatusData> Statuses
			{
				get;
				set;
			}
		}

		public class TransactionListModel : ActionResponse
		{
			public List<NoqoodyUserModels.TransactionsList> TransactionList
			{
				get;
				set;
			}
		}

		public class UserDatas : ActionResponse
		{
			public string QPAN
			{
				get;
				set;
			}

			public string FirstName
			{
				get;
				set;
			}

			public string LastName
			{
				get;
				set;
			}

			public string Email
			{
				get;
				set;
			}
		}

		public class UserData : ActionResponse
		{

            public string PassportCopy { get; set; }
            public string QIDFront { get; set; }
            public string QIDBack { get; set; }

            public string Id
			{
				get;
				set;
			}

			public string UserCode
			{
				get;
				set;
			}

			public string ProfileImagePath
			{
				get;
				set;
			}

			public string ThumbnailPath
			{
				get;
				set;
			}

			public int UserStatusID
			{
				get;
				set;
			}

			public string FirstName
			{
				get;
				set;
			}

			public string LastName
			{
				get;
				set;
			}

			public string Email
			{
				get;
				set;
			}

			public bool EmailConfirmed
			{
				get;
				set;
			}

			public string SecurityStamp
			{
				get;
				set;
			}

			public string PhoneNumber
			{
				get;
				set;
			}

			public bool PhoneNumberConfirmed
			{
				get;
				set;
			}

			public bool LockoutEnabled
			{
				get;
				set;
			}

			public int AccessFailedCount
			{
				get;
				set;
			}

			public string UserName
			{
				get;
				set;
			}

			public int UserSequence
			{
				get;
				set;
			}

			public DateTime JoiningDate
			{
				get;
				set;
			}

			public int CountryID
			{
				get;
				set;
			}

			public string PIN
			{
				get;
				set;
			}

			public bool IsPinVerified
			{
				get;
				set;
			}

			public bool IsIDVerified
			{
				get;
				set;
			}

			public string IDCardNumber
			{
				get;
				set;
			}

			public string Comments
			{
				get;
				set;
			}

			public DateTime PinVerifiedDate
			{
				get;
				set;
			}

			public string BuildingNo
			{
				get;
				set;
			}

			public string StreetNo
			{
				get;
				set;
			}

			public string Zone
			{
				get;
				set;
			}

			public int? UserType
			{
				get;
				set;
			}

			public string DigitalSignature
			{
				get;
				set;
			}

			public string PassportNumber
			{
				get;
				set;
			}

			public DateTime DOB
			{
				get;
				set;
			}

			public string PlaceOfBirth
			{
				get;
				set;
			}

			public string HomeNumber
			{
				get;
				set;
			}

			public DateTime QIDExpiry
			{
				get;
				set;
			}

			public string AccountLevel
			{
				get;
				set;
			}

			public decimal UserBalance
			{
				get;
				set;
			}

			public List<NoqoodyUserModels.PaymentCardListModel> PaymentCardLists
			{
				get;
				set;
			}

			public List<NoqoodyUserModels.BankDetailsListModelAdmin> BankDetailsLists
			{
				get;
				set;
			}
		}

		public class StatusData : ActionResponse
		{
			public string StatusName
			{
				get;
				set;
			}

			public int ID
			{
				get;
				set;
			}
		}

		public class DashbordListModel : ActionResponse
		{
			public Users GetUsersStatusCount
			{
				get;
				set;
			}

			public List<NoqoodyUserModels.TransactionsList> TransactionList
			{
				get;
				set;
			}

			public List<TransacionsCountgraph> TransactionListCount
			{
				get;
				set;
			}

			public List<TransacionsAmountgraph> TransactionListAmount
			{
				get;
				set;
			}
		}

		public class Users
		{
			public int ActiveUsers
			{
				get;
				set;
			}

			public int InActiveUsers
			{
				get;
				set;
			}
		}

		public class TransacionsCountgraph
		{
			public int Value
			{
				get;
				set;
			}

			public DateTime Day
			{
				get;
				set;
			}
		}

		public class TransacionsCountgraphN
		{
			public int Value
			{
				get;
				set;
			}

			public DateTime Day
			{
				get;
				set;
			}
		}

		public class TransacionsAmountgraph
		{
			public int Month
			{
				get;
				set;
			}

			public int Year
			{
				get;
				set;
			}

			public decimal? Amount
			{
				get;
				set;
			}

			public decimal? monthlyCount
			{
				get;
				set;
			}
		}
	}
}