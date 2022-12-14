using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<iServiceService, ServiceManager>();
builder.Services.AddScoped<iServiceDal, EfServiceDal>();
builder.Services.AddScoped<iTeamService, TeamManager>();
builder.Services.AddScoped<iTeamDal, EfTeamDal>();

builder.Services.AddScoped<iAnnoucementService, AnnoucementManager>();
builder.Services.AddScoped<iAnnoucementDal, EfAnnoucementDal>();

builder.Services.AddScoped<iImageService, ImageManager>();
builder.Services.AddScoped<iImageDal, EfImageDal>();

builder.Services.AddDbContext<AgricultureContext>();
builder.Services.AddControllersWithViews();



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
