using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace PInterfaces
{
	public class UIAutoView : UIScrollView
	{
		List<UIView> autoViews = new List<UIView>();

		public UIAutoView (RectangleF frame) : base(frame){

		}

		public virtual void AddAutoview(UIView autoView){
			autoViews.Add (autoView);
			AddSubview (autoView);
			RecalculateLayout ();
		}

		public void AddAutoviews(params UIView[] autoViews){
			foreach (var v in autoViews) {
				this.autoViews.Add (v);
				AddSubview (v);
			}

			RecalculateLayout ();
		}

		public virtual void Clear(){
			foreach (UIView v in autoViews)
				v.RemoveFromSuperview ();

			autoViews.Clear ();
		}

		public void RemoveAutoview(UIView view){
			if (!autoViews.Contains (view))
				return;

			autoViews.Remove (view);
			view.RemoveFromSuperview ();
			RecalculateLayout ();
		}

		void RecalculateLayout(){
			float length = 0;

			for (int i = 0; i < autoViews.Count; i++) {
				autoViews [i].Frame = new RectangleF (
					autoViews [i].Frame.Left, 
					length, 
					autoViews [i].Frame.Width, 
					autoViews [i].Frame.Height
				);
				length += autoViews [i].Frame.Height;
			}

			ContentSize = new SizeF (Frame.Width, length);
		}
	}
}
	