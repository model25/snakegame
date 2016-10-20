/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Description of VerticalLine.
	/// </summary>
	public class VerticalLine : Figure
	{

		
		public VerticalLine()
		{
		}
		
		public VerticalLine(int x, int yStart, int yEnd, char symbol)
		{
			pList = new List<Point>();
			
			for (int y = yStart; y <= yEnd; y++) 
			{
				Point p = new Point(x,y,symbol);
				pList.Add(p);					
			}
		}
		
	}
}
