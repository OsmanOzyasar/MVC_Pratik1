var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();      
app.UseAuthorization(); 
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{Action=Index}");

app.MapGet("/", () => "Hello World!");

app.Run();

// Controller -> Kullanýcýdan alýnan istekleri alýp ona uygun cevabý sunar
// Action -> Kullanýcýdan gelen isteði iþleyen Controller içerisinde bulunan metotdur
// Model -> Veri tabanýndaki verileri temsil eden sýnýflardýr
// View -> HTML ile yapýlan arayüzü temsil eder 
// Razor -> HTML içerisinde C# kodlarý yazmamýzý saðlayan þablondur
// RazorView -> HTML ile C# birleþtiren bir dildir ve daha dinamik web sayfalarý yapmamýza olanak tanýr
// wwwroot -> MVC projelerinde statik dosyalarýn saklandýðý dosyadýr (png, video, font) gibi
// builder.Build(); -> mvc projesinin yapýlandýrmasýný tamamlayýp baþlatmaya hazýrlar
// app.Run(); -> uygulamayý çalýþtýrýr

