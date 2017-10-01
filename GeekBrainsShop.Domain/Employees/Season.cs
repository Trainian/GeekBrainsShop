using System.ComponentModel;
using System.Data.Entity.ModelConfiguration;

namespace GeekBrainsShop.Domain.Employees
{
    public class Season
    {
        public int SeasonId { get; set; }

        [DisplayName("Сезон")]
        public string SeasonName { get; set; }
    }

    public class SeasonConfiguration : EntityTypeConfiguration<Season>
    {
        public SeasonConfiguration()
        {
            HasKey(x => x.SeasonId);

            Property(x => x.SeasonId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.SeasonName)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}