/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace SnakeGame
{
	/// <summary>
	/// Description of Point.
	/// </summary>
	public class Point
	{
		public int x;
		public int y;
		public char symbol;
		
		public void DrawPoint()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(symbol);			
		}
		
		public Point()
		{
			// конструктор по умолчанию
		}
		
		public Point(Point p)
		{
			// конструктор копирования
			x= p.x;
			y= p.y;
			symbol = p.symbol;
		}
				
		public Point(int _x, int _y, char _symbol)
		{
			this.x = _x;
			this.y = _y;
			this.symbol = _symbol;
		}
		
		public void Move(int offset, Direction dir)
		{
			if (dir == Direction.RIGHT) {
				x += offset;
			}
			else if(dir == Direction.LEFT)
			{
				x-= offset;
			}
			
			else if (dir == Direction.DOWN) {
				y+= offset;
			}
			
			else if(dir == Direction.UP)
			{
				y-= offset;
			}
		}
	}
}
