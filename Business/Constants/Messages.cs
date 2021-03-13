using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages // sabit old için sürekli new lememek için static yaptık
    {
        public static string ProductAdded = "Ürün Eklendi"; // public olanlar PascalCase yazılır
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün bulunmaktadır";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied=" Maalesef Genç! Yetkin yok";
        public static string UserRegistered= "Kullanıcı başarıyla kayıt edildi";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string PasswordError = "Parola hatalı !";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists= "Kullanıcı zaten Mevcut";
        public static string AccessTokenCreated="Access token başarıyla oluşuruldu";
    }
}
