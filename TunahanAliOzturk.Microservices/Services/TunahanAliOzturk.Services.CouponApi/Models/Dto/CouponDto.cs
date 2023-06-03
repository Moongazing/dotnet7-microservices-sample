namespace TunahanAliOzturk.Services.CouponApi.Models.Dto
{
    public class CouponDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double DicountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
