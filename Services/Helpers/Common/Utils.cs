using System.Text.RegularExpressions;

namespace PLANTILLA_API_ODATA.Services.Helpers.Common
{
    public class Utils
    {
        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
