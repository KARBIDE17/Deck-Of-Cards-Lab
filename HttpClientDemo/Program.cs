using DeckOfCardsApiDemo.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();




// Set the base URL for the API calls
builder.Services.AddHttpClient<DeckOfCardsApiService>(d => 
{   
    d.BaseAddress = new Uri("https://deckofcardsapi.com/api/deck/");         
});




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
