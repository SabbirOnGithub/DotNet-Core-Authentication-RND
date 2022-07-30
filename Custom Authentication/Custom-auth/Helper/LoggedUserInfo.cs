namespace Custom_auth.Helper
{
    public class LoggedUserInfo: ILoggedinUserInfo
    {
        public string Name { get; set; }

        public LoggedUserInfo()
        {
            Name = "Sabbir";
        }
    }
}
