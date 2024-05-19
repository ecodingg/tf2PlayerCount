using System;
using System.Linq;
using System.IO;

class TF2DataDepiction
{
    static void Main(string[] args)
	{
		Console.WriteLine("This is the TF2 Data presented by ZestyJesus & Mega Scatter Bomb using statistics");

		List<int> playerNumbers = new List<int>();
		string filePath = "C:\\Users\\rexer\\Documents\\GitHub\\tf2PlayerCount\\steam_api_data.csv";

		Console.WriteLine("Adding all of the data to a List");
		using (var reader = new StreamReader(filePath))
		{
			while(!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				var values = line.Split(',');

                foreach (var value in values)
				{
					playerNumbers.Add(int.Parse(values[1]));
				}
			}
			Console.WriteLine("Average Number of Players: " + playerNumbers.Average());
		}

    }
}
