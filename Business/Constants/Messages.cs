using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarNameInvalid = "Eklenecek aracın ismi minimum 2 karakter olmalıdır!\n";
        public static string CarPriceInvalid = "Eklenecek aracın fiyatı 0 veya 0'dan küçük olamaz!\n";
        public static string CarAdded = "Araç veri tabanına kaydedildi!\n";
        public static string CarNameAndPriceInvalid = "Araç eklenemedi! Lütfen aracın isim ve fiyat değerlerini kontrol ediniz!\n";
        public static string MaintenanceTime = "Bakım  çalışması vardır. İlginiz için teşekkür ederiz!\n";
        public static string CarDeleted = "Araç bilgileri veritabanından silindi!";
        public static string CarUpdated = "Araç bilgileri güncellendi";
        public static string ListOfCars = "Araçlar Listesi";
        public static string CarInfo = "Araç Bilgileri";


        public static string ColorAdded = "Renk veri tabanına kaydedildi!\n";
        public static string ColorDeleted = "Renk bilgisi silindi\n";
        public static string ColorUpdated = "Renk bilgisi güncellendi\n";
        public static string ColorDetail = "Renk Bilgisi Getiriliyor..\n";
        public static string ListOfColors = "Renkler Listesi";


        public static string BrandAdded = "Marka veri tabanına kaydedildi!\n";
        public static string BrandDeleted = "Marka bilgisi silindi\n";
        public static string BrandUpdated = "Marka bilgisi güncellendi\n";
        public static string BrandDetail = "Marka Bilgisi Getiriliyor..\n";
        public static string ListOfBrands = "Marka Listesi";

        public static string RentInfo = "Araç başka bir firma tarafından kiralanmıştır.\n";
        public static string Rented = "Araç başka bir firma tarafından kiralanmıştır.\n";
        public static string RentalDeleted = "Veri silindi!\n";
        public static string ListOfRental = "Veriler Listeleniyor!\n";
        public static string RentalUpdated = "Veri güncellendi!\n";
        public static string RentalInfo = "İstenen veri bilgileri!\n";

        public static string CustomerAdded = "Müşteri veri tabanına eklendi!\n";
        public static string CustomerDeleted = "Müşteri veri tabanından kaldırıldı!\n";
        public static string CustomerUpdated = "Müşteri bilgisi güncellendi!\n";
        public static string ListOfCustomers = "Müşteriler Listeleniyor!\n";
        public static string CustomerInfo = "Müşteri bilgileri : \n";


        public static string UserAdded = "Kullanıcı veri tabanına eklendi!\n";
        public static string UserDeleted = "Kullanıcı veri tabanından kaldırıldı!\n";
        public static string UserUpdated = "Kullanıcı bilgisi güncellendi!\n";
        public static string ListOfUsers = "Kullanıcılar Listeleniyor!\n";
        public static string UserInfo = "Kullanıcı bilgileri : \n";
        public static string CarCountOfColorError = "Bir araba en fazla 5 renk seçeneğine sahiptir!\n";
        public static string CarNameExistBefore = "Aynı araç ismine sahip başka bir araç daha vardır!";
    }
}
