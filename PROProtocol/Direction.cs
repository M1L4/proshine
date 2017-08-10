﻿using System.Drawing;

namespace PROProtocol
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public static class DirectionExtensions
    {
        public static string AsChar(this Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return "u";
                case Direction.Down:
                    return "d";
                case Direction.Left:
                    return "l";
                case Direction.Right:
                    return "r";
            }
            return null;
        }

        public static Direction GetOpposite(this Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return Direction.Down;
                case Direction.Down:
                    return Direction.Up;
                case Direction.Left:
                    return Direction.Right;
                case Direction.Right:
                default:
                    return Direction.Left;
            }
        }

        public static void ApplyToCoordinates(this Direction direction, ref int x, ref int y)
        {
            switch (direction)
            {
                case Direction.Up:
                    y--;
                    break;
                case Direction.Down:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
            }
        }

		/// <summary>
		/// Generates the next point in moving direction.
		/// </summary>
		/// <param name="direction">The moving direction.</param>
		/// <param name="origin">The starting point.</param>
		/// <returns>New point after movement in direction was applied.</returns>
		public static Point ApplyToCoordinates(this Direction direction, Point origin)
		{
			int x = origin.X, y = origin.Y;
			switch (direction)
			{
				case Direction.Up:
					y--;
					break;
				case Direction.Down:
					y++;
					break;
				case Direction.Left:
					x--;
					break;
				case Direction.Right:
					x++;
					break;
			}

			return new Point(x, y);
		}


		public static Direction FromChar(char c)
        {
            switch (c)
            {
                case 'u':
                    return Direction.Up;
                case 'd':
                    return Direction.Down;
                case 'l':
                    return Direction.Left;
                case 'r':
                    return Direction.Right;
            }
            throw new System.Exception("The direction '" + c + "' does not exist");
        }
    }
}
