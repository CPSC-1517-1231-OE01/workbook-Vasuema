using Hockey.Data;
using Utils;


Console.WriteLine("Welcome to the Hockey Player Test App");

//default
HockeyPlayer player1 = new HockeyPlayer();
player1.FirstName = "Steward";
player1.LastName = "Skinner";

// object - initializer
HockeyPlayer player2 = new HockeyPlayer()
{
    FirstName = "Conner",
    LastName = "Brown",
};

//greedy
HockeyPlayer player3 = new HockeyPlayer("Bobby", "Orr", "Paary Sound, ON", new DateOnly(1948, 3, 20), 196, 73, Position.Defense, Shot.Right);

//output things about the players
Console.WriteLine($"The players name is {player1.FirstName} {player1.LastName} and are born {player1.DateOfBirth}");
Console.WriteLine($"The players name is {player2.FirstName} {player2.LastName} and are born {player2.DateOfBirth}");
Console.WriteLine($"The players name is {player3.FirstName} {player3.LastName} and are born {player3.DateOfBirth}");
