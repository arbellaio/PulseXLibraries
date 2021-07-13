namespace PulseXLibraries.Helpers.RandomKey
{
    public class RandomKeyCode
    {
        public static string AccountCodeGenerator(string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                var code = phoneNumber.Substring(phoneNumber.Length - 4);
                return code;
            }

            return "";
        }
    }
}