# 🎫 Kurumsal IT Destek ve Talep Yönetim Sistemi

Bu proje, **ASP.NET Core 8.0 MVC** mimarisi kullanılarak geliştirilmiş, şirket içi teknik sorunların (arıza, talep vb.) kayıt altına alınmasını, takip edilmesini ve çözüme kavuşturulmasını sağlayan kapsamlı bir web uygulamasıdır.

## 🚀 Projenin Amacı
Şirketlerdeki teknik destek süreçlerini kağıt veya sözlü iletişimden kurtarıp; **dijital, izlenebilir ve raporlanabilir** bir yapıya kavuşturmaktır. Çalışanlar sorunlarını bildirir, teknik ekip ise bu sorunları öncelik sırasına göre çözer.

## 🛠️ Kullanılan Teknolojiler ve Mimari

Bu proje geliştirilirken endüstri standardı modern teknolojiler tercih edilmiştir:

* **Framework:** .NET 8.0 / ASP.NET Core MVC
* **Veritabanı Yaklaşımı:** Entity Framework Core (Code First)
* **Veritabanı:** MS SQL Server (LocalDB)
* **Frontend:** Bootstrap 5, Razor View Engine, HTML5/CSS3
* **Veri Doğrulama:** jQuery Validation & Data Annotations

## ⚙️ Temel Özellikler

### 1. Rol Bazlı Yetkilendirme (Role Management)
Sistemde hiyerarşik bir yapı bulunmaktadır.
* **Yönetici:** Sisteme yeni Rol ve Personel ekleyebilir.
* **IT Destek:** Açılan talepleri görüntüler ve durumlarını günceller.
* **Personel:** Kendi yaşadığı sorunla ilgili talep oluşturur.

### 2. İlişkisel Veritabanı Yapısı (One-to-Many)
Veriler rastgele değil, ilişkisel bütünlük içinde tutulur.
* **Rol -> Kullanıcı:** Bir rol (örn: Personel) birden fazla kullanıcıya atanabilir.
* **Kullanıcı -> Talep:** Bir kullanıcı birden fazla talep oluşturabilir.

### 3. Talep (Ticket) Yönetimi
Arıza kayıtları 3 farklı durumda takip edilir ve görsel olarak renklendirilir:
* 🟡 **Bekliyor:** Talep yeni açıldı.
* 🔵 **İnceleniyor:** Teknik ekip üzerinde çalışıyor.
* 🟢 **Çözüldü:** Sorun giderildi.

### 4. Kullanıcı Dostu Arayüz (UI/UX)
Bootstrap 5 ile geliştirilen responsive tasarım sayesinde tüm cihazlarda düzgün görüntülenir.

---

## 📸 Ekran Görüntüleri

*(Buraya projenin ekran görüntülerini ekleyebilirsin. Örn: Ana Sayfa, Talep Listesi vb.)*

| Ana Sayfa | Talep Listesi |

|-----------|---------------|
| ![Anasayfa](https://github.com/user-attachments/assets/820a8f6a-7d0e-4e97-ae2c-306d99a8a09b) | ![Ticket Listesi](https://via.placeholder.com/400x200?text=Talep+Listesi+Gorseli) |

---

## 💻 Kurulum (Nasıl Çalıştırılır?)

Projeyi kendi bilgisayarınızda çalıştırmak için şu adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/Eren-1234/IT-Support-Ticket-System.git](https://github.com/Eren-1234/IT-Support-Ticket-System.git)
    ```
2.  **Visual Studio ile Açın:**
    `.sln` uzantılı dosyayı çift tıklayarak açın.
3.  **Veritabanını Oluşturun (Önemli!):**
    Visual Studio'da `Tools` > `NuGet Package Manager` > `Package Manager Console` yolunu izleyin ve şu komutu yazın:
    ```powershell
    update-database
    ```
    *(Bu komut, Code First yapısı sayesinde SQL tablolarını otomatik oluşturacaktır.)*
4.  **Projeyi Başlatın:**
    `F5` tuşuna basın veya yeşil "Play" butonuna tıklayın.

## 📝 Örnek Senaryo (Demo)

Projeyi test etmek için şu sırayla veri girişi yapılması önerilir:
1.  **Roller:** Önce "Yönetici", "IT Destek" ve "Personel" rollerini oluşturun.
2.  **Kullanıcılar:** Bu rolleri atayarak personel kayıtlarını oluşturun.
3.  **Talepler:** Oluşturulan personeller adına arıza kayıtları girin.

---

## 👨‍💻 Geliştirici

**[Adın Soyadın]**
* [LinkedIn Profilin](https://linkedin.com/in/profilin)
* [GitHub Profilin](https://github.com/profilin)
