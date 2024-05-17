using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DemoApp.TagHelpers;

[HtmlTargetElement("Math", Attributes = "num1 , num2, Operator")]
public class LottoTagHelper : TagHelper
{
    public float num1 { get; set; }

    public float num2 {get; set;}

    public string Operator {get; set;}

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "I";
        if(Operator.Equals("+"))
        {
            string s = string.Format("{0:0.00}",num1+num2);
            output.Content.Append(s);
        }
       if(Operator.Equals("*"))
        {
        
              string s = string.Format("{0:0.00}",num1*num2);
            output.Content.Append(s);
        }
        if(Operator.Equals("-"))
        {
        
             
              string s = string.Format("{0:0.00}",num1-num2);
            output.Content.Append(s);
        }
        
    }

    
}