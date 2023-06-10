using System.Text.RegularExpressions;

public class Methods
{
	public static string GenerateUrl(string Url)
	{
		string UrlPeplaceSpecialWords = Regex.Replace(Url, @"&quot;|['"",&?%\.!()@$^_+=*:#/\\-]", " ").Trim();
		string RemoveMutipleSpaces = Regex.Replace(UrlPeplaceSpecialWords, @"\s+", " ");
		string ReplaceDashes = RemoveMutipleSpaces.Replace(" ", "-");
		string seoUrl = ReplaceDashes.Replace("--", "-").ToLower();
		seoUrl = seoUrl.Replace("ş", "s");
		seoUrl = seoUrl.Replace("ı", "i");
		seoUrl = seoUrl.Replace("İ", "i");
		seoUrl = seoUrl.Replace("ç", "c");
		seoUrl = seoUrl.Replace("ğ", "g");
		seoUrl = seoUrl.Replace("ö", "o");
		seoUrl = seoUrl.Replace("ü", "u");	
		
		return seoUrl;
	}
}