using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QatarPayAdmin.Models
{
    public class ActionResponse
    {
		public ActionResponse()
		{
			this.code = "";
			this.message = "";
			this.errors = new List<string>();
		}


		public bool success { get; set; }


		public string code { get; set; }


		public string message { get; set; }


		public List<string> errors { get; set; }


		public void Success(string successmessage, string successcode = "")
		{
			this.success = true;
			this.message = (successmessage ?? "");
			this.code = (successcode ?? "");
		}


		public void Error(string errormessage, string Errorcode = "")
		{
			this.success = false;
			this.message = (errormessage ?? "");
			this.code = (Errorcode ?? "");
		}
	}
}