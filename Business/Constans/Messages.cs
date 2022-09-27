using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string Added = " eklendi ";
        public static string Invalid = "geçersiz";
        public static string MaintenanceTime= "Sistem bakımda";
        public static string Listed = "listelendi";
        public static string Deleted = "Silindi";
        public static string DataNotFound = "Veri Bulunamadı";
        public static string Updated = "Güncellendi";

        public static string ImageLimitExceed = "En fazla 5 resim ekleyebilirsiniz";
        public static string CategoryLimitExceded = "kategori sınırı aşıldığı için ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kullanıcı oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "hatalı parola";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "accesstoken oluşturuldu";


    }
}