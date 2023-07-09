using ArticleProject.Code;
using ArticleProject.Core;
using ArticleProject.Data;
using ArticleProject.Data.SqlServerEF;
using ArticleProject.Pages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddSingleton<IEmailSender,EmailSender>();

// Inject table
builder.Services.AddSingleton<IDataHelper<Category>, CategoryEntity>();
builder.Services.AddSingleton<IDataHelper<Author>, AuthorEntity>();
builder.Services.AddSingleton<IDataHelper<AuthorPost>, AuthorPostEntity>();

builder.Services.AddAuthorization(op =>
{
    op.AddPolicy("User", p => p.RequireClaim("User", "User"));
    op.AddPolicy("Admin", p => p.RequireClaim("Admin", "Admin"));
});
//builder.Services.AddMvc(op => op.EnableEndpointRouting = false);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseMvcWithDefaultRoute();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "default",
        pattern:"{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();

});

//app.MapRazorPages();

app.Run();
