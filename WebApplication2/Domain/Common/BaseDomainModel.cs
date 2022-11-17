namespace   WebApplication2.Domain.Common
{
    public abstract class BaseDomainModel
    {
        public Boolean Estado { get; set; }
        public DateTime? CreatedDate
        {
            get
            {
                return this.CreatedDate.HasValue
                   ? this.CreatedDate.Value
                   : DateTime.Now;
            }
            set { this.CreatedDate = value;  } }
        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
