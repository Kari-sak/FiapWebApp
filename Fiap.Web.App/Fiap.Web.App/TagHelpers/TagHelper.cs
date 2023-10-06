using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Web.App.TagHelpers
{
    public class MessageTagHelper : TagHelper
    {
        public string Mensagem { get; set; }

        public override void Process(
                   TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "alert alert-danger");
            output.Content.SetContent(Mensagem);
        }
    }
}
