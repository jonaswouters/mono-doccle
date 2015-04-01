using System;
using Newtonsoft.Json;

namespace MonoDoccle
{
	public class Sender
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }
	}
}
	