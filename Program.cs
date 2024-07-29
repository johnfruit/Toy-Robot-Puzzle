using System;
using Toybot;

namespace SimpleToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new RobotSimulator();
            var table = new BotTable();

            while (true)
            {
                var command = Console.ReadLine().ToUpper();
                if (command == null) break;

                var parts = command.Split(' ');

                switch (parts[0])
                {
                    case "PLACE":
                        if (parts.Length == 2)
                        {
                            var position = parts[1].Split(',');
                            if (position.Length == 3 &&
                                int.TryParse(position[0], out int x) &&
                                int.TryParse(position[1], out int y) &&
                                Enum.TryParse(position[2], out Direction facing) &&
                                table.IsValidPosition(x, y))
                            {
                                robot.Place(x, y, facing);
                            }
                        }
                        break;

                    case "MOVE":
                        robot.Move();
                        break;

                    case "LEFT":
                        robot.Left();
                        break;

                    case "RIGHT":
                        robot.Right();
                        break;

                    case "REPORT":
                        robot.Report();
                        break;
                }
            }
        }
    }
}
