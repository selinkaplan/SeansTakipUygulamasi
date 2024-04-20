# Sinema Seans Takip Uygulaması

Bu uygulama, sinema salonlarında gösterilen filmlerin ve bu filmlere ait seansların takibini sağlayan bir Windows Forms uygulamasıdır. Kullanıcılar, filmleri, salonları ve seansları ekleyebilir, düzenleyebilir ve silebilirler.

## Proje Tasarımı

Proje Windows .NET Form uygulaması olarak tasarlanacak. Tek bir form üzerinde tab component kullanılacak.

### Film Tabı

Film tabı, filmin adı ve seans saatlerinin tanımlanıp kaydedileceği bir alan içerecek.

### Salon Tabı

Salon tabı, salon koltuk kapasitesi ve adının tanımlanacağı bir alan içerecek.

### Seans Tabı

Seans tabı, ilgili tarih ve saate hangi film ve salon üzerinden boş koltuk varsa "data grid üzerinde" gösterecek. Eğer yer varsa yeni müşteri kaydı kaydedilebilecek.

## İçerik Açıklamaları

### Film Tabı

- **Filmin Adı**: Film adının girileceği bir metin kutusu olacak.
- **Seans Saatleri**: Film için seans saatlerinin girileceği bir alan olacak. Birden fazla seans saati eklenebilecek. 

Bu tab, Film sınıfı içerisindeki özellikleri temsil edecek. Her bir film, adı ve seans saatleri ile ilişkilendirilecek.

### Salon Tabı

- **Salon Adı**: Salonun adının girileceği bir metin kutusu olacak.
- **Koltuk Kapasitesi**: Salonun koltuk kapasitesinin girileceği bir alan olacak.

Bu tab, Salon sınıfı içerisindeki özellikleri temsil edecek. Her bir salon, adı ve koltuk kapasitesi ile ilişkilendirilecek.

### Seans Tabı

- **Tarih ve Saat**: Seansın gerçekleşeceği tarih ve saat bilgisini içeren bir alan olacak.
- **Film**: Seans için gösterilecek filmi seçmek için bir liste olacak.
- **Salon**: Seansın gerçekleşeceği salonu seçmek için bir liste olacak.
- **Boş Koltuklar**: Seçilen tarih ve saatteki film ve salon için boş koltukları gösterecek bir tablo olacak.
- **Yeni Müşteri Kaydı**: Boş koltuklar varsa, yeni bir müşterinin kaydedileceği bir alan olacak.

Bu tab, Seans sınıfı içerisindeki özellikleri ve ilgili ilişkileri temsil edecek. Seçilen tarih ve saatte hangi film ve salon üzerinden boş koltuklar olduğu kontrol edilecek ve eğer varsa yeni müşteri kaydı yapılacak.

## Nesne Modelleme

- **Film Sınıfı**: Film adı ve seans saatleri özelliklerini içerecek.
- **Salon Sınıfı**: Salon adı ve koltuk kapasitesi özelliklerini içerecek.
- **Seans Sınıfı**: Tarih ve saat, film ve salon bilgilerini içerecek. Ayrıca müşteri bilgileri ile ilişkilendirilecek.

## Veritabanı Yapısı

- **Filmler** Tablosu: Film adı ve seans saatleri bilgilerini içerecek.
- **Salonlar** Tablosu: Salon adı ve koltuk kapasitesi bilgilerini içerecek.
- **Seanslar** Tablosu: Tarih ve saat, film ve salon bilgilerini içerecek. Ayrıca müşteri bilgilerini de içerebilecek.

Bu yapılar, SQLite veritabanında oluşturulacak ve Entity Framework kullanılarak veritabanı işlemleri gerçekleştirilecek.

## Teknolojiler

- C# programlama dili
- Windows Forms (WinForms) teknolojisi
- Entity Framework Core: Veritabanı işlemleri için kullanılmıştır.
- SQLite: Hafif ve yerel bir veritabanı çözümü olarak kullanılmıştır.

## Notlar

- Proje, basit ve anlaşılır bir şekilde yapılandırılmıştır.
- Entity Framework Core kullanarak veritabanı işlemleri yapılmıştır.
- Kod içerisinde gerekli açıklamalar ve belirtici isimlendirme kullanılmıştır.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına bakınız.
