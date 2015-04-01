using System;
using Newtonsoft.Json;

namespace MonoDoccle
{
	public class Payment
	{
		[JsonProperty("amount")]
		public object Amount { get; set; }

		[JsonProperty("amountVAT")]
		public double AmountVAT { get; set; }

		[JsonProperty("ogm")]
		public string Ogm { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("dueDate")]
		public object DueDate { get; set; }

		[JsonProperty("debitDate")]
		public DateTime DebitDate { get; set; }
	}
}
	