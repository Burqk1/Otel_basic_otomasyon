# Otel Basic Otomasyon

C# Windows Forms ile yazılmış, SQL Server kullanan basit bir otel otomasyonu. Personel giriş yaptıktan sonra müşteri kaydı oluşturabiliyor, 14 odadan birine konaklama kaydı açabiliyor, odaların doluluk durumunu görebiliyor, müşteri çıkışı (kayıt silme) yapabiliyor ve müşterilere ait mesajları kaydedebiliyor. Arayüz ve kod tamamen Türkçe.

## Özellikler

- **Personel girişi** (`Form6`, uygulamanın açılış formu): Kullanıcı adı ve şifre `personeller` tablosundan kontrol ediliyor.
- **Ana menü** (`Form3`): Müşteri Kayıt, Mesajlar, Müşteri Çıkış ve Oda Kontrol ekranlarına geçiş.
- **Müşteri kayıt** (`Form1`, sınıf adı `mkayıt`): TC kimlik no, ad, soyad, adres, telefon (maskeli giriş), doğum tarihi ve cinsiyet alınıyor. TC ve telefon alanlarına yalnızca rakam, ad ve soyad alanlarına yalnızca harf girilebiliyor. Ad ve soyad büyük harfe çevriliyor.
- **Oda kayıt** (`odakayıt`): Giriş ve çıkış tarihi/saati, yemek dahil seçeneği ve oda numarası (1–14) seçiliyor. Dolu odalar kırmızı gösteriliyor. Kayıt sırasında TC'nin daha önce kayıtlı olmaması ve odanın boş olması kontrol ediliyor; ardından müşteri `müsteriler` tablosuna, konaklama `odakayıt` tablosuna yazılıyor.
- **Ücret hesabı**: Gün sayısı × 1000. Yemek dahilse sonuç 1,25 ile çarpılıyor.
- **Oda durumu** (`Form5`): 14 odanın doluluk durumu renkle gösteriliyor (dolu odalar kırmızı).
- **Müşteri çıkış** (`Form4`): Tüm oda kayıtları tabloda listeleniyor, TC ile filtrelenebiliyor, seçili satırın kaydı silinerek çıkış yapılıyor.
- **Mesajlar** (`Form2`): Sistemde kayıtlı bir TC için mesaj kaydediliyor; tüm mesajlar listede görüntüleniyor.

## Teknoloji

- C#, Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server (`System.Data.SqlClient`, Windows kimlik doğrulaması)
- Visual Studio 2022 çözüm dosyası (`burakproje.sln`, VS 17)

## Proje yapısı

```
burakproje.sln
burakproje/
├── Program.cs                 # Giriş noktası, Form6 ile açılıyor
├── App.config                 # Bağlantı dizesi ve runtime ayarı
├── Form6.cs                   # Personel girişi
├── Form3.cs                   # Ana menü
├── Form1.cs                   # Müşteri bilgileri (mkayıt)
├── odakayıt.cs                # Oda / konaklama kaydı
├── Form5.cs                   # Oda durumu
├── Form4.cs                   # Müşteri çıkış
├── Form2.cs                   # Mesajlar
├── odakontrol.cs              # Boş form (kullanılmıyor)
├── projeotelDataSet.xsd       # Typed DataSet (yalnızca müsteriler tablosu)
├── Properties/
└── Resources/left-arrow-28-48.png   # Geri butonu ikonu
```

## Gereksinimler

- Windows
- Visual Studio (.NET masaüstü geliştirme iş yükü ile) ve .NET Framework 4.7.2
- SQL Server (Express veya LocalDB de olur) ve `projeotel` adında bir veritabanı

## Veritabanı

Depoda veritabanı oluşturma betiği yok. Kodda kullanılan tablolar ve sütunlar şunlar:

| Tablo | Sütunlar |
|---|---|
| `personeller` | `kullaniciadi`, `password` |
| `müsteriler` | `mtc`, `mad`, `msoyad`, `mcinsiyet`, `mDogumTarihi`, `mtel`, `madres` |
| `odakayıt` | `mtc`, `GTarih`, `CTarih`, `Yemek`, `odano`, `ucret` |
| `mesajlar` | `id`, `mtc`, `Mesaj` |

Sütun tipleri koddan kesin olarak çıkarılamıyor. Birkaç not:

- `GTarih` ve `CTarih` alanlarına `DateTime` değeri yazılıyor.
- `Yemek` alanına `"0"` veya `"1"`, `mcinsiyet` alanına `"Erkek"` veya `"Kadın"` yazılıyor.
- `Form4`, TC'yi grid'in 5. sütunundan (`Cells[4]`) okuyor. Bu yüzden `odakayıt` tablosundaki sütun sırası önemli.
- `mesajlar.id` otomatik artan bir alan olmalı.

Uygulamaya giriş yapabilmek için `personeller` tablosuna en az bir kullanıcı elle eklenmeli.

## Kurulum ve çalıştırma

1. SQL Server'da `projeotel` veritabanını ve yukarıdaki tabloları oluşturun.
2. Bağlantı dizesini kendi sunucunuza göre güncelleyin (aşağıya bakın).
3. `burakproje.sln` dosyasını Visual Studio ile açın ve F5 ile çalıştırın.

## Yapılandırma

Bağlantı dizesi sabit olarak `Data Source=DESKTOP-3GIB9O5;Initial Catalog=projeotel;Integrated Security=True;Encrypt=False` şeklinde yazılmış. Değiştirmeniz gereken yerler:

- `burakproje/App.config` (`projeotelConnectionString`)
- `Form2.cs`, `Form4.cs`, `Form5.cs`, `Form6.cs` ve `odakayıt.cs` içindeki `SqlConnection baglanti = new SqlConnection("...")` satırları

Formlar `App.config` dosyasını okumuyor; kendi içlerindeki bağlantı dizesini kullanıyor. Bu yüzden bütün dosyaları ayrı ayrı güncellemek gerekiyor.

## Notlar ve sınırlamalar

- Personel girişi (`Form6`) ve müşteri silme (`Form4`) sorguları string birleştirmeyle oluşturuluyor; SQL injection'a açık. Şifreler veritabanında düz metin olarak karşılaştırılıyor.
- Oda doluluk kontrolü tarih aralığına bakmıyor; `odakayıt` tablosunda o oda numarasıyla bir kayıt varsa oda dolu sayılıyor. Aynı TC ile ikinci bir kayıt da açılamıyor.
- Ücret hesabında gün farkı `Convert.ToInt32` ile tam sayıya çevriliyor. Giriş ve çıkış arasındaki süre tam gün değilse hata oluşabilir.
- Oda sayısı (14) ve günlük ücret (1000) kodda sabit.
- Depoda lisans dosyası yok; lisans belirtilmemiş.
