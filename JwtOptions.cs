namespace WEB.BPM.Entities
{
    public class JwtOptions
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiresIn { get; set; } = 7200;
    }
}
