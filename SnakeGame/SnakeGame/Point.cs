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
			//
		}
	}
}
