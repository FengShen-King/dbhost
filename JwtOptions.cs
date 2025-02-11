namespace WEB.BPM.Entities
{
    public class JwtOptions
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiresIn { get; set; } = 7200;
    }

  public class JwtOptions1
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiresIn { get; set; } = 7200;
    }

}
