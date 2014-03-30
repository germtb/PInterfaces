using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public static class Utils
	{
		public static RectangleF InsetRect(RectangleF rect, UIEdgeInsets insets){
			return new RectangleF(
				rect.X + insets.Left,
				rect.Y + insets.Top,
				rect.Width - insets.Left - insets.Right,
				rect.Height - insets.Top - insets.Bottom
			);
		}
	}
}

