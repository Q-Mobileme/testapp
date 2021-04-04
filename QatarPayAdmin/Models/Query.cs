using Newtonsoft.Json;
using QatarPayAdmin.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static QatarPayAdmin.Models.AdminModel;
using static QatarPayAdmin.Models.Extensions;

namespace QatarPayAdmin.Models
{
    public class Query
    {
		QatarPayEntities db = new QatarPayEntities();
		public List<AdminModel.UserDetailsModel> GetUserDetails()
		{
			List<UserType> usertypes = db.UserTypes.ToList();
			List<Status> status = db.Status.ToList();
			return (from d in db.AspNetUsers.ToList()
					select new AdminModel.UserDetailsModel
					{
						Email = d.Email,
						FirstName = d.FirstName,
						IDCardNumber = d.IDCardNumber,
						LastName = d.LastName,
						PhoneNumber = d.PhoneNumber,
						UserType = (from x in usertypes
									where x.ID == d.UserType
									select x into s
									select s.UserType1).FirstOrDefault(),
						Userseq = d.UserSequence.ToString(),
						IsActive = (from x in status
									where x.ID == d.UserStatusID
									select x into s
									select s.StatusName).FirstOrDefault(),
						IsPassportVerified= d.PassportVerified ,
						IsQidVerified=d.IsIDVerified,
						JoiningDate=d.JoiningDate,
						PassportNumber=d.PassportNumber,
						QPAN=d.UserCode,
					}).ToList();
		}

		public List<AdminModel.StatusData> GetAllStatus()
		{
			return (from d in db.Status.ToList()
					select new AdminModel.StatusData
					{
						StatusName = d.StatusName,
						ID = d.ID
					}).ToList();
		}


		public TemporaryImageLocation GetTemperaryImageByID(int ID)
		{
			return db.TemporaryImageLocations.Where((TemporaryImageLocation s) => s.ID == ID).FirstOrDefault();
		}

		public bool SendFCM(string message, string subject, string DeviceToken)
		{
			try
			{
				Dictionary<Extensions.SystemInfo, string> settings = GetSystemSettings;
				string applicationID = Decrypt(settings[Extensions.SystemInfo.FcmApplicationID]);
				string senderId = Decrypt(settings[Extensions.SystemInfo.FcmSenderID]);
				SaveTxtLog("ApplicationID:" + applicationID);
				SaveTxtLog("senderId:" + senderId);
				WebRequest tRequest = WebRequest.Create(settings[Extensions.SystemInfo.FcmAddress]);
				tRequest.Method = "post";
				tRequest.ContentType = "application/json";
				List<string> dest = new List<string>();
				dest.Add(DeviceToken);
				var data = new
				{
					to = DeviceToken,
					notification = new
					{
						body = message,
						title = subject,
						icon = "myicon",
						sound = "default"
					},
					priority = "high"
				};
				string output = "";
				output = JsonConvert.SerializeObject(data);
				byte[] byteArray = Encoding.UTF8.GetBytes(output);
				tRequest.Headers.Add($"Authorization: key={applicationID}");
				tRequest.Headers.Add($"Sender: id={senderId}");
				tRequest.ContentLength = byteArray.Length;
				Stream dataStream = tRequest.GetRequestStream();
				dataStream.Write(byteArray, 0, byteArray.Length);
				WebResponse tResponse = tRequest.GetResponse();
				Stream dataStreamResponse = tResponse.GetResponseStream();
				StreamReader tReader = new StreamReader(dataStreamResponse);
				string sResponseFromServer = tReader.ReadToEnd();
				SaveTxtLog("Response from FCM:" + sResponseFromServer);
				return true;
			}
			catch (Exception ex)
			{
				SaveTxtLog(ex.ToString());
				return false;
			}
		}

		public bool SendFCM(string message, string subject, int UserID)
		{
			try
			{
				Dictionary<Extensions.SystemInfo, string> settings = GetSystemSettings;
				string applicationID = Decrypt(settings[Extensions.SystemInfo.FcmApplicationID]);
				string senderId = Decrypt(settings[Extensions.SystemInfo.FcmSenderID]);
				//SaveTxtLog("ApplicationID:" + applicationID);
				//SaveTxtLog("senderId:" + senderId);
				DeviceToken device = db.DeviceTokens.Where((DeviceToken d) => d.UserID == UserID).FirstOrDefault();
				string deviceId = "";
				deviceId = ((device == null) ? "49af1e67bb8e8306ae2cb3cf60c76a46646210be" : device.DeviceToken1);
				SaveTxtLog($"UserID: {UserID} , DeviceToken:{deviceId}");
				WebRequest tRequest = WebRequest.Create(settings[Extensions.SystemInfo.FcmAddress]);
				tRequest.Method = "post";
				tRequest.ContentType = "application/json";
				List<string> dest = new List<string>();
				dest.Add(deviceId);
				var data = new
				{
					to = deviceId,
					notification = new
					{
						body = message,
						title = subject,
						icon = "myicon",
						sound = "default"
					},
					priority = "high"
				};
				string output = "";
				output = JsonConvert.SerializeObject(data);
				byte[] byteArray = Encoding.UTF8.GetBytes(output);
				tRequest.Headers.Add($"Authorization: key={applicationID}");
				tRequest.Headers.Add($"Sender: id={senderId}");
				tRequest.ContentLength = byteArray.Length;
				Stream dataStream = tRequest.GetRequestStream();
				dataStream.Write(byteArray, 0, byteArray.Length);
				WebResponse tResponse = tRequest.GetResponse();
				Stream dataStreamResponse = tResponse.GetResponseStream();
				StreamReader tReader = new StreamReader(dataStreamResponse);
				string sResponseFromServer = tReader.ReadToEnd();
				SaveTxtLog("Response from FCM:" + sResponseFromServer);
				return true;
			}
			catch (Exception ex)
			{
				SaveTxtLog(ex.ToString());
				return false;
			}
		}

		public Task<bool> SendEmailAsync(SendMailModel message)
		{
			Dictionary<SystemInfo, string> systemSetting = GetSystemSettings;
			try
			{
				SmtpClient SmtpServer = new SmtpClient(systemSetting[SystemInfo.NotificationMailServer], int.Parse(systemSetting[SystemInfo.NotificationEmailPort]));
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(systemSetting[SystemInfo.NotificationEmail], systemSetting[SystemInfo.NotificationEmailName]);
				mail.To.Add(message.ToEmailAddress);
				mail.Subject = message.Subject;
				mail.IsBodyHtml = true;
				mail.Body = message.Body;
				SmtpServer.UseDefaultCredentials = true;
				SmtpServer.Credentials = new NetworkCredential(systemSetting[SystemInfo.NotificationEmail], Decrypt(systemSetting[SystemInfo.NotificationEmailPassword]));
				SmtpServer.EnableSsl = ((systemSetting[SystemInfo.NotificationEmailSSL] == "true") ? true : false);
				SmtpServer.Send(mail);
				mail.Dispose();
				SaveTxtLog($"{DebugCodes.Success}: Email send to {message.ToEmailAddress}");
				return Task.FromResult(result: true);
			}
			catch (Exception e)
			{
				SaveTxtLog($"Email {DebugCodes.Exception}: Error Sending Email {e.ToString()}");
				return Task.FromResult(result: false);
			}
		}
		public Dictionary<SystemInfo, string> GetSystemSettings => db.SystemSettings.ToDictionary((SystemSetting t) => (SystemInfo)t.ID, (SystemSetting t) => t.Value);

		public AspNetUser GetUserInfoByUserName(string username)
		{
			return db.AspNetUsers.FirstOrDefault((AspNetUser x) => x.UserName == username);
		}

		public decimal GetNoqsByUserID(int UserID)
		{
			decimal credit = (from d in db.Transactions.Where((Transaction d) => d.TransactionStatusID == 1 && d.UserID == UserID).ToList()
							  where d.TransactionTypeID == 7
							  select d).Sum((Transaction s) => s.LocalAmount);
			decimal debit = (from d in db.Transactions.Where((Transaction d) => d.TransactionStatusID == 1 && d.UserID == UserID).ToList()
							 where d.TransactionTypeID == 1 || d.TransactionTypeID == 4 || d.TransactionTypeID == 2 || d.TransactionTypeID == 5 || d.TransactionTypeID == 6 || d.TransactionTypeID == 8 || d.TransactionTypeID == 3
							 select d).Sum((Transaction s) => s.Amount);
		
			return debit - credit;
		}

		public List<NoqoodyUserModels.PaymentCardListModel> GetPaymentCardListsadmin(int ID)
		{
			List<NoqoodyUserModels.PaymentCardListModel> result = (from d in db.PaymentCards
																   select new NoqoodyUserModels.PaymentCardListModel
																   {
																	   ID = d.ID,
																	   CardName = d.CardName,
																	   CardNumber = d.CardNumber.Remove(4, 8).Insert(4, " **** **** "),
																	   CardType = d.CardType,
																	   UserID = d.UserID,
																	   EntryTime = d.EntryTime,
																	   ModifiedBy = d.ModifiedBy,
																	   ModifiedTime = d.ModifiedTime,
																	   ExpiryDate = d.ExpiryDate,
																	   OwnerName = d.OwnerName,
																	   CVV = d.CVV,
																	   PaymentCardType = ((object)d.PaymentCardType).ToString(),
																	   QPAN = (from x in db.AspNetUsers
																			   where x.UserSequence == ID
																			   select x into k
																			   select k.UserCode).FirstOrDefault(),
																	   ReminderType = d.ReminderType
																   } into x
																   where x.UserID == ID
																   select x).ToList();
			foreach (NoqoodyUserModels.PaymentCardListModel item in result)
			{
				item.CVV = ((item.CVV == null) ? "000" : Decrypt(item.CVV));
			}
			return result;
		}

		public string Encrypt(string Data)
		{
			SHA1Managed shaM = new SHA1Managed();
			Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Data)));
			byte[] eNC_data = Encoding.ASCII.GetBytes(Data);
			return Convert.ToBase64String(eNC_data);
		}

		public string Decrypt(string Data)
		{
			byte[] dEC_data = Convert.FromBase64String(Data);
			return Encoding.ASCII.GetString(dEC_data);
		}

		public void SaveTxtLog(string message)
		{
			try
			{
				Dictionary<SystemInfo, string> systemSetting = GetSystemSettings;
				if (systemSetting[Extensions.SystemInfo.Debug] == "true")
				{
					if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\"))
					{
						Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\");
					}
					string date_Today = (DateTime.Now.Date.Day + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Year).ToString();
					StreamWriter Addwritefile = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + date_Today + ".txt", append: true);
					Addwritefile.WriteLine(DateTime.Now.ToString() + ": " + message);
					Addwritefile.Close();
					Addwritefile.Dispose();
				}
			}
			catch (Exception)
			{
				//SaveLog("error in txtlog:" + e.Message, 0, 0);
			}
		}

		public List<NoqoodyUserModels.BankDetailsListModelAdmin> GetBankDetailsListsAdmin(int ID)
		{
			BankDetail txt = db.BankDetails.Where((BankDetail x) => x.UserID == (int?)ID).FirstOrDefault();
			return (from d in db.BankDetails
					select new NoqoodyUserModels.BankDetailsListModelAdmin
					{
						ID = d.ID,
						AccountName = d.AccountName,
						BankName = d.BankName,
						AccountNumber = d.AccountNumber,
						CountryName = d.CountryName,
						EntryTime = d.CreatedOn,
						OwnerName = d.OwnerName,
						UserID = ((object)d.UserID).ToString(),
						IBAN = d.IBAN,
						SwiftCode = d.SwiftCode,
						QPAN = db.AspNetUsers.Where((AspNetUser x) => (int?)x.UserSequence == d.UserID).FirstOrDefault().UserCode,
						VIBAN = "0000 0000 0000 " + db.AspNetUsers.Where((AspNetUser x) => (int?)x.UserSequence == d.UserID).FirstOrDefault().UserCode.Substring(db.AspNetUsers.Where((AspNetUser x) => (int?)x.UserSequence == d.UserID).FirstOrDefault().UserCode.Length - 4, 4)
					} into x
					where x.UserID == ID.ToString()
					select x).ToList();
		}

		public AspNetUser GetCurrentUserSeq(string id)
		{
			int currentUserId = Convert.ToInt32(id);
			return db.AspNetUsers.FirstOrDefault((AspNetUser x) => x.UserSequence == currentUserId);
		}

		public List<NoqoodyUserModels.TransactionsList> GetTransactionListbyUserID(int ID)
		{
			Dictionary<SystemInfo, string> settings = GetSystemSettings;
			List<TransactionStatu> status = db.TransactionStatus.ToList();
			List<TransactionsType> transaction_type = db.TransactionsTypes.ToList();
			List<AspNetUser> user_list = db.AspNetUsers.ToList();
			return (from d in db.Transactions.ToList()
					where d.UserID == ID
					select new NoqoodyUserModels.TransactionsList
					{
						Amount = d.Amount,
						Description = d.Description,
						dest = int.Parse(d.DestinationUserID.ToString()),
						RequestId = d.RequestID,
						TransactionDate = d.TransactionDate,
						TransactionTypeID = d.TransactionTypeID,
						userid = d.UserID,
						TransactionType = ((transaction_type.Where((TransactionsType s) => s.ID == d.TransactionTypeID).FirstOrDefault() == null) ? "NA" : transaction_type.Where((TransactionsType s) => s.ID == d.TransactionTypeID).FirstOrDefault().TransactionType),
						TransactionStatus = ((status.Where((TransactionStatu s) => s.ID == d.TransactionStatusID).FirstOrDefault() == null) ? "NA" : status.Where((TransactionStatu s) => s.ID == d.TransactionStatusID).FirstOrDefault().Status),
						TransactionID = d.ID,
						username = user_list.Where((AspNetUser x) => x.UserSequence == d.UserID).FirstOrDefault().FirstName,
						TransactionDesc = d.TransactionDescription,
						imgURL = ((user_list.Where((AspNetUser x) => x.UserSequence == d.DestinationUserID).FirstOrDefault() == null) ? "NA" : user_list.Where((AspNetUser x) => x.UserSequence == d.DestinationUserID).FirstOrDefault().ProfileImagePath),
						BaseUrl = settings[SystemInfo.HostedAddress],
						LocationPath = settings[SystemInfo.RegisterationGalleryPath]
					}).ToList();
		}

		public AspNetUser GetCurrentUserInfoByID(string id)
		{
			return db.AspNetUsers.FirstOrDefault((AspNetUser x) => x.Id == id);
		}

		public AspNetUser GetCurrentUserInfoByID(int UserSequence)
		{
			return db.AspNetUsers.FirstOrDefault((AspNetUser x) => x.UserSequence == UserSequence);
		}

		public AdminModel.Users getusercounts()
		{
			AdminModel.Users respose = new AdminModel.Users();
			respose.ActiveUsers = db.AspNetUsers.Where((AspNetUser x) => x.UserStatusID == 2).Count();
			respose.InActiveUsers = db.AspNetUsers.Where((AspNetUser x) => x.UserStatusID == 3).Count();
			return respose;
		}

		

		public List<NoqoodyUserModels.TransactionsList> GetTransactionList()
		{
			return (from c in (from x in db.Transactions.ToList()
							   orderby x.ID descending
							   select x).Take(10)
					select new NoqoodyUserModels.TransactionsList
					{
						Amount = c.Amount,
						Description = c.TransactionDescription,
						TransactionDate = c.TransactionDate,
						TransactionID = c.ID,
						TransactionTypeID = c.TransactionTypeID,
						TransactionType = ((db.TransactionsTypes.Where((TransactionsType d) => d.ID == c.TransactionTypeID).FirstOrDefault() == null) ? "NA" : db.TransactionsTypes.Where((TransactionsType d) => d.ID == c.TransactionTypeID).FirstOrDefault().TransactionType),
						TransactionStatus = ((db.TransactionStatus.Where((TransactionStatu d) => d.ID == c.TransactionStatusID).FirstOrDefault() == null) ? "NA" : db.TransactionStatus.Where((TransactionStatu d) => d.ID == c.TransactionStatusID).FirstOrDefault().Description),
						RequestId = c.RequestID
					}).ToList();
		}

		public List<AdminModel.TransacionsCountgraph> GetTransactionListCount()
		{
			List<AdminModel.TransacionsCountgraph> respose = new List<AdminModel.TransacionsCountgraph>();
			IEnumerable<Transaction> y = db.Transactions.ToList().Take(20);
			DateTime fromdate = DateTime.Now.Date.AddDays(-20.0);
			DateTime todate = DateTime.Now.Date;
			List<AdminModel.TransacionsCountgraph> resposes = (from x in db.Transactions
															   where x.EntryTime >= fromdate && x.EntryTime <= todate
															   group x by DbFunctions.TruncateTime(x.EntryTime) into x
															   select new AdminModel.TransacionsCountgraph
															   {
																   Value = x.Count(),
																   Day = (DateTime)x.Key
															   }).ToList();
			for (int i = 0; i < 20; i++)
			{
				DateTime date = fromdate.AddDays(i);
				int s = db.Transactions.Where((Transaction x) => (DateTime)DbFunctions.TruncateTime(x.EntryTime) == (DateTime)(DateTime?)date).Count();
				respose.Add(new AdminModel.TransacionsCountgraph
				{
					Value = s,
					Day = fromdate.AddDays(i)
				});
			}
			return respose;
		}

		public List<AdminModel.TransacionsAmountgraph> GetTransactionListAmount()
		{
			List<AdminModel.TransacionsAmountgraph> respose = new List<AdminModel.TransacionsAmountgraph>();
			DateTime fromdate = DateTime.Now.Date.AddMonths(-6);
			List<Transaction> transactions = db.Transactions.ToList();
			for (int i = 0; i < 6; i++)
			{
				decimal amt = default(decimal);
				decimal count = default(decimal);
				DateTime date = fromdate.AddMonths(i);
				List<Transaction> s = db.Transactions.Where((Transaction x) => x.EntryTime.Month == date.Month && x.EntryTime.Year == date.Year).ToList();
				if (s.Count == 0)
				{
					amt = default(decimal);
					count = default(decimal);
				}
				else
				{
					amt = ((db.Transactions.Where((Transaction x) => x.EntryTime.Month == date.Month) == null) ? 0m : db.Transactions.Where((Transaction x) => x.EntryTime.Month == date.Month && x.EntryTime.Year == date.Year).Sum((Transaction x) => x.Amount));
					count = s.Count;
				}
				respose.Add(new AdminModel.TransacionsAmountgraph
				{
					Year = date.Year,
					Month = date.Month,
					Amount = amt,
					monthlyCount = count
				});
			}
			DateTime todate = DateTime.Now.Date;
			return respose;
		}

	

	}


}