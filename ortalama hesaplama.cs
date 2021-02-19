
double a,b,c,ort;


try
{
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
	Console.WriteLine($"Ortalamaniz : {ort}"); 
}
catch
{
	Console.WriteLine("Girdiginiz deger gecerli degil.");
}
