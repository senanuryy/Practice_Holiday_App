using System;

namespace PracticeHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string newPlan = "";
            do
            {
                Console.Write("Gideceğiniz lokasyonu seçiniz (Bodrum, Marmaris, Çeşme): ");
                string location = "";
                int locationFee = 0;
                do
                {
                    location = Console.ReadLine().ToLower();

                    switch (location)
                    {
                        case "bodrum":
                            Console.WriteLine("\nBodrum için Paket başlangıç fiyatı 4000 TL.");
                            locationFee = 4000;
                            break;

                        case "marmaris":
                            Console.WriteLine("\nMarmaris için Paket başlangıç fiyatı 3000 TL.");
                            locationFee = 3000;
                            break;

                        case "çeşme":
                            Console.WriteLine("\nÇeşme için Paket başlangıç fiyatı 5000 TL.");
                            locationFee = 5000;
                            break;

                        default:
                            Console.Write("\nHata. Geçerli bir lokasyon giriniz (Bodrum, Marmaris, Çeşme): ");
                            break;
                    }

                } while (location != "bodrum" && location != "marmaris" && location != "çeşme");

                Console.Write("\nKaç kişi için tatil planlıyorsunuz? ");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());

                switch (location)
                {
                    case "bodrum":
                        Console.WriteLine($"\n{numberOfPeople} kişilik Bodrum tatilinde sizi bekleyenler:");
                        Console.WriteLine("Antik kentler, Bodrum Kalesi ve Sualtı Arkeoloji Müzesi'ni keşfedebilir, eşsiz plajlarda yüzebilir ve gece hayatının tadını çıkarabilirsiniz.");
                        break;

                    case "marmaris":
                        Console.WriteLine($"\n{numberOfPeople} kişilik Marmaris tatilinde sizi bekleyenler:");
                        Console.WriteLine("Tekne turlarına katılabilir, çevredeki koyları gezebilir, doğa yürüyüşleri yapabilir ve Marmaris Kalesi'ni ziyaret edebilirsiniz.");
                        break;

                    case "çeşme":
                        Console.WriteLine($"\n{numberOfPeople} kişilik Çeşme tatilinde sizi bekleyenler:");
                        Console.WriteLine("Alaçatı'da rüzgar sörfü yapabilir, Ege'nin berrak plajlarında güneşlenebilir, Çeşme Kalesi'ni keşfedebilir ve lezzetli yerel tatların keyfini sürebilirsiniz.");
                        break;
                }

                Console.WriteLine("\nTatilinize hangi ulaşım yoluyla gitmek istersiniz?");
                Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
                Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1, 2): ");

                string transportation = Console.ReadLine();     //yanlışlıkla harf girilirse kod çalışmıyor. O yüzden değişkeni num yapmayı tercih etmedim.
                int transportationFee = 0;
                do
                    switch (transportation)
                    {
                        case "1":
                            Console.WriteLine("\nKara yolunu seçtiniz.");
                            transportationFee = 1500;
                            break;

                        case "2":
                            Console.WriteLine("\nHava yolunu seçtiniz.");
                            transportationFee = 4000;
                            break;

                        default:
                            Console.Write("\nGeçersiz seçim. Lütfen sadece 1 ya da 2 seçeneklerinden birini giriniz: ");
                            transportation = Console.ReadLine();
                            break;

                    } while (transportation != "1" && transportation != "2");

                Console.WriteLine("\n---ÖZET---");
                Console.WriteLine($"Lokasyon   : {location}");
                Console.WriteLine($"Kişi sayısı: {numberOfPeople}");
                Console.WriteLine($"Ulaşım     : {transportation}");
                int total = numberOfPeople * (locationFee + transportationFee);
                Console.WriteLine($"TOTAL      : {total} TL.");



                Console.Write("\nBaşka bir tatil planlamak ister misiniz? (Evet, Hayır): ");
                newPlan = Console.ReadLine().ToLower();

                while (newPlan != "evet" && newPlan != "hayır")
                {
                    Console.Write("\nGeçersiz seçim. Lütfen sadece evet ya da hayır yazınız.: ");
                    newPlan = Console.ReadLine().ToLower();
                }
                if (newPlan == "hayır")
                {                    
                    Console.WriteLine("\nİyi günler dileriz.");
                }                

            } while (newPlan == "evet");
        }
    }
}

