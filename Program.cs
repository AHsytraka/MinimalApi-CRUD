using Minimal_API_CRUD.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<User> users = new()
{
    new User {UserId = 1, Name = "David", Username = "Beckham"},
    new User {UserId = 2, Name = "Lionel", Username = "Messi"},
    new User {UserId = 3, Name = "Cristiano", Username = "Ronaldo"}
};

//A Get Endpoint using minimalApi
app.MapGet("/Users", () => users);

//Post
app.MapPost("/AddUser", (User user) =>
{
    users.Add(user);
    return users;
});
    
app.UseHttpsRedirection();

app.Run();