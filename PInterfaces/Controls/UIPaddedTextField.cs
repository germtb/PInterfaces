using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class UIPaddedTextField : UITextField
	{
		public UIEdgeInsets EdgeInsets { get; set; }

		public UIPaddedTextField(RectangleF frame) : base(frame){

		}

		public override RectangleF TextRect(RectangleF forBounds){
			return base.TextRect(Utils.InsetRect(forBounds, EdgeInsets));
		}

		public override RectangleF EditingRect(RectangleF forBounds){
			return base.EditingRect(Utils.InsetRect(forBounds, EdgeInsets));
		}
	}
}

