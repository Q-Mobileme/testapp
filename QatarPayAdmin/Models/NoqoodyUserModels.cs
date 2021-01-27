using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QatarPayAdmin.Models
{
    public class NoqoodyUserModels
    {
		public class PaymentCardListModel
		{
			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06001862 RID: 6242 RVA: 0x00047131 File Offset: 0x00045331
			// (set) Token: 0x06001863 RID: 6243 RVA: 0x00047139 File Offset: 0x00045339
			public int ID { get; set; }

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x06001864 RID: 6244 RVA: 0x00047142 File Offset: 0x00045342
			// (set) Token: 0x06001865 RID: 6245 RVA: 0x0004714A File Offset: 0x0004534A
			public string CardName { get; set; }

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06001866 RID: 6246 RVA: 0x00047153 File Offset: 0x00045353
			// (set) Token: 0x06001867 RID: 6247 RVA: 0x0004715B File Offset: 0x0004535B
			public string CardType { get; set; }

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06001868 RID: 6248 RVA: 0x00047164 File Offset: 0x00045364
			// (set) Token: 0x06001869 RID: 6249 RVA: 0x0004716C File Offset: 0x0004536C
			public string CardNumber { get; set; }

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x0600186A RID: 6250 RVA: 0x00047175 File Offset: 0x00045375
			// (set) Token: 0x0600186B RID: 6251 RVA: 0x0004717D File Offset: 0x0004537D
			public string OwnerName { get; set; }

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x0600186C RID: 6252 RVA: 0x00047186 File Offset: 0x00045386
			// (set) Token: 0x0600186D RID: 6253 RVA: 0x0004718E File Offset: 0x0004538E
			public string ExpiryDate { get; set; }

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x0600186E RID: 6254 RVA: 0x00047197 File Offset: 0x00045397
			// (set) Token: 0x0600186F RID: 6255 RVA: 0x0004719F File Offset: 0x0004539F
			public string CVV { get; set; }

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x06001870 RID: 6256 RVA: 0x000471A8 File Offset: 0x000453A8
			// (set) Token: 0x06001871 RID: 6257 RVA: 0x000471B0 File Offset: 0x000453B0
			public string PaymentCardType { get; set; }

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06001872 RID: 6258 RVA: 0x000471B9 File Offset: 0x000453B9
			// (set) Token: 0x06001873 RID: 6259 RVA: 0x000471C1 File Offset: 0x000453C1
			public DateTime EntryTime { get; set; }

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06001874 RID: 6260 RVA: 0x000471CA File Offset: 0x000453CA
			// (set) Token: 0x06001875 RID: 6261 RVA: 0x000471D2 File Offset: 0x000453D2
			public int ModifiedBy { get; set; }

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06001876 RID: 6262 RVA: 0x000471DB File Offset: 0x000453DB
			// (set) Token: 0x06001877 RID: 6263 RVA: 0x000471E3 File Offset: 0x000453E3
			public int UserID { get; set; }

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06001878 RID: 6264 RVA: 0x000471EC File Offset: 0x000453EC
			// (set) Token: 0x06001879 RID: 6265 RVA: 0x000471F4 File Offset: 0x000453F4
			public DateTime ModifiedTime { get; set; }

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x0600187A RID: 6266 RVA: 0x000471FD File Offset: 0x000453FD
			// (set) Token: 0x0600187B RID: 6267 RVA: 0x00047205 File Offset: 0x00045405
			public string QPAN { get; set; }

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x0600187C RID: 6268 RVA: 0x0004720E File Offset: 0x0004540E
			// (set) Token: 0x0600187D RID: 6269 RVA: 0x00047216 File Offset: 0x00045416
			public string ReminderType { get; set; }
		}

		public class BankDetailsListModelAdmin
		{
			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x0600183F RID: 6207 RVA: 0x00047021 File Offset: 0x00045221
			// (set) Token: 0x06001840 RID: 6208 RVA: 0x00047029 File Offset: 0x00045229
			public int ID { get; set; }

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x06001841 RID: 6209 RVA: 0x00047032 File Offset: 0x00045232
			// (set) Token: 0x06001842 RID: 6210 RVA: 0x0004703A File Offset: 0x0004523A
			public string CountryName { get; set; }

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06001843 RID: 6211 RVA: 0x00047043 File Offset: 0x00045243
			// (set) Token: 0x06001844 RID: 6212 RVA: 0x0004704B File Offset: 0x0004524B
			public string AccountName { get; set; }

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06001845 RID: 6213 RVA: 0x00047054 File Offset: 0x00045254
			// (set) Token: 0x06001846 RID: 6214 RVA: 0x0004705C File Offset: 0x0004525C
			public string BankName { get; set; }

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x06001847 RID: 6215 RVA: 0x00047065 File Offset: 0x00045265
			// (set) Token: 0x06001848 RID: 6216 RVA: 0x0004706D File Offset: 0x0004526D
			public string AccountNumber { get; set; }

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x06001849 RID: 6217 RVA: 0x00047076 File Offset: 0x00045276
			// (set) Token: 0x0600184A RID: 6218 RVA: 0x0004707E File Offset: 0x0004527E
			public string UserID { get; set; }

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x0600184B RID: 6219 RVA: 0x00047087 File Offset: 0x00045287
			// (set) Token: 0x0600184C RID: 6220 RVA: 0x0004708F File Offset: 0x0004528F
			public DateTime? EntryTime { get; set; }

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x0600184D RID: 6221 RVA: 0x00047098 File Offset: 0x00045298
			// (set) Token: 0x0600184E RID: 6222 RVA: 0x000470A0 File Offset: 0x000452A0
			public string OwnerName { get; set; }

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x0600184F RID: 6223 RVA: 0x000470A9 File Offset: 0x000452A9
			// (set) Token: 0x06001850 RID: 6224 RVA: 0x000470B1 File Offset: 0x000452B1
			public string QPAN { get; set; }

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06001851 RID: 6225 RVA: 0x000470BA File Offset: 0x000452BA
			// (set) Token: 0x06001852 RID: 6226 RVA: 0x000470C2 File Offset: 0x000452C2
			public string VIBAN { get; set; }

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06001853 RID: 6227 RVA: 0x000470CB File Offset: 0x000452CB
			// (set) Token: 0x06001854 RID: 6228 RVA: 0x000470D3 File Offset: 0x000452D3
			public string IBAN { get; set; }

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06001855 RID: 6229 RVA: 0x000470DC File Offset: 0x000452DC
			// (set) Token: 0x06001856 RID: 6230 RVA: 0x000470E4 File Offset: 0x000452E4
			public string SwiftCode { get; set; }
		}

		public class TransactionsList
		{
			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001453 RID: 5203 RVA: 0x0004522E File Offset: 0x0004342E
			// (set) Token: 0x06001454 RID: 5204 RVA: 0x00045236 File Offset: 0x00043436
			public int TransactionID { get; set; }

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001455 RID: 5205 RVA: 0x0004523F File Offset: 0x0004343F
			// (set) Token: 0x06001456 RID: 5206 RVA: 0x00045247 File Offset: 0x00043447
			public DateTime TransactionDate { get; set; }

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001457 RID: 5207 RVA: 0x00045250 File Offset: 0x00043450
			// (set) Token: 0x06001458 RID: 5208 RVA: 0x00045258 File Offset: 0x00043458
			public decimal Amount { get; set; }

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001459 RID: 5209 RVA: 0x00045261 File Offset: 0x00043461
			// (set) Token: 0x0600145A RID: 5210 RVA: 0x00045269 File Offset: 0x00043469
			public string Description { get; set; }

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x0600145B RID: 5211 RVA: 0x00045272 File Offset: 0x00043472
			// (set) Token: 0x0600145C RID: 5212 RVA: 0x0004527A File Offset: 0x0004347A
			public int TransactionTypeID { get; set; }

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x0600145D RID: 5213 RVA: 0x00045283 File Offset: 0x00043483
			// (set) Token: 0x0600145E RID: 5214 RVA: 0x0004528B File Offset: 0x0004348B
			public string TransactionType { get; set; }

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x0600145F RID: 5215 RVA: 0x00045294 File Offset: 0x00043494
			// (set) Token: 0x06001460 RID: 5216 RVA: 0x0004529C File Offset: 0x0004349C
			public string TransactionStatus { get; set; }

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001461 RID: 5217 RVA: 0x000452A5 File Offset: 0x000434A5
			// (set) Token: 0x06001462 RID: 5218 RVA: 0x000452AD File Offset: 0x000434AD
			public int RequestId { get; set; }

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001463 RID: 5219 RVA: 0x000452B6 File Offset: 0x000434B6
			// (set) Token: 0x06001464 RID: 5220 RVA: 0x000452BE File Offset: 0x000434BE
			public int userid { get; set; }

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001465 RID: 5221 RVA: 0x000452C7 File Offset: 0x000434C7
			// (set) Token: 0x06001466 RID: 5222 RVA: 0x000452CF File Offset: 0x000434CF
			public string username { get; set; }

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06001467 RID: 5223 RVA: 0x000452D8 File Offset: 0x000434D8
			// (set) Token: 0x06001468 RID: 5224 RVA: 0x000452E0 File Offset: 0x000434E0
			public string imgURL { get; set; }

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06001469 RID: 5225 RVA: 0x000452E9 File Offset: 0x000434E9
			// (set) Token: 0x0600146A RID: 5226 RVA: 0x000452F1 File Offset: 0x000434F1
			public int dest { get; set; }

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x0600146B RID: 5227 RVA: 0x000452FA File Offset: 0x000434FA
			// (set) Token: 0x0600146C RID: 5228 RVA: 0x00045302 File Offset: 0x00043502
			public string TransactionDesc { get; set; }

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x0600146D RID: 5229 RVA: 0x0004530B File Offset: 0x0004350B
			// (set) Token: 0x0600146E RID: 5230 RVA: 0x00045313 File Offset: 0x00043513
			public string BaseUrl { get; set; }

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x0600146F RID: 5231 RVA: 0x0004531C File Offset: 0x0004351C
			// (set) Token: 0x06001470 RID: 5232 RVA: 0x00045324 File Offset: 0x00043524
			public string LocationPath { get; set; }

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001471 RID: 5233 RVA: 0x0004532D File Offset: 0x0004352D
			// (set) Token: 0x06001472 RID: 5234 RVA: 0x00045335 File Offset: 0x00043535
			public decimal Noqs { get; set; }

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001473 RID: 5235 RVA: 0x0004533E File Offset: 0x0004353E
			// (set) Token: 0x06001474 RID: 5236 RVA: 0x00045346 File Offset: 0x00043546
			public int DestinationUserID { get; set; }

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001475 RID: 5237 RVA: 0x0004534F File Offset: 0x0004354F
			// (set) Token: 0x06001476 RID: 5238 RVA: 0x00045357 File Offset: 0x00043557
			public string DestinationUserName { get; set; }

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001477 RID: 5239 RVA: 0x00045360 File Offset: 0x00043560
			// (set) Token: 0x06001478 RID: 5240 RVA: 0x00045368 File Offset: 0x00043568
			public string DestinationImageUrl { get; set; }
		}
	}
}