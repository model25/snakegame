/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20.10.2016
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Description of Figure.
	/// </summary>
	public class Figure
	{
		protected List<Point> pList;
		
		public Figure()
		{
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
