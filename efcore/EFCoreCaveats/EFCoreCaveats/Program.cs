// See https://aka.ms/new-console-template for more information

using EFCoreCaveats;
using Microsoft.EntityFrameworkCore;

using var context = new MyDbContext();
context.Database.Migrate();

Console.WriteLine("Hello, World!");
