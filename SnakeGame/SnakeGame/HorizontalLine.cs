/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 15:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Description of HorizontalLine.
	/// </summary>
	public class HorizontalLine
	{
		List<Point> pList;
		
		public HorizontalLine()
		{

		}
		
		public HorizontalLine(int xLeft,int xRight,int y,char symbol)
		{
			pList = new List<Point>();
			
			for (int x = xLeft; x <= xRight; x++) 
			{
				Point p = new Point(x,y,symbol);
				pList.Add(p);
			}
		}
		
		public void DrawLine()
		{
			foreach (Point p in pList) 
			{
				p.DrawPoint();
			}
		}
	}
}
