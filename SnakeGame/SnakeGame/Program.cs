/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SnakeGame
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.SetBufferSize(100,100);
			
			List<int> numlist = new List<int>();
			
			Console.Write("Hello to SnakeGame !!!");
			
			Point p1 = new Point(1,3,'*');
			Point p2 = new Point(3,5,'#');
				
			p1.DrawPoint();
			p2.DrawPoint();
			
			HorizontalLine pxline = new HorizontalLine(5,20,8,'-');
			pxline.DrawLine();
			
			
			VerticalLine pyline = new VerticalLine(5,8,30,'|');
			pyline.DrawLine();
			// TODO: Implement Functionality Here
			
			Point p = new Point(4,5,'*');
			Snake snake = new Snake(p, 10, Direction.RIGHT);
			snake.DrawLine();
			Console.ReadKey(true);
		}

	}
}