using System;
using System.Collections.Generic;

namespace Doccledocumentretriever
{
	public class Document
	{
		public string uri { get; set; }
		public string contentUrl { get; set; }
		public string creationDate { get; set; }
		public string name { get; set; }
		public string shortName { get; set; }
		public bool opened { get; set; }
		public string presentationType { get; set; }
		public string senderDocumentType { get; set; }
		public Object senderStyling { get; set; }
		public Payment payment { get; set; }
		public List<Action> actions { get; set; }
		public Sender sender { get; set; }
		public List<string> categories { get; set; }
	}
}