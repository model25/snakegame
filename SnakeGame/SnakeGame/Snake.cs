/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Description of Snake.
	/// </summary>
	public class Snake : Figure
	{
		Direction dir;
		
		public Snake()
		{
		}
		
		public Snake(Point tail,int length, Direction _dir)
		{
			dir = _dir;
			pList = new List<Point>();
			
			for (int i = 0; i < length; i++) 
			{
				Point p = new Point(tail);
				p.Move(i,dir);
				pList.Add(p);
			}
		}
	}
}
