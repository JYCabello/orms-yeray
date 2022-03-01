// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;
using Dapper;
using FunWithDapper;

await using var connection = new SqlConnection("Server=localhost;Database=dapperisfun;User Id=sa;Password=abcd1234ABCD;");

var parent = await connection
    .QueryFirstAsync<ParentEntity>("SELECT * FROM Parents");

var children = await connection
    .QueryAsync<ChildEntity>(
        "SELECT * FROM Children WHERE ParentID = @parentID",
        new { ParentID = parent.ID }
    );

Console.WriteLine(parent.Name);

foreach (var child in children)
{
    Console.WriteLine(child.Name);
}
