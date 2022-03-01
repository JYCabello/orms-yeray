// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using EFCoreCaveats;
using Microsoft.EntityFrameworkCore;

await using var context = new MyDbContext();

// context.Parents.Add(new ParentEntity
// {
//     Name = "My parent entity"
// });
//
// await context.SaveChangesAsync();
//
// var parent = await context.Parents.FirstAsync(p => p.Name == "My parent entity");
//
// context.Children.AddRange(
//     new ChildEntity { Name = "children number one", ParentID = parent.ID },
//     new ChildEntity { Name = "children number two", ParentID = parent.ID },
//     new ChildEntity { Name = "children number three", ParentID = parent.ID }
// );
//
// await context.SaveChangesAsync();

var stopwatch = Stopwatch.StartNew();

var parent = await context
    .Parents
    .FirstAsync(p => p.Name == "My parent entity");

foreach (var child in parent.Children)
{
    Console.WriteLine(child.Name);
}

Console.WriteLine(stopwatch.ElapsedMilliseconds);
