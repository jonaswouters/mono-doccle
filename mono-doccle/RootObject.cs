using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MonoDoccle
{
	public class RootObject
	{
		[JsonProperty("documents")]
		public IList<Document> Documents { get; set; }
	}
}
	