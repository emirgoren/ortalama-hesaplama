
double a,b,c,ort;

hataa:
Console.Write("Ilk sinav sonucunuz : ");
a = Convert.ToDouble(Console.ReadLine());

if(a>100 || a<0)
{
	Console.WriteLine("100'un ustunde ya da 0'in altinda bir deger girilemez");
	goto hataa;
}

hatab:
Console.Write("Ikinci sinav sonucunuz : ");
b = Convert.ToDouble(Console.ReadLine());

if(b>100 || b<0)
{
	Console.WriteLine("100'un ustunde ya da 0'in altinda bir deger girilemez");
	goto hatab;
}

hatac:
Console.Write("Sozlu sinav sonucunuz : ");
c = Convert.ToDouble(Console.ReadLine());

if(c>100 || c<0)
{
	Console.WriteLine("100'un ustunde ya da 0'in altinda bir deger girilemez");
	goto hatac;
}

// Math.Round metotu degeri yuvarlar. Ornegin 10,21314 gibi bir sonuc cikmasin diyedir.
// ',' den sonrasi ise kac haneli olacagini belirler.

ort = Math.Round((a+b+c) / 3,1); 
Console.WriteLine(ort);          



// Islemin Metot uzerindeki ornegi:

double ab;
var myOrtalama = OrtalamaHesapla(150,82,91,out ab); // hata ornegini gorebilin diye ilk parametreye 150 degerini atadim ancak try-catch yapisi bunun icin daha uygun olacaktir.

Console.WriteLine(myOrtalama);

static double OrtalamaHesapla(double x, double y, double z, out double ab)
{
	ab = Math.Round((x+y+z) / 3,2);
	if(x>100 || y>100 || z>100)
	{
		Console.WriteLine("100'un ustunde deger girilemez.");
	}
	else if(x<0 || y<0 || z<0)
	{
		Console.WriteLine("0'dan kucuk deger girilemez");
	}
	else
	{
		return ab;
	}
	return 0;
}

