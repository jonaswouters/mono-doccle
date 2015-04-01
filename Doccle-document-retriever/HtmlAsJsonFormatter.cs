﻿using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace Doccledocumentretriever
{
	public class HtmlAsJsonFormatter : JsonMediaTypeFormatter 
	{
		public HtmlAsJsonFormatter ()
		{
			SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
		}
	}
}

