namespace Chat.Data
{
    public class ApplicationSettings
    {
        private readonly IConfiguration _configuration;
        private Credential ApplicationContextCredential;

        public string DbConnection
        {
            get => _configuration
                .GetConnectionString("DbConnection")
                .Replace("@@uid", ApplicationContextCredential.Login)
                .Replace("@@password", ApplicationContextCredential.Password);
        }

        public ApplicationSettings(IConfiguration configuration)
        {
            _configuration = configuration;
            ApplicationContextCredential.Login = "DevRobot";
            ApplicationContextCredential.Password = "r*@Yy2eU3@Tj";
        }
        struct Credential
        {
            public string Login;
            public string Password;
        }
    }
}
