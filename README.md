# OzgurEvcimen_Odev1
 
Bu repo, bir dizi sorunun çözümünü içerir. Her bir sorunun çözümü, ayrı bir C# (.cs) dosyasında bulunmaktadır. Ana çözüm dosyası `Odev1.cs` adını taşımaktadır. Bu dosya diğer soruların çağrılmasını sağlar.

## Cevap Açıklaması
### Cevap1 ve Cevap2

1 ve 2nci soruları incelediğimde aklımda iki soruyu cevaplayabilecek bir sanal market projesi belirdi. Böyle bir projede, kullanıcının öncelikle sipariş oluşturduğu, sonrasında sistemin kullanıcıya verdiği sipariş numarası ile sipariş içeriğine ve fiyat toplamına erişebildiği bir akış olduğu için cevapları tek bir dosyada birleştirdim ve sırasıyla soru 2'yi sonrasında soru 1'i işledim.

Bu kodun işlevleri şu şekilde:

**Answer()**: Bu fonksiyon, kullanıcıya bir ana menü sunar ve kullanıcının seçimine göre uygun işlevi çağırır. Kullanıcı 1'i seçerse, bir sipariş oluşturmak için CreateOrder fonksiyonunu çağırır. Kullanıcı 2'yi seçerse, bir siparişi aramak için SearchOrder fonksiyonunu çağırır. Kullanıcı 3'ü seçerse, programı sonlandırır.

**CreateOrder()**: Kullanıcıdan bir sipariş oluşturması istenir. Kullanıcı bir veya daha fazla ürün seçebilir. Her ürün seçiminde, ürün numarası ve istenilen miktar kullanıcıdan alınır. Ardından, seçilen ürünlerin ayrıntıları bir listede toplanır ve bu sipariş, orders sözlüğüne eklenir. Her siparişin benzersiz bir numarası vardır ve her yeni sipariş bu numarayı artırarak alır.

**SearchOrder()**: Kullanıcıdan bir sipariş numarası istenir. Girilen numara, orders sözlüğünde bulunan bir siparişin numarası olmalıdır. Ardından, belirtilen siparişin ayrıntıları ekrana yazdırılır. Bu işlem sırasında toplam sipariş fiyatı da hesaplanır ve yazdırılır.

Kod ayrıca statik olarak bir products dictionary ve bir orders dictionary içerir. products, ürün numaraları ile eşleşen ürün isimleri ve fiyatlarını içeren bir sözlüktür. orders ise sipariş numaraları ile eşleşen sipariş ayrıntılarını (ürün adı, fiyatı, miktarı) içeren bir sözlüktür. Bu yöntemler, kullanıcıların sipariş oluşturmasını ve bu siparişleri aramasını sağlar.

### Cevap 3

Bu soru kapsamında Do-While döngüsü ve While döngüsü ile ilgili birer örnek uygulaması yazdım.

**While Döngüsü:**
While döngüsü, başlangıçta koşul kontrol edilmeden önce döngü bloğuna girer.
Koşul doğru olduğu sürece, döngü bloğu tekrar tekrar çalıştırılır.
Koşul yanlış olduğunda, döngü bloğu atlanır ve döngüden çıkılır.
Bu nedenle, döngü bloğu hiçbir zaman çalıştırılmayabilir.

**Do-While Döngüsü:**
Do-While döngüsü, döngü bloğu en az bir kez çalıştırıldıktan sonra koşulu kontrol eder.
Koşul doğru olduğu sürece, döngü bloğu tekrar tekrar çalıştırılır.
Koşul yanlış olduğunda, döngü bloğu atlanır ve döngüden çıkılır.
Bu nedenle, döngü bloğu en az bir kez çalıştırılır.

İki örnekte de "counter" adında bir değişken kullanılıyor. Bu değişken, döngünün kaç kez tekrar edeceğini kontrol etmek için kullanılıyor. Her döngü iterasyonunda bu değişken artırılıyor. While ve Do-While döngülerinin farkı, While döngüsünün önce koşulu kontrol etmesi ve ardından döngü bloğunu çalıştırması, Do-While döngüsünün ise önce döngü bloğunu çalıştırması ve ardından koşulu kontrol etmesidir.

### Cevap 4

Bu kod, rastgele bir sayıyı tahmin etme oyununu gerçekleştirir ve kullanıcıya tahmin etme şansı verir. Kullanıcı doğru sayıyı tahmin edene kadar devam eden bir döngü içinde bulunur. Eğer kullanıcı doğru sayıyı tahmin ederse, oyun sonlanır ve kullanıcıya doğru tahmin ettiği bildirilir. Eğer kullanıcı yanlış tahmin ederse, bu durum bildirilir ve yeniden tahminde bulunması istenir.

### Cevap 5

Bu kod, kullanıcının girdiği bir sayının mükemmel bir sayı olup olmadığını belirler ve eğer mükemmelse, bu sayının bölünenlerini listeler.


**Mükemmel Sayı Nedir?**

Bir sayının mükemmel olması için, kendisi hariç pozitif tam bölenlerinin toplamının kendisine eşit olması gerekir. Başka bir deyişle, bir sayının bölenlerinin toplamı kendisine eşitse, o sayı mükemmel bir sayıdır.

Örneğin, 6'nın bölenleri 1, 2 ve 3'tür. Bu bölenlerin toplamı 1 + 2 + 3 = 6'dır, bu nedenle 6 mükemmel bir sayıdır.

Ancak mükemmel sayılar oldukça nadirdir ve genellikle küçük sayılardır. Örneğin, ilk birkaç mükemmel sayı şunlardır:

- 6 (1 + 2 + 3 = 6)
- 28 (1 + 2 + 4 + 7 + 14 = 28)
- 496 (1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248 = 496)
- 8128 (1 + 2 + 4 + 8 + 16 + 32 + 64 + 127 + 254 + 508 + 1016 + 2032 + 4064 = 8128)


**Kodun adım adım işleyişi:**

- Bu metot, kullanıcıya bir sayı girmesini isteyerek başlar.
- Kullanıcıdan alınan sayı, bir dize olarak alınır ve UInt128 türüne dönüştürülür.
- Bir UInt128 değişkeni olan "total" tanımlanır ve bu değişken mükemmel sayının bölünenlerinin toplamını tutmak için kullanılır.
- Mükemmel sayının bölünenlerini saklamak için bir List<UInt128> olan "divisors" oluşturulur.
- Girilen sayı UInt128'e dönüştürülebiliyorsa, bir for döngüsü kullanarak 1'den (dahil) girilen sayıya kadar olan sayılar taranır.
- Her bir sayı için, eğer girilen sayı bu sayıya bölündüğünde kalan sıfırsa, bu sayı mükemmel sayının bir bölenidir. Bu bölen total değişkenine eklenir ve "divisors" listesine eklenir.
- For döngüsü tamamlandıktan sonra, eğer toplam bölünenler toplamı (total) girilen sayıya eşitse, bu sayı mükemmel bir sayıdır. Bu durumda, kullanıcıya bu sayının mükemmel olduğu ve bölenlerinin listesi gösterilir.
- Eğer toplam bölünenler toplamı girilen sayıya eşit değilse, bu sayı mükemmel bir sayı değildir ve kullanıcıya bu bilgi verilir.
- Eğer girilen dize UInt128'e dönüştürülemezse, kullanıcıya geçerli bir sayı girmesi gerektiği bildirilir.

### Cevap 6

Bu soru kapsamında başlıca string metotlarını inceleyerek bu metotlara dair birer örnek uygulama inceledim.

### Cevap 7

Bu uygulamada kullanıcıdan alınan öğrenci sayısınca, öğrencilerin adını, üç adet sınav sonucununu (her biri 0 ile 100 arasında), ve bu sınavların ortalamasını alarak bir liste içinde saklar. İşlem tamamlandıktan sonra ise bu listeyi ekrana yazdırır.

İşleyiş şu şekildedir:

1. Öncelikle kullanıcıdan öğrenci sayısı alınır ve ardından her bir öğrencinin adını ve sınav sonuçlarını girmesini sağlar.
2. Her öğrenci için ad, 0 ile 100 arasında olması koşullu üç sınav sonucu ve ortalama sonuç bir Tuple nesnesi olarak `studentsList` adlı bir List'e eklenir.
3. Eğer kullanıcı geçerli bir sayı girmemişse veya sınav sonuçları geçerli bir sayı aralığında değilse, program kullanıcıya geçerli bir giriş yapması gerektiğini belirten bir hata mesajı gösterir.
4. Son olarak, `studentsList` içindeki her öğrenci için adını, sınav sonuçlarını ve ortalamasını ekrana yazdırır.
