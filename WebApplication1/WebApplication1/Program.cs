var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();



var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=student}/{action=index}/{id?}"
    );


app.Run();
