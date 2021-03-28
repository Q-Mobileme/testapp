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
            public DateTime JoiningDate { get; set; }
            public string PassportNumber { get; set; }
            public string QPAN { get; set; }
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


		public class SendMailModel
		{
			
			public string ToEmailAddress { get; set; }

			
			public string Subject { get; set; }

			
			public string Body { get; set; }
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

		public static string NewUserTemplate(string fullname, string username, string password, string link, string code)
		{


			var email_verification = $"<!DOCTYPE html><html lang='en' xmlns='http://www.w3.org/1999/xhtml' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:o='urn:schemas-microsoft-com:office:office'><head><meta charset='utf-8'><meta name='viewport' content='width=device-width'><meta http-equiv='X-UA-Compatible' content='IE=edge'><meta name='x-apple-disable-message-reformatting'><title></title><link href='https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700' rel='stylesheet'><style>.bg-maroon{{background:#7e1432}}.gradient-1{{background-image:linear-gradient(to right top,#54002c,#5f032e,#690730,#740d31,#7e1432)}}.gradient-2{{background-image:linear-gradient(to right,#650c3a,#6e0d3b,#760f3b,#7f113b,#87143a)}}.text-red{{color:#89153a !important}}.text-grey{{color:#333}}.text-grey-light{{color:#d1d1d1}}.text-white{{color:#fff}}.font-weight-bold{{font-weight:700 !important}}.text-uppercase{{text-transform:uppercase}}.btn{{display:inline-block;font-weight:400;color:#fff;text-align:center;vertical-align:middle;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none;background-color:transparent;border:1px solid transparent;padding: .375rem .75rem;font-size:1rem;line-height:1.5;border-radius: .25rem;transition:color .15s ease-in-out, background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;text-decoration:none;padding:15px 100px;border-radius:50px;-webkit-box-shadow:0 12px 16px 0 rgba(211, 120, 137, .49);-moz-box-shadow:0 12px 16px 0 rgba(211, 120, 137, .49);box-shadow:0 12px 16px 0 rgba(211, 120, 137, .49)}}@media only screen and (max-width:600px){{.upper-card-half{{width:992px !important;margin:0 !important}}}}p{{line-height:18px}}.mb-0{{margin-bottom:0}}.mt-0{{margin-top:0}}.shadow-1{{-webkit-box-shadow:0 0 5px 0 #363636;-moz-box-shadow:0 0 5px 0 rgba(54, 54, 54);box-shadow:0 0 5px 0 rgba(54, 54, 54)}}</style></head><body width='100%' style='margin:0;padding:0!important;mso-line-height-rule:exactly;background-color:#f5f6f6'><div width='100%' style='margin:0 auto!important;padding:0!important;background-color:#f5f6f6;background:#f1f1f1;font-family:Poppins,sans-serif;font-weight:400;font-size:15px;line-height:1.8;color:rgba(0,0,0,.4);height:100%!important;width:100%!important'><center style='width:100%;background-color:#f5f6f6'><div style='display:none;font-size:1px;max-height:0;max-width:0;opacity:0;overflow:hidden;font-family:sans-serif'> ‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌&nbsp;‌<wbr>&nbsp;‌&nbsp;‌&nbsp;</div><div class='gradient-1' style='max-width:992px;margin:0 auto;background:url(http://qatarpay.com/assets/img/email/background.jpg)'><table align='center' role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%' style='margin:auto;border-spacing:0!important;border-collapse:collapse!important;table-layout:fixed!important'><tbody><tr><td valign='top' class='' style='background-size:contain;width:992px'><table role='presentation' border='0' cellpadding='0' cellspacing='0' width='100%' style='width:992px;border-spacing:0!important;border-collapse:collapse!important;table-layout:fixed!important;margin:0 auto!important'><tbody><tr><td width='100%' style='text-align:center;padding-top:50px;padding-bottom:50px'><a href='' style='text-decoration:none;color:#0d0cb5' target='_blank'><img src='http://qatarpay.com/assets/img/email/logo.png' width='200'   class='CToWUd'></a></td></tr></tbody></table><table class='upper-card-half' style='max-width:100%;width:700px;margin-left:146px!important;margin-right:146px!important;border-spacing:0!important;border-collapse:collapse!important;table-layout:fixed!important;margin:0 auto!important'><tbody><tr><td style='width:70%;margin-left:auto;margin-right:auto;background:0 0;border-top-left-radius:20px;border-top-right-radius:20px'><div class='bg-maroon shadow-1' style='max-width:100%;padding-top:50px;text-align:center;color:rgba(255,255,255,.8);border-top-left-radius:7px;border-top-right-radius:7px;height:179px'> <img src='http://qatarpay.com/assets/img/email/email_verification.png' width='300' class='img-fluid p-20p' style='margin-top:18px'><div class='a6S' dir='ltr' style='opacity:.01;left:906.34px;top:401.444px'><div id=':2es' class='T-I J-J5-Ji aQv T-I-ax7 L3 a5q' title='Download' role='button' tabindex='0' aria-label='Download attachment ' data-tooltip-class='a1V'><div class='aSK J-J5-Ji aYr'></div></div></div></div></td></tr></tbody></table></td></tr></tbody></table><table align='center' role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%' style='margin:auto;border-spacing:0!important;border-collapse:collapse!important;table-layout:fixed!important'><tbody><tr><td valign='top' class='' style='background-size:contain;height:400px'><table style='width:700px;margin-left:146px!important;margin-right:146px!important;border-spacing:0!important;border-collapse:collapse!important;table-layout:fixed!important;margin:0 auto!important'><tbody><tr><td style='width:70%;margin-left:auto;margin-right:auto;background:#fff;border-bottom-left-radius:7px;border-bottom-right-radius:7px'><div style='max-width:700px;margin-top:50px;text-align:center;color:rgba(255,255,255,.8)'><h5 class='text-uppercase' style='font-family:Poppins,sans-serif;margin-top:0;text-align:center;margin-bottom:0;font-size:20px;letter-spacing:-1px;line-height:40px;font-weight:700'> <span style='font-weight:600;color:#000'>Dear {fullname},</span></h5><p class='text-grey message'>You have successfully created a Qatar Pay account.</p><p class='text-grey credentials'>Username: <span class='text-red font-weight-bold'>{username}</span></p><p class='text-grey credentials'>Password: <span class='text-red font-weight-bold'>{password}</span></p><p class='text-grey' style='font-size:16px;padding-left:40px;padding-right:40px'> Please click on the button below to verify your email address and activate your account.</p><a href='{link}' class='btn gradient-2 font-weight-bold'>ACTIVATE YOUR ACCOUNT</a><p style='margin:40px 0 50px 0'><span class='text-grey-light'>In case you need any more information, please email us at</span><br><span class='text-red m-0 font-weight-bold'>helpdesk@qatarpay.com</span></p></div></td></tr><tr><td style='text-align:center'><p style='color:#fff'>Copyright © 2020. Qatar Pay. All rights reserved.</p></td></tr></tbody></table></td></tr></tbody></table></div></center></div></body></html>";
			return email_verification;
		}
	}
}