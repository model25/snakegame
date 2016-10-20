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
			int x1 = 1;
			int y1 = 3;
			char symbol1 = '*';
			
		    int x2 = 4;
			int y2 = 5;
			char symbol2 = '#';			
			Console.Write("Hello to SnakeGame !!!");
			

			// TODO: Implement Functionality Here
			
			DrawSymbol(x1,y1,symbol1);
			DrawSymbol(x2,y2,symbol2);
			
			Console.ReadKey(true);
		}
		
		static void DrawSymbol(int x,int y,char symbol)
		{
			Console.SetCursorPosition(x,y);
			Console.Write(symbol);
		}
	}
}