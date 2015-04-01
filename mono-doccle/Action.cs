using System;
using Newtonsoft.Json;

namespace MonoDoccle
{
	public class Action
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }
	}
}
	