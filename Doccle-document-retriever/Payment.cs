using System;

namespace Doccledocumentretriever
{
	public class Payment
	{
		public object amount { get; set; }
		public double amountVAT { get; set; }
		public string ogm { get; set; }
		public string currency { get; set; }
		public object dueDate { get; set; }
		public string debitDate { get; set; }
	}
}

