using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages //static olduğunda newlemezsin
    {
        public static  string CarAdded="Araba eklendi";
        public static string InvalidInformation = "Bilgiler geçersiz";
        public static string CarUpdated="Araba bilgileri güncellendi";
        public static string CarDeleted="Araba sistemden silindi";
        public static string BrandAdded="Marka eklendi";
        public static string BrandDeleted="Marka silindi";
        public static string ColorAdded= "Renk eklendi";
        public static string ColorUpdated="Renk bilgileri güncellendi";
        public static string CustomerAdded= "Müşteri eklendi";
        public static string CustomerDeleted= "Müşteri silindi";
        public static string CustomerUpdated= "Müşteri bilgileri güncellendi";
        public static string UserAdded= "Kullanıcı eklendi";
        public static string UserDeleted= "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        internal static string RentalFailed="Bu araba zaten kiralandı";
        internal static string RentalAdded="Kiralama başarılı";
        internal static string RentalDeleted="Kiralama işlemi sistemden silindi";
        internal static string RentalUpdated="Kiralama işlemi güncellendi";
    }
}
