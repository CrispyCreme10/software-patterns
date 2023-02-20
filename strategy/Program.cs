using Strategy;

var simpleDuck = DuckFactory.CreateSimpleDuck();

var extremeDuck = DuckFactory.CreateExtremeDuck();

System.Console.WriteLine($"Simple Duck has:");
simpleDuck.Execute();

System.Console.WriteLine($"Extreme Duck has:");
extremeDuck.Execute();