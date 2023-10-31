using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.BusinessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.EntityFramewrok;
using MyAcademyCarBook.EntityLayer.Concrete;
using MyAcademyCarBook.PresentetionLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<IBrandService, BrandManager>();

builder.Services.AddScoped<ICarStatusDal, EfCarStatusDal>();
builder.Services.AddScoped<ICarStatusService, CarStatusManager>();

builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<ICarDal, EfCarDal>();

builder.Services.AddScoped<IPriceDal, EfPriceDal>();
builder.Services.AddScoped<IPriceService, PriceManager>();
builder.Services.AddDbContext<CarBookContext>();

builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
}).AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<CarBookContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
