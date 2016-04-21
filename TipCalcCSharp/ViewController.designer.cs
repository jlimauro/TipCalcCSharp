// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipCalcCSharp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField billAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel guestAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField guestNumber { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel tipAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel tipPercent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper tipStepper { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel totalAmount { get; set; }

		[Action ("CalculateTip:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CalculateTip (UITextField sender);

		[Action ("CheckGuestCount:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CheckGuestCount (UITextField sender);

		[Action ("stepperChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void stepperChanged (UIStepper sender);

		void ReleaseDesignerOutlets ()
		{
			if (billAmount != null) {
				billAmount.Dispose ();
				billAmount = null;
			}
			if (guestAmount != null) {
				guestAmount.Dispose ();
				guestAmount = null;
			}
			if (guestNumber != null) {
				guestNumber.Dispose ();
				guestNumber = null;
			}
			if (tipAmount != null) {
				tipAmount.Dispose ();
				tipAmount = null;
			}
			if (tipPercent != null) {
				tipPercent.Dispose ();
				tipPercent = null;
			}
			if (tipStepper != null) {
				tipStepper.Dispose ();
				tipStepper = null;
			}
			if (totalAmount != null) {
				totalAmount.Dispose ();
				totalAmount = null;
			}
		}
	}
}
