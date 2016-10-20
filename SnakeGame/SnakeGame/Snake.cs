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
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
	/// <summary>
	/// Description of Snake.
	/// </summary>
	public class Snake : Figure
	{
		public Direction dir;
		
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
		
		internal void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head  = GetNextPoint();
			pList.Add(head);
			
			tail.Clear();
			head.DrawPoint();
		}
		
		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1,dir);
			return nextPoint;
		}
	}
}
