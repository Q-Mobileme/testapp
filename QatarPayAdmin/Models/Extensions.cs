using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QatarPayAdmin.Models
{
    public class Extensions
    {
		public enum SystemInfo
		{
			// Token: 0x0400076A RID: 1898
			NotificationMailServer = 1,
			// Token: 0x0400076B RID: 1899
			NotificationEmail,
			// Token: 0x0400076C RID: 1900
			NotificationEmailPassword,
			// Token: 0x0400076D RID: 1901
			NotificationEmailName,
			// Token: 0x0400076E RID: 1902
			NotificationEmailSSL,
			// Token: 0x0400076F RID: 1903
			NotificationEmailPort,
			// Token: 0x04000770 RID: 1904
			HelpDeskEmail,
			// Token: 0x04000771 RID: 1905
			HelpDeskEmailPassword,
			// Token: 0x04000772 RID: 1906
			HelpDeskEmailName = 10,
			// Token: 0x04000773 RID: 1907
			RegisterationGalleryPath,
			// Token: 0x04000774 RID: 1908
			TempGalleryPath,
			// Token: 0x04000775 RID: 1909
			ItemsPerPage,
			// Token: 0x04000776 RID: 1910
			UserProfilePath,
			// Token: 0x04000777 RID: 1911
			StaffImageGallery,
			// Token: 0x04000778 RID: 1912
			Debug,
			// Token: 0x04000779 RID: 1913
			VerificationSMS,
			// Token: 0x0400077A RID: 1914
			HostedAddress,
			// Token: 0x0400077B RID: 1915
			LowBalSMS,
			// Token: 0x0400077C RID: 1916
			SuccessSms,
			// Token: 0x0400077D RID: 1917
			BlockSMS,
			// Token: 0x0400077E RID: 1918
			ApiPassword,
			// Token: 0x0400077F RID: 1919
			ApiUser,
			// Token: 0x04000780 RID: 1920
			ApiTokenPath,
			// Token: 0x04000781 RID: 1921
			SmsApi,
			// Token: 0x04000782 RID: 1922
			EncryptionKey,
			// Token: 0x04000783 RID: 1923
			OtherSMS,
			// Token: 0x04000784 RID: 1924
			PayitClientSecret,
			// Token: 0x04000785 RID: 1925
			PayitPassword,
			// Token: 0x04000786 RID: 1926
			PayitAppID,
			// Token: 0x04000787 RID: 1927
			PayitUserName,
			// Token: 0x04000788 RID: 1928
			PayitRequestURL,
			// Token: 0x04000789 RID: 1929
			PayitBillingURL,
			// Token: 0x0400078A RID: 1930
			PayPalClientID,
			// Token: 0x0400078B RID: 1931
			PayPalClientSecret,
			// Token: 0x0400078C RID: 1932
			FcmApplicationID = 1034,
			// Token: 0x0400078D RID: 1933
			FcmSenderID,
			// Token: 0x0400078E RID: 1934
			FcmAddress,
			// Token: 0x0400078F RID: 1935
			ValidationURL = 1045,
			// Token: 0x04000790 RID: 1936
			OoredooEnabled = 2044,
			// Token: 0x04000791 RID: 1937
			VodafoneEnabled,
			//MemberHostedImageLocation=
		}

		// Token: 0x02000112 RID: 274
		public enum NotificationType
		{
			// Token: 0x04000793 RID: 1939
			NoqsReceived = 1,
			// Token: 0x04000794 RID: 1940
			NoqsPaid,
			// Token: 0x04000795 RID: 1941
			InvoicePaid,
			// Token: 0x04000796 RID: 1942
			InvoiceRequest,
			// Token: 0x04000797 RID: 1943
			Others,
			// Token: 0x04000798 RID: 1944
			InvoicePaymentReceived
		}

		// Token: 0x02000113 RID: 275
		public enum DebugCodes
		{
			// Token: 0x0400079A RID: 1946
			ModelError = 1,
			// Token: 0x0400079B RID: 1947
			IdentitySaveError,
			// Token: 0x0400079C RID: 1948
			Success = 200,
			// Token: 0x0400079D RID: 1949
			Exception = 500
		}

		// Token: 0x02000114 RID: 276
		public enum TransactionRuqestStatus
		{
			// Token: 0x0400079F RID: 1951
			Pending = 7,
			// Token: 0x040007A0 RID: 1952
			Cancelled,
			// Token: 0x040007A1 RID: 1953
			RequestError,
			// Token: 0x040007A2 RID: 1954
			Completed = 6
		}

		// Token: 0x02000115 RID: 277
		public enum OrderStatus
		{
			// Token: 0x040007A4 RID: 1956
			Initiated = 1,
			// Token: 0x040007A5 RID: 1957
			Cancelled,
			// Token: 0x040007A6 RID: 1958
			PaymentPending,
			// Token: 0x040007A7 RID: 1959
			UnderProcessing,
			// Token: 0x040007A8 RID: 1960
			OutForDelivery,
			// Token: 0x040007A9 RID: 1961
			Delivered,
			// Token: 0x040007AA RID: 1962
			PaymentFailed
		}

		// Token: 0x02000116 RID: 278
		public enum OrderPaymentStatus
		{
			// Token: 0x040007AC RID: 1964
			Pending = 1,
			// Token: 0x040007AD RID: 1965
			Failed,
			// Token: 0x040007AE RID: 1966
			Success,
			// Token: 0x040007AF RID: 1967
			CashCollected
		}

		// Token: 0x02000117 RID: 279
		public enum UserStatus
		{
			// Token: 0x040007B1 RID: 1969
			WaitingVerification = 1,
			// Token: 0x040007B2 RID: 1970
			Active,
			// Token: 0x040007B3 RID: 1971
			Blocked
		}

		// Token: 0x02000118 RID: 280
		public enum NotificationReminderType
		{
			// Token: 0x040007B5 RID: 1973
			ONE_MONTH = 1,
			// Token: 0x040007B6 RID: 1974
			BI_WEEKLY,
			// Token: 0x040007B7 RID: 1975
			ONE_WEEK
		}

		// Token: 0x02000119 RID: 281
		public enum PaymentService
		{
			// Token: 0x040007B9 RID: 1977
			ShopOrder = 30
		}

		// Token: 0x0200011A RID: 282
		public enum NotificationsTypes
		{
			// Token: 0x040007BB RID: 1979
			InvoicePayment = 101
		}

		// Token: 0x0200011B RID: 283
		public enum NoticeType
		{
			// Token: 0x040007BD RID: 1981
			NoqsReceived = 1,
			// Token: 0x040007BE RID: 1982
			NoqsPaid,
			// Token: 0x040007BF RID: 1983
			InvoicePaid,
			// Token: 0x040007C0 RID: 1984
			InvoiceRequest,
			// Token: 0x040007C1 RID: 1985
			Others,
			// Token: 0x040007C2 RID: 1986
			InvoicePaymentReceived,
			// Token: 0x040007C3 RID: 1987
			ShopOrder,
			// Token: 0x040007C4 RID: 1988
			OrderDelivered,
			// Token: 0x040007C5 RID: 1989
			OrderCancelled,
			// Token: 0x040007C6 RID: 1990
			NoqsRequest,
			// Token: 0x040007C7 RID: 1991
			WalletRefill
		}

		// Token: 0x0200011C RID: 284
		public enum QatarPayUserType
		{
			// Token: 0x040007C9 RID: 1993
			QatarPay = 1,
			// Token: 0x040007CA RID: 1994
			QatarPayMerchant,
			// Token: 0x040007CB RID: 1995
			QatarPayUser
		}

		// Token: 0x0200011D RID: 285
		public enum CurrencyType
		{
			// Token: 0x040007CD RID: 1997
			QAR = 1,
			// Token: 0x040007CE RID: 1998
			USD
		}

		// Token: 0x0200011E RID: 286
		public enum MerchanrQrRequestStatus
		{
			// Token: 0x040007D0 RID: 2000
			Initiated = 1,
			// Token: 0x040007D1 RID: 2001
			Completed
		}

		// Token: 0x0200011F RID: 287
		public enum LogTypes
		{
			// Token: 0x040007D3 RID: 2003
			Registeration = 1,
			// Token: 0x040007D4 RID: 2004
			Exception = 3,
			// Token: 0x040007D5 RID: 2005
			UserLogin,
			// Token: 0x040007D6 RID: 2006
			EmailSend,
			// Token: 0x040007D7 RID: 2007
			NewUser,
			// Token: 0x040007D8 RID: 2008
			UserModify,
			// Token: 0x040007D9 RID: 2009
			UserPasswordChanged,
			// Token: 0x040007DA RID: 2010
			AddOperatorSettingGroup = 2,
			// Token: 0x040007DB RID: 2011
			EditOperatorSettingGroup = 9,
			// Token: 0x040007DC RID: 2012
			AddOperator,
			// Token: 0x040007DD RID: 2013
			EditOperator,
			// Token: 0x040007DE RID: 2014
			NewUserAPI,
			// Token: 0x040007DF RID: 2015
			DeleteResponseCodes,
			// Token: 0x040007E0 RID: 2016
			DeleteRequestSetting,
			// Token: 0x040007E1 RID: 2017
			EditUserAPI
		}

		// Token: 0x02000120 RID: 288
		public class CountryCodeModel
		{
			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x060010FA RID: 4346 RVA: 0x0004374A File Offset: 0x0004194A
			// (set) Token: 0x060010FB RID: 4347 RVA: 0x00043752 File Offset: 0x00041952
			public int CountryID { get; set; }

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x060010FC RID: 4348 RVA: 0x0004375B File Offset: 0x0004195B
			// (set) Token: 0x060010FD RID: 4349 RVA: 0x00043763 File Offset: 0x00041963
			public string Country { get; set; }

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x060010FE RID: 4350 RVA: 0x0004376C File Offset: 0x0004196C
			// (set) Token: 0x060010FF RID: 4351 RVA: 0x00043774 File Offset: 0x00041974
			public string CountryCode { get; set; }
		}

		// Token: 0x02000121 RID: 289
		public class ComboListModel
		{
			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001101 RID: 4353 RVA: 0x0004377D File Offset: 0x0004197D
			// (set) Token: 0x06001102 RID: 4354 RVA: 0x00043785 File Offset: 0x00041985
			public int ID { get; set; }

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06001103 RID: 4355 RVA: 0x0004378E File Offset: 0x0004198E
			// (set) Token: 0x06001104 RID: 4356 RVA: 0x00043796 File Offset: 0x00041996
			public string Text { get; set; }
		}

		// Token: 0x02000122 RID: 290
		public class ComboListModeliPLAYin
		{
			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06001106 RID: 4358 RVA: 0x0004379F File Offset: 0x0004199F
			// (set) Token: 0x06001107 RID: 4359 RVA: 0x000437A7 File Offset: 0x000419A7
			public int ID { get; set; }

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06001108 RID: 4360 RVA: 0x000437B0 File Offset: 0x000419B0
			// (set) Token: 0x06001109 RID: 4361 RVA: 0x000437B8 File Offset: 0x000419B8
			public string Text { get; set; }

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x0600110A RID: 4362 RVA: 0x000437C1 File Offset: 0x000419C1
			// (set) Token: 0x0600110B RID: 4363 RVA: 0x000437C9 File Offset: 0x000419C9
			public string Field1 { get; set; }
		}
	}
}