using System.ComponentModel;
using System.Data.Entity.ModelConfiguration;

namespace GeekBrainsShop.Domain.Employees
{
    public class Trademark
    {
        public int TrademarkId { get; set; }

        [DisplayName("Торговая марка")]
        public string TrademarkName { get; set; }
    }

    public class TrademarkConfiguration : EntityTypeConfiguration<Trademark>
    {
        public TrademarkConfiguration()
        {
            HasKey(x => x.TrademarkId);

            Property(x => x.TrademarkId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.TrademarkName)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
