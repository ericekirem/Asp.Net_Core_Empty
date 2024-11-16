using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klasöründe bulunan statik dosyalarýn kullanýlmasýný saðlýyoruz
app.UseStaticFiles();

// Routing yapýlandýrmasýný ekliyoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsayýlan route: Home controller ve Index action

// Uygulamanýn çalýþmasýný baþlatýyoruz
app.Run();

/*
    Açýklamalar:
    
    - **builder.Build()**: Uygulamanýn yapýlandýrýlmasýný tamamlar ve çalýþtýrýlabilir hale getirir.
    - **app.Run()**: Uygulamanýn çalýþmasýný baþlatýr ve gelen istekleri dinlemeye baþlar.
    
    - **Controllers**: MVC yapýsýndaki kontrolörleri içerir. Uygulama gelen HTTP isteklerine yanýt verir. Controller sýnýflarý, istemciden gelen veriyi iþler ve doðru View'e yönlendirir.
    
    - **Action**: Controller içinde bulunan metodlardýr. Bu metodlar, istekleri alýr ve ilgili iþlemleri yapar. Örneðin, veritabanýndan veri almak, kullanýcýya geri bildirimde bulunmak gibi iþlemler Action metotlarýnda gerçekleþtirilir.
    
    - **Model**: Uygulamanýn iþ mantýðý ve verisiyle ilgili sýnýflardýr. Bu sýnýflar veritabaný ile etkileþime girer ve veriyi kontrol eder.
    
    - **View**: Kullanýcýya gösterilecek sayfalarýn tasarýmýný içeren Razor View dosyalarýný içerir. Razor, C# ve HTML'i birleþtirmenizi saðlar.
    
    - **Razor**: .cshtml uzantýlý dosyalardýr ve dinamik HTML içeriði üretir. Razor view dosyalarýnda C# kodlarý yer alabilir.
    
    - **RazorView**: Razor kullanýlarak yazýlmýþ, dinamik içerik saðlayan view dosyalarýdýr. Bunlar, kullanýcýya gösterilecek HTML sayfalarýný oluþturur.
    
    - **wwwroot**: Statik dosyalarýn saklandýðý klasördür. JavaScript, CSS ve resimler gibi dosyalar burada bulunur. Bu dosyalar doðrudan kullanýcýlara sunulur.
    
    - **builder.Build()**: Web uygulamasý yapýlandýrýldýktan sonra, bu metot çaðrýlýr ve uygulama için bir WebApplication nesnesi oluþturulur.
    
    - **app.Run()**: Web uygulamasýnýn çalýþtýrýlmasýný baþlatan komut olup, gelen HTTP isteklerini dinler ve yanýt verir.
*/
