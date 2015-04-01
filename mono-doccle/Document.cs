using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MonoDoccle
{
	public class Document
	{
		[JsonProperty("uri")]
		public string Uri { get; set; }

		[JsonProperty("contentUrl")]
		public string ContentUrl { get; set; }

		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("opened")]
		public bool Opened { get; set; }

		[JsonProperty("presentationType")]
		public string PresentationType { get; set; }

		[JsonProperty("senderDocumentType")]
		public string SenderDocumentType { get; set; }

		[JsonProperty("senderStyling")]
		public Object SenderStyling { get; set; }

		[JsonProperty("payment")]
		public Payment Payment { get; set; }

		[JsonProperty("actions")]
		public IList<Action> Actions { get; set; }

		[JsonProperty("sender")]
		public Sender Sender { get; set; }

		[JsonProperty("categories")]
		public IList<string> Categories { get; set; }
	}
}
