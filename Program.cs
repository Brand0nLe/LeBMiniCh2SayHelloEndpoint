//Brandon Le
//10-25-22
//Mini Challenge 2 - Say Hello Endpoint
//Web API project that will take the users input in the url and print it back into a statement as
//"Hello {name} I hope you're having a great day today! You're doing great! You got this!"
//Peer Review: Jessie Lamzon
//Code is working well and runs without errors.  Good job!



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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
