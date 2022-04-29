using System;

namespace Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {    int sayac=0;
            Console.WriteLine("RUS RULETİ'ne Hoşgeldiniz! \nİlk önce sandalyeye bağlanacak kurbanların bilgilerini girmeniz lazım.");
            Kurbanlar kurban1= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban1.Ad=Console.ReadLine();
            kurban1.Soyad=Console.ReadLine();
            kurban1.meslegi=Console.ReadLine();
            kurban1.yaşı=Int32.Parse(Console.ReadLine());
            kurban1.KurbanBilgileri();sayac++;
            Kurbanlar kurban2= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban2.Ad=Console.ReadLine();
            kurban2.Soyad=Console.ReadLine();
            kurban2.meslegi=Console.ReadLine();
            kurban2.yaşı=Int32.Parse(Console.ReadLine());
            kurban2.KurbanBilgileri();sayac++;
            Kurbanlar kurban3= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban3.Ad=Console.ReadLine();
            kurban3.Soyad=Console.ReadLine();
            kurban3.meslegi=Console.ReadLine();
            kurban3.yaşı=Int32.Parse(Console.ReadLine());
            kurban3.KurbanBilgileri();sayac++;
            Kurbanlar kurban4= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban4.Ad=Console.ReadLine();
            kurban4.Soyad=Console.ReadLine();
            kurban4.meslegi=Console.ReadLine();
            kurban4.yaşı=Int32.Parse(Console.ReadLine());
            kurban4.KurbanBilgileri();sayac++;
            Kurbanlar kurban5= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban5.Ad=Console.ReadLine();
            kurban5.Soyad=Console.ReadLine();
            kurban5.meslegi=Console.ReadLine();
            kurban5.yaşı=Int32.Parse(Console.ReadLine());
            kurban5.KurbanBilgileri();sayac++;
            Kurbanlar kurban6= new Kurbanlar();
            System.Console.WriteLine("ad/soyad/meslek/yaş");
            kurban6.Ad=Console.ReadLine();
            kurban6.Soyad=Console.ReadLine();
            kurban6.meslegi=Console.ReadLine();
            kurban6.yaşı=Int32.Parse(Console.ReadLine());
            kurban6.KurbanBilgileri();sayac++;
                System.Console.WriteLine("Güzel! Kinci kardeşim. Sırada 5 mermisi olan bir 6patlar ile sandalyeye bağlı bu kişilere sıkacaksın.\nBakalım boş kime denk gelecek?\nBaşlayalım:");
                System.Console.WriteLine("Önce 1. kişiye sıkıyoruzzzzzzz:");
                Random rnd = new Random();
                int sayi = rnd.Next(1,7);
                if(sayi==1){System.Console.WriteLine("Aha!!!  " + kurban1.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
                System.Console.WriteLine("Önce 2. kişiye sıkıyoruzzzzzzz:");
                if(sayi==2){System.Console.WriteLine("Aha!!!  " + kurban2.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
                System.Console.WriteLine("Önce 3. kişiye sıkıyoruzzzzzzz:");
                if(sayi==3){System.Console.WriteLine("Aha!!!  " + kurban3.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
                System.Console.WriteLine("Önce 4. kişiye sıkıyoruzzzzzzz:");
                if(sayi==4){System.Console.WriteLine("Aha!!!  " + kurban4.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
                System.Console.WriteLine("Önce 5. kişiye sıkıyoruzzzzzzz:");
                if(sayi==5){System.Console.WriteLine("Aha!!!  " + kurban5.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
                System.Console.WriteLine("Önce 6. kişiye sıkıyoruzzzzzzz:");
                if(sayi==6){System.Console.WriteLine("Aha!!!  " + kurban6.Ad +  " kurtuldu :D Diğerleri ne yazık ki öldü.");}
        }}
            
class Kurbanlar
{
    public string Ad;
    public string Soyad;
    public string meslegi;
    public int yaşı;

    public void KurbanBilgileri()
    {System.Console.WriteLine("Kurbanın Adı:{0}", Ad);
    System.Console.WriteLine("Kurbanın soyadı:{0}",Soyad);
    System.Console.WriteLine("Kurbanın mesleği:{0}",meslegi);
    System.Console.WriteLine("Kuranın yaşı:{0}",yaşı);
    }
}}
