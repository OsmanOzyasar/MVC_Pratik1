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

// Controller -> Kullan�c�dan al�nan istekleri al�p ona uygun cevab� sunar
// Action -> Kullan�c�dan gelen iste�i i�leyen Controller i�erisinde bulunan metotdur
// Model -> Veri taban�ndaki verileri temsil eden s�n�flard�r
// View -> HTML ile yap�lan aray�z� temsil eder 
// Razor -> HTML i�erisinde C# kodlar� yazmam�z� sa�layan �ablondur
// RazorView -> HTML ile C# birle�tiren bir dildir ve daha dinamik web sayfalar� yapmam�za olanak tan�r
// wwwroot -> MVC projelerinde statik dosyalar�n sakland��� dosyad�r (png, video, font) gibi
// builder.Build(); -> mvc projesinin yap�land�rmas�n� tamamlay�p ba�latmaya haz�rlar
// app.Run(); -> uygulamay� �al��t�r�r

