
using System.Net;
baslangic:   // Bu etikettir. Daha önce izlediğim bir videoadan öğrenmiştim. Programın sonunda nedenini göreceksiniz.

Console.WriteLine("Tatil Kovasına Hoşgeldiniz\n");

Console.WriteLine("3 Adet Tatil Seçeneğiniz Mevcuttur.\n\n- BODRUM\n\n- MARMARİS\n\n- ÇEŞME\n");
Console.WriteLine("Lokasyon Bilgileri :\n\n-> Güzel plajlar ve gece hayatı iyi olsun diyorsanız BODRUM sizin için en iyi seçenek olabilir. Fiyatı: 4000 Tl'Dir.\n\n-> Doğaya ve tarihi yerlere merakınız varsa MARMARİS size uygun bir tatil olabilir. Fiyatı: 3000 Tl'dir.\n\n-> Kum, deniz, güneş ve lezzetli yemekler olsun istiyorsanız muhteşem restoranlarıyla ÇEŞME size eşşiz bir deneyim yaşatacaktır. Fiyatı 5000 Tl'dir.\n\n ");

Console.WriteLine("Lütfen Tatil lokasyonunuzu seçiniz\n\n");

int locationPrice = 0;
string location;

do                               // Lokasyon seçimi kontrol aşaması. 
{
    location = Console.ReadLine().Trim().ToLower();

    if (location != "bodrum" && location != "marmaris" && location != "çeşme")
    {
        Console.WriteLine("Geçersiz bir tatil seçeneği girdiniz. Lütfen Bordum, marmaris ve çeşme lokasyonlarından birini seçiniz");
    }
    else
    {
        break;
    }
} while (true);
{

}

switch (location)          // Seçenekler net ve az olduğu için switch case kullandım. 
{
    case "bodrum":
        locationPrice = 4000;
        break;
    case "marmaris":
        locationPrice = 3000;
        break;
    case "çeşme":
        locationPrice = 5000;
        break;

}
Console.WriteLine("------------------------------------------------------------------------\n\n");
Console.WriteLine("Kaç kişilik tatil planı yapmak istiyorsunuz. Lütfen kişi sayısını giriniz.\n\n");

int personNum;              //Kişi sayısının doğru olup olmadığının kontrol aşaması. 
                    
do
{
    personNum = Convert.ToInt32(Console.ReadLine());

    if (personNum <= 0)
    {
        Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz.");
    }
    else
    {
        break;

    }

} while (true);


Console.WriteLine("---------------------------------------------------------------\n\n");
Console.WriteLine("2 adet ulaşım seçeneği mevcuttur. Hava yolu = 4000 Tl ve Kara Yolu = 1500 Tl'dir.\n\nLütfen ulaşım tercihinizi seçiniz.\n\n1 -> Karayolu\n\n2 -> Havayolu\n\n ");

int transport;              // Transfer tipinin doğrulu kontrol döngüsü. 

do
{
    transport = Convert.ToInt32(Console.ReadLine());
    if (transport != 1 && transport != 2)
    {
        Console.WriteLine("Lütfen 1 veya 2 arasından bir seçeneği giriniz. ");
    }
    else
    {
        break;
    }
} while (true);

Console.WriteLine("------------------------------------------------------\n\n");

int toplam; // Burada 2 seçenek olduğu için böyle bir hesaplama yöntemine gittim. Daha kolayı varsa bilmek isterim. 

if (transport == 1)
{
    toplam = (locationPrice + 1500) * personNum;
}
else
{
    toplam = (locationPrice + 4000) * personNum;
}


Console.WriteLine($"Seçimlerinize göre toplam ödeyeceğiniz tutar {toplam}'TL dir\n\nYeni bir tatil planı yapmak ister misiniz? Evet ise 'E' istemiyorsanız 'H' tuşuna basınız.\n\n ");

string answer = Console.ReadLine().ToLower().Trim();

if (answer == "e")
{
    Console.WriteLine("------------------------------\n\n");
    goto baslangic;        //burada cevabın evet olması durumunda etikete git dedim ve program baştan başlamış oldu.                                      

}
else
{
    Console.WriteLine("------------------------------\n\n");
    Console.WriteLine("İyi günler, tekrar bekleriz.");
}