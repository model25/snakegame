/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SnakeGame
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			Console.Write("Hello to SnakeGame !!!");
			
			Point p1 = new Point(1,3,'*');
			Point p2 = new Point(3,5,'#');
			
	/*		
			p1.x = 1;
			p1.y = 3;
			p1.symbol = '*';
			
			
			p2.x = 3;
			p2.y = 5;
			p2.symbol = '#';
			
	*/		
			p1.DrawPoint();
			p2.DrawPoint();
			
			// TODO: Implement Functionality Here

			Console.ReadKey(true);
		}

	}
}