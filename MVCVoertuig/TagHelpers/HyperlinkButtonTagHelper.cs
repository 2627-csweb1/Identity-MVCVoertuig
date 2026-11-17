using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCVoertuig.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("a", Attributes ="button-color")]
    public class HyperlinkButtonTagHelper : TagHelper
    {
        public string ButtonColor { get; set; } = string.Empty;
        [HtmlAttributeName("text-color")]
        public string TextColor { get; set; }="dark";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{ButtonColor} text-{TextColor} m-1 p-1");
        }
    }
}
