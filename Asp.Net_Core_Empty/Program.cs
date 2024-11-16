using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klas�r�nde bulunan statik dosyalar�n kullan�lmas�n� sa�l�yoruz
app.UseStaticFiles();

// Routing yap�land�rmas�n� ekliyoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsay�lan route: Home controller ve Index action

// Uygulaman�n �al��mas�n� ba�lat�yoruz
app.Run();

/*
    A��klamalar:
    
    - **builder.Build()**: Uygulaman�n yap�land�r�lmas�n� tamamlar ve �al��t�r�labilir hale getirir.
    - **app.Run()**: Uygulaman�n �al��mas�n� ba�lat�r ve gelen istekleri dinlemeye ba�lar.
    
    - **Controllers**: MVC yap�s�ndaki kontrol�rleri i�erir. Uygulama gelen HTTP isteklerine yan�t verir. Controller s�n�flar�, istemciden gelen veriyi i�ler ve do�ru View'e y�nlendirir.
    
    - **Action**: Controller i�inde bulunan metodlard�r. Bu metodlar, istekleri al�r ve ilgili i�lemleri yapar. �rne�in, veritaban�ndan veri almak, kullan�c�ya geri bildirimde bulunmak gibi i�lemler Action metotlar�nda ger�ekle�tirilir.
    
    - **Model**: Uygulaman�n i� mant��� ve verisiyle ilgili s�n�flard�r. Bu s�n�flar veritaban� ile etkile�ime girer ve veriyi kontrol eder.
    
    - **View**: Kullan�c�ya g�sterilecek sayfalar�n tasar�m�n� i�eren Razor View dosyalar�n� i�erir. Razor, C# ve HTML'i birle�tirmenizi sa�lar.
    
    - **Razor**: .cshtml uzant�l� dosyalard�r ve dinamik HTML i�eri�i �retir. Razor view dosyalar�nda C# kodlar� yer alabilir.
    
    - **RazorView**: Razor kullan�larak yaz�lm��, dinamik i�erik sa�layan view dosyalar�d�r. Bunlar, kullan�c�ya g�sterilecek HTML sayfalar�n� olu�turur.
    
    - **wwwroot**: Statik dosyalar�n sakland��� klas�rd�r. JavaScript, CSS ve resimler gibi dosyalar burada bulunur. Bu dosyalar do�rudan kullan�c�lara sunulur.
    
    - **builder.Build()**: Web uygulamas� yap�land�r�ld�ktan sonra, bu metot �a�r�l�r ve uygulama i�in bir WebApplication nesnesi olu�turulur.
    
    - **app.Run()**: Web uygulamas�n�n �al��t�r�lmas�n� ba�latan komut olup, gelen HTTP isteklerini dinler ve yan�t verir.
*/
