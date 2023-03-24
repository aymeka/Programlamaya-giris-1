//Console.WriteLine("Bu ve sonrası vizeye çalışmaya başladığım zamanlar için örneklerdir.");



/*Console.WriteLine("Programa hoşgeldininz. Lütfen doğum yılınızı giriniz.");
int yıl=Convert.ToInt32(Console.ReadLine());
Console.WriteLine((2023 - yıl));
Console.ReadKey();
*/



/*Console.WriteLine("Merhaba lütfen isminizi girin: ");
string ad= Console.ReadLine();
Console.WriteLine("Lütfen soyadınızı girin: ");
string soyad= Console.ReadLine();
Console.WriteLine("Hoşgeldiniz {0} {1}.",ad,soyad);
Console.ReadKey();  
*/



/*Console.WriteLine("Programa hoşgeldiniz. Not ortalamanızı ve dersi geçip geçemediğinizi hesaplamak için lütfen vize notunuzu giriniz." );
int vize= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Programa hoşgeldiniz. Not ortalamanızı ve dersi geçip geçemediğinizi hesaplamak için lütfen final notunuzu giriniz.");
int final= Convert.ToInt32(Console.ReadLine());
double ortalama = (vize * 0.4) + (final * 0.6);
Console.WriteLine("Ortalamanız:{0}",ortalama);
if (ortalama>=50)
{
    Console.WriteLine("Dersi geçtiniz.");
}
else
{
    Console.WriteLine("Dersten kaldınız.");
}
Console.ReadKey();
*/



// Geçen seneki vize sorusu

/*Console.WriteLine("Kaç haneli bir fibonacci dizisi oluşturmak istersiniz:");
int tane= Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 1;
int c;
Console.WriteLine(a);
Console.WriteLine(b);
for (int i = 1; i<=(tane-2); i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}
Console.ReadKey();  
*/



/*int sayı = 1;
while (sayı>=1 && sayı<= 26)
{
    sayı++;
    Console.WriteLine(sayı);

}
Console.ReadKey(); 
*/




/*Console.WriteLine("Kullanıcı adını belirleyiniz.");
string kullanıcıadı=Console.ReadLine();
Console.WriteLine("Şifre belirleyiniz.");
string sifre=Console.ReadLine();
Console.WriteLine("Kullanıcı adınızı giriniz:");
string girilenad=Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz:");
string girilensifre=Console.ReadLine();
if (kullanıcıadı==girilenad)
{
    if (sifre==girilensifre)
    {
        Console.WriteLine("Giriş Başarılı.");
    }
    else
{
        Console.WriteLine("Giriş Başarısız.");
    }
}
*/




//sayıların tek çift olma durumu

/*Console.WriteLine("Tek veya çift olup olmadığını kontrol etmek istediğiniz sayıyı giriniz.");
int sayı=Convert.ToInt32(Console.ReadLine());
if (sayı%2==0)
{
    Console.WriteLine("Sayı çift.");
}
else
{
    Console.WriteLine("Sayı tek.");
}
*/



//Asal sayı

/*int sayac = 0;
Console.Write("Sayı Girin : ");
int sayi = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < sayi; i++)
{
    if (sayi % i == 0)
        sayac++;
}

if (sayac != 0)
    Console.WriteLine("Girdiğiniz sayı asal değildir.");
else
    Console.WriteLine("Girdiğiniz sayı asaldır.");
*/


// Mükemmel sayı

/*Console.WriteLine("Sayıyı girin:");
int sayı = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 1; i <= (sayı/2); i++)
{
    if (sayı % i == 0)
    {
        toplam = toplam + i;
    }
}
if (sayı == toplam)
{
    Console.WriteLine(sayı + " Sayısı Bir Mükemmel Sayıdır");
}
else
{
    Console.WriteLine(sayı + " Sayısı Bir Mükemmel Bir Mükemmel Sayı Değildir");
}
Console.ReadKey();
*/


// Hesap Makinesi

int toplam = 0;
int fark = 0;
int çarpım = 1;
double bölüm = 1;
double ortalama = 0;
Console.WriteLine("Hesap Makinesine hoşgeldiniz. Kaç sayı girmek isterseniz: ");
int seçim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Seçeceğiniz işlem, sayıları girdiğiniz sırayla yapılacaktır. Bilginize. ");
for (int i = 0; i < seçim; i++)
{
    Console.WriteLine(" {0}. sayı: ", i + 1);
    int sayı = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayı;
    fark = sayı - fark;
    çarpım = çarpım * sayı;
    bölüm = sayı / bölüm;
    ortalama = toplam / seçim;
}

while (true)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin: 1-Toplam, 2-Fark, 3-Çarpım, 4-Bölüm, 5-Ortalama");
    int seçim1 = Convert.ToInt32(Console.ReadLine());



    if (seçim1 == 1)
    {
        Console.WriteLine("Girdiğiniz sayıların toplamı: {0}", toplam);
    }
    if (seçim1 == 2)
    {
        Console.WriteLine("Girdiğiniz sayıların farkı: {0}", fark);
    }
    if (seçim1 == 3)
    {
        Console.WriteLine("Girdiğiniz sayıların çarpımı: {0}", çarpım);
    }
    else if (seçim1 == 4)
    {
        Console.WriteLine("Girdiğiniz sayıların bölümü: {0}", bölüm);
    }
    if (seçim1 == 5)
    {
        Console.WriteLine("Girdiğiniz sayıların ortalaması: {0}", ortalama);
    }
    else
    {
        Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyiniz.");
    }
}




