# Practice_Holiday_App

Bu proje, kullanıcıların tatil planı yapmasına olanak tanıyan bir konsol uygulamasıdır. Kullanıcılar bir lokasyon seçebilir, kaç kişiyle tatil yapacaklarını belirtebilir ve ulaşım türünü seçerek toplam maliyeti hesaplayabilirler.

## Özellikler

- **Lokasyon Seçimi:** Kullanıcı Bodrum, Marmaris veya Çeşme arasında seçim yapabilir.
- **Kişi Sayısı:** Kullanıcı, tatili kaç kişi için planladığını belirtebilir.
- **Ulaşım Türü:** Kara yolu veya hava yolu seçenekleri sunulur, ve bu seçim toplam maliyeti etkiler.
- **Maliyet Hesaplama:** Seçilen lokasyon, kişi sayısı ve ulaşım türüne göre toplam maliyet hesaplanır.
- **Tekrar Planlama:** Kullanıcı, bir tatil planlamayı tamamladıktan sonra başka bir tatil planı yapmayı seçebilir.

## Kullanım

1. Uygulama çalıştırıldığında, kullanıcıdan bir lokasyon seçmesi istenir.
   - Geçerli seçenekler: **Bodrum**, **Marmaris**, **Çeşme**
   - Seçim yapılmazsa veya hatalı bir giriş yapılırsa, tekrar giriş yapması istenir.

2. Lokasyon seçildikten sonra, kullanıcıdan kaç kişi için tatil planladığı sorulur.

3. Kullanıcı, ulaşım türünü seçer:
   - **1:** Kara yolu (Kişi başı 1500 TL)
   - **2:** Hava yolu (Kişi başı 4000 TL)
   - Geçerli bir seçim yapılmazsa tekrar giriş yapılması istenir.

4. Uygulama, seçilen lokasyon, kişi sayısı ve ulaşım türüne göre toplam maliyeti hesaplar ve kullanıcıya bir özet sunar.

5. Kullanıcıya başka bir tatil planlamak isteyip istemediği sorulur.
   - **"Evet":** Uygulama yeniden başlar.
   - **"Hayır":** Uygulama sonlanır ve kullanıcıya iyi günler diler.
  
## Örnek Çıktı
![image](https://github.com/user-attachments/assets/1f9d6d09-e725-4666-ae20-a17aae317ccf)
