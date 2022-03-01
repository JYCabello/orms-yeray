// See https://aka.ms/new-console-template for more information

using System.Reflection;
using DbUp;

var connectionString =
    args.Length > 0
        ? args[0]
        : "Server=localhost;Database=dapperisfun;User Id=sa;Password=abcd1234ABCD;";

var upgrader =
    DeployChanges
        .To
        .SqlDatabase(connectionString)
        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
        .LogToConsole()
        .Build();

upgrader.PerformUpgrade();
