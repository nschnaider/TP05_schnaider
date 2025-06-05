var builder = WebApplication.CreateBuilder(args);

// 🛠 Agregar servicios antes de Build
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // ✅ esto va antes de Build

var app = builder.Build();

// ⛓ Middleware
app.UseSession(); // ✅ este sí va después de Build

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
