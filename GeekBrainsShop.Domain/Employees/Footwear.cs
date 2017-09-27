using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsShop.Domain.Employees
{
    public class Footwear
    {
        public int FootwearId { get; set; }

        [DisplayName("Цена")]
        public int Price { get; set; } // Стоимость начальная

        [DisplayName("Цена cо скидкой")]
        public int? SalePrice { get; set; } // Старая цена без скидки, если есть

        public string ImageLink { get; set; } // Ссылка на картинку

        public bool IsSale { get; set; } // Если распродажа

        public bool IsTop { get; set; } // Если Топ выбора

        public bool IsNew { get; set; } // Если Новинка

        public int TrademarkId { get; set; }

        public virtual Trademark Trademark { get; set; } // Торговая марка

    }

    public class FootwearConfiguration : EntityTypeConfiguration<Footwear>
    {
        public FootwearConfiguration()
        {
            HasKey(x => x.FootwearId);

            Property(x => x.FootwearId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Price)
                .IsRequired();

            Property(x => x.SalePrice)
                .IsOptional();

            Property(x => x.ImageLink)
                .HasMaxLength(500)
                .IsRequired();

            Property(x => x.IsSale)
                .IsRequired();

            Property(x => x.IsTop)
                .IsRequired();

            Property(x => x.IsNew)
                .IsRequired();

            HasRequired(x => x.Trademark);
        }
    }
}
