# Sinema Seans Takip Uygulaması

## Açıklama

Bu uygulama, sinema salonlarında gösterilen filmlerin ve bu filmlere ait seansların takibini sağlayan bir Windows Forms uygulamasıdır. Kullanıcılar, filmleri, salonları ve seansları ekleyebilir, düzenleyebilir ve silebilirler.

## Kurulum

1. Projeyi bilgisayarınıza klonlayın veya ZIP olarak indirin.
2. Visual Studio gibi bir C# IDE'sinde projeyi açın.
3. Proje dosyalarınızın bulunduğu dizinde bir SQLite veritabanı oluşturulacak şekilde yapılandırılmış olan `cinema.db` dosyasını oluşturun veya bulun.

## Kullanım

1. Uygulamayı başlatın.
2. Ana ekran, film ekleme, salon ekleme ve seans ekleme gibi işlevleri içerir.
3. Filmler, salonlar ve seanslar ekleyerek veritabanınızı yönetin.
4. Seansları görüntülemek için ana ekrandaki tabloyu kullanın.

## Özellikler

- **Filmler**: Filmlerin adını ekleyebilir, düzenleyebilir ve silebilirsiniz.
- **Salonlar**: Salonların adını ve koltuk kapasitesini ekleyebilir, düzenleyebilir ve silebilirsiniz.
- **Seanslar**: Filmlere ve salonlara ait seansları ekleyebilir, düzenleyebilir ve silebilirsiniz. Ek olarak, seansları tarih ve saat bilgisiyle planlayabilirsiniz.

## Veritabanı Yapısı

Uygulama, SQLite veritabanı kullanmaktadır. Veritabanı yapısı şu şekildedir:

- **Filmler** tablosu: Film bilgilerini içerir.
- **Salonlar** tablosu: Salon bilgilerini içerir.
- **Seanslar** tablosu: Seans bilgilerini içerir ve filmlerle ve salonlarla ilişkilidir.

## Kod İçeriği

### `Film` Sınıfı

- `FilmId`: Filmin benzersiz kimliğini temsil eden bir tamsayı.
- `Ad`: Film adını temsil eden bir dize.
- `Seanslar`: Filmle ilişkili seansları içeren bir `List<Seans>` nesnesi.

### `Salon` Sınıfı

- `SalonId`: Salonun benzersiz kimliğini temsil eden bir tamsayı.
- `Ad`: Salonun adını temsil eden bir dize.
- `KoltukKapasitesi`: Salonun koltuk kapasitesini temsil eden bir tamsayı.

### `Seans` Sınıfı

- `SeansId`: Seansın benzersiz kimliğini temsil eden bir tamsayı.
- `TarihSaat`: Seansın başlangıç tarih ve saatini temsil eden bir `DateTime` nesnesi.
- `FilmId`: Seansla ilişkili filmin kimliğini temsil eden bir tamsayı.
- `Film`: Seansla ilişkili filmi temsil eden bir `Film` nesnesi.
- `SalonId`: Seansla ilişkili salonun kimliğini temsil eden bir tamsayı.
- `Salon`: Seansla ilişkili salonu temsil eden bir `Salon` nesnesi.

### `AppDbContext` Sınıfı

- `Filmler`: Filmleri içeren bir DbSet.
- `Salonlar`: Salonları içeren bir DbSet.
- `Seanslar`: Seansları içeren bir DbSet.
- `OnConfiguring`: Veritabanı bağlantısı için yapılandırma ayarlarını içeren bir metod.
- `OnModelCreating`: Model oluşturma aşamasında yapılandırmaları içeren bir metod.

Bu sınıflar, uygulamanın temel veri modelini ve veritabanı işlemlerini yönetir. Film, salon ve seanslar arasındaki ilişkileri yönetir ve veritabanı işlemlerini gerçekleştirir.

## Teknolojiler

- C# programlama dili
- Windows Forms (WinForms) teknolojisi
- Entity Framework Core: Veritabanı işlemleri için kullanılmıştır.
- SQLite: Hafif ve yerel bir veritabanı çözümü olarak kullanılmıştır.

## Notlar

- Proje, basit ve anlaşılır bir şekilde yapılandırılmıştır.
- Entity Framework Core kullanarak veritabanı işlemleri yapılmıştır.
- Kod içerisinde gerekli açıklamalar ve belirtici isimlendirme kullanılmıştır.
