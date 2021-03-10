using Microsoft.AspNet.Identity;
using QatarPayAdmin.DataBase;
using QatarPayAdmin.Models;
using QatarPayAdmin.QatarPayAuthorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using static QatarPayAdmin.Models.AdminModel;
using static QatarPayAdmin.Models.Extensions;

namespace QatarPayAdmin.Controllers
{
    public class AdminController : ApiController
    {
		private QatarPayEntities db = new QatarPayEntities();

		private Query query = new Query();

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public AdminModel.GetUserData GetUserDetails()
		{
			AdminModel.GetUserData response = new AdminModel.GetUserData();
			response.userdata = query.GetUserDetails();
			if (response.userdata != null)
			{
				response.Statuses = query.GetAllStatus();
				response.success = true;
				response.message = "All user details";
			}
			else
			{
				response.success = false;
				response.message = "no data";
			}
			return response;
		}

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public AdminModel.UserData GetUserDetailsByUsername(string UserName)
		{
			AdminModel.UserData response = new AdminModel.UserData();
			Dictionary<Extensions.SystemInfo, string> settings = query.GetSystemSettings;
			AspNetUser user = query.GetUserInfoByUserName(UserName);
			decimal balance = query.GetNoqsByUserID(user.UserSequence);
			string level = "";
			level = ((balance > 1000m && balance < 5000m) ? "Gold Card" : ((balance > 5000m && balance < 10000m) ? "Diamond Card" : ((!(balance > 10000m)) ? "Maroon Card" : "Platinum Card")));
			if (user != null)
			{
				response.AccessFailedCount = user.AccessFailedCount;
				response.Comments = user.Comments;
				response.CountryID = user.CountryID;
				response.DigitalSignature = user.DigitalSignature;
				response.Email = user.Email;
				response.EmailConfirmed = user.EmailConfirmed;
				response.FirstName = user.FirstName;
				response.IDCardNumber = user.IDCardNumber;
				response.IsIDVerified = user.IsIDVerified;
				response.JoiningDate = response.JoiningDate;
				response.LastName = user.LastName;
				response.PhoneNumber = user.PhoneNumber;
				response.PhoneNumberConfirmed = user.PhoneNumberConfirmed;
				response.ProfileImagePath = settings[Extensions.SystemInfo.HostedAddress] + settings[Extensions.SystemInfo.RegisterationGalleryPath] + "/" + user.ProfileImagePath;
				response.BuildingNo = user.BuildingNo;
				response.StreetNo = user.StreetNo;
				response.Zone = user.Zone;
				response.ThumbnailPath = user.ThumbnailPath;
				response.UserCode = user.UserCode;
				response.UserName = user.UserName;
				response.UserSequence = user.UserSequence;
				response.UserType = user.UserType;
				response.AccountLevel = level;
				response.UserBalance = balance;
				response.DOB = Convert.ToDateTime(user.DOB);
				response.PlaceOfBirth = user.PlaceOfBirth;
				response.QIDExpiry = Convert.ToDateTime(user.QIDExpiry);
				response.HomeNumber = user.HomeNumber;
				response.PaymentCardLists = query.GetPaymentCardListsadmin(user.UserSequence);
				response.BankDetailsLists = query.GetBankDetailsListsAdmin(user.UserSequence);
				response.PassportCopy = "https://api.qatarpay.com/api/" + string.Format("{0}/{1}", settings[Extensions.SystemInfo.RegisterationGalleryPath].Replace("\\\\", "/"), user.PassportImageFront);
				response.QIDFront = "https://api.qatarpay.com/api/" + string.Format("{0}/{1}", settings[Extensions.SystemInfo.RegisterationGalleryPath].Replace("\\\\", "/"), user.QIDFrontImagePath);
				response.QIDBack = "https://api.qatarpay.com/api/" + string.Format("{0}/{1}", settings[Extensions.SystemInfo.RegisterationGalleryPath].Replace("\\\\", "/"), user.QIDBackImagePath);

				response.success = true;
				response.message = "user details";
			}
			else
			{
				response.success = false;
				response.message = "no data";
			}
			return response;
		}

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public AdminModel.TransactionListModel GetTransactionList(string userSeq)
		{
			AdminModel.TransactionListModel response = new AdminModel.TransactionListModel();
			try
			{
				AspNetUser user = query.GetCurrentUserSeq(userSeq);
				if (user == null)
				{
					response.success = false;
					response.code = $"{406}";
					response.message = " Invalid User";
					return response;
				}
				response.TransactionList = query.GetTransactionListbyUserID(user.UserSequence);
				response.success = true;
				response.code = HttpStatusCode.OK.ToString();
				response.message = "";
				return response;
			}
			catch (Exception ex)
			{
				response.success = false;
				response.code = HttpStatusCode.ExpectationFailed.ToString();
				response.message = ex.ToString();
				return response;
			}
		}

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public ActionResponse Changestatus(int usersequence, int statusId)
		{
			ActionResponse response = new ActionResponse();
			try
			{
				AspNetUser users = new AspNetUser();
				users = db.AspNetUsers.Where((AspNetUser x) => x.UserSequence == usersequence).FirstOrDefault();
				if (users != null)
				{
					users.UserStatusID = statusId;
					db.SaveChanges();
					response.success = true;
					response.message = "Status changed successfully";
				}
				else
				{
					response.success = false;
					response.message = "Status not changed";
				}
				return response;
			}
			catch (Exception ex)
			{
				response.success = false;
				response.code = HttpStatusCode.ExpectationFailed.ToString();
				response.message = ex.ToString();
				return response;
			}
		}

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public AdminModel.UserDatas CurrentUserDetails()
		{
			AdminModel.UserDatas response = new AdminModel.UserDatas();
			AspNetUser user = query.GetCurrentUserInfoByID(User.Identity.GetUserId());
			if (user == null)
			{
				response.success = false;
				response.message = "no data found";
				return response;
			}
			response.QPAN = user.UserCode;
			response.Email = user.Email;
			response.FirstName = user.FirstName;
			response.LastName = user.LastName;
			response.message = "found";
			response.success = true;
			return response;
		}

		[HttpGet]
		[QatarPayAuthorize(Roles = "Administrator")]
		public AdminModel.DashbordListModel DashboardData()
		{
			AdminModel.DashbordListModel response = new AdminModel.DashbordListModel();
			try
			{
				response.GetUsersStatusCount = query.getusercounts();
				response.TransactionList = query.GetTransactionList();
				response.TransactionListCount = query.GetTransactionListCount();
				response.TransactionListAmount = query.GetTransactionListAmount();
				response.success = true;
				response.message = "Details found";
				return response;
			}
			catch (Exception ex)
			{
				response.success = false;
				response.code = HttpStatusCode.ExpectationFailed.ToString();
				response.message = ex.ToString();
				return response;
			}
		}

		[HttpPost]
		[QatarPayAuthorize(Roles = "Administrator")]
		public ActionResponse VerifyPassport(VerifyPassportRequest post)
		{
			ActionResponse response = new ActionResponse();
			try
			{
				if (!ModelState.IsValid)
				{
					foreach (ModelState modelState in ModelState.Values)
					{
						foreach (ModelError error in modelState.Errors)
						{
							query.SaveTxtLog(string.Format("Phone Verification Error {0}: {1}", DebugCodes.ModelError, error.ErrorMessage));
							response.errors.Add(error.ErrorMessage);

						}
					}
					response.success = false;
					response.code = String.Format("{0}", (int)HttpStatusCode.BadRequest);
					response.message = "Invalid Model Detail";
					return response;
				}



				AspNetUser users = new AspNetUser();
				users = db.AspNetUsers.Where((AspNetUser x) => x.UserSequence == post.UserID).FirstOrDefault();
				if (users != null)
				{
					users.PassportVerified = true;
					users.PassportVerifiedDate = DateTime.Now;
					
					db.SaveChanges();
					response.success = true;
					response.message = "Status changed successfully";
				}
				else
				{
					response.success = false;
					response.message = "User data not found";
				}
				return response;
			}
			catch (Exception ex)
			{
				response.success = false;
				response.code = HttpStatusCode.ExpectationFailed.ToString();
				response.message = ex.ToString();
				return response;
			}
		}


		[HttpPost]
		[QatarPayAuthorize(Roles = "Administrator")]
		public ActionResponse VerifyQID(VerifyPassportRequest post)
		{
			ActionResponse response = new ActionResponse();
			try
			{
				if (!ModelState.IsValid)
				{
					foreach (ModelState modelState in ModelState.Values)
					{
						foreach (ModelError error in modelState.Errors)
						{
							query.SaveTxtLog(string.Format("Phone Verification Error {0}: {1}", DebugCodes.ModelError, error.ErrorMessage));
							response.errors.Add(error.ErrorMessage);

						}
					}
					response.success = false;
					response.code = String.Format("{0}", (int)HttpStatusCode.BadRequest);
					response.message = "Invalid Model Detail";
					return response;
				}



				AspNetUser users = new AspNetUser();
				users = db.AspNetUsers.Where((AspNetUser x) => x.UserSequence == post.UserID).FirstOrDefault();
				if (users != null)
				{
					

					var account_code = "QPAN";

					if (users.IDCardNumber.ToLower() != "na")
					{
						if (users.IDCardNumber.Length != 11)
						{

							response.success = false;
							response.code = String.Format("{0}", (int)HttpStatusCode.BadRequest);
							response.message = " Invalid QID number";
							return response;
						}

						account_code = $"1{users.IDCardNumber.Substring(3, 3)}{users.IDCardNumber.Substring(users.IDCardNumber.Length - 8)}";

						var userid = db.AspNetUsers.Where(d => d.UserCode.StartsWith(users.UserCode)).Count() + 1;
						if (userid.ToString().Length < 16)
						{
							
							string usercode = db.AspNetUsers.Count().ToString();
							users.UserCode = userid.ToString().PadLeft(16 - usercode.ToString().Length, '0') + usercode.ToString();

						}

						else
						{
							users.UserCode = users.UserCode + userid.ToString();
						}
						users.IsIDVerified = true;
						users.IDVerifiedDate = DateTime.Now;

						db.SaveChanges();

					}
					response.success = true;
					response.message = "Status changed successfully";
				}
				else
				{
					response.success = false;
					response.message = "User data not found";
				}
				return response;
			}
			catch (Exception ex)
			{
				response.success = false;
				response.code = HttpStatusCode.ExpectationFailed.ToString();
				response.message = ex.ToString();
				return response;
			}
		}
	}
}
