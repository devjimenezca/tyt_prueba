namespace   WebApplication2.Domain.Common
{
    public abstract class BaseDomainModel
    {
        public Boolean Estado { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
