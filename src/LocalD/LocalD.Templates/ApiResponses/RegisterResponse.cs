namespace LocalD.Templates.ApiResponses
{
    public class RegisterResponse
    {
        public string success { get; set; }
    }

    public class RegisterResponseRootObject
    {
        public RegisterResponse response { get; set; }
    }

}
