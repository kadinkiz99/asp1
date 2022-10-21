using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.TagHelpers
{
	[HtmlTargetElement("benimm")]// istenilen mail ismini vermek için kullanılır . 
	// varsayılan mail oturumun açmamızı sağlar 
	public class EmailTagHalper : TagHelper
	{
		public string Mail { get; set; }
		public string  Display { get; set; }


		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";
			output.Attributes.Add("href", $"mailto:{Mail}");
			output.Content.Append(Display);
		//	base.Process(context, output);
		}

		// propertyler değerlerini almakta process fonksiyonu ise değerleri işleyip outputunu sunmaktadır .  
	}
}
