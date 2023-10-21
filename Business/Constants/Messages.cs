using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";

        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Bakım zamanı olduğu için listeleme yapılamıyor.";
        public static string ProductCountOfCategoryError = "Kategorinin alacağı maksimum ürün sayısına ulaşıldı.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün bulunmaktadır.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemez.";
    }
}
