namespace PulseXLibraries.Models.NetworkAuth
{
    public class AuthNetwork
    {
        public string Name { get; set; }

        public string Icon { get; set; }

        public string Background { get; set; }

        public string Foreground { get; set; }
    }

    public class NetworkAuthData
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string Logo { get; set; }

        public string Picture { get; set; }

        public string Background { get; set; }

        public string Foreground { get; set; }
    }
}