using System;

using UIKit;

namespace TipCalcCSharp
{
	public partial class ViewController : UIViewController
	{
		double currentValue = 0.0;
		double subTotal = 0.0;
		double calcTip = 0.0;
		int guestNum = 1;
		double guestAmt = 0.0;
		double totalAmt = 0.0;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			tipStepper.Wraps = true;
			tipStepper.AutoRepeat = true;
			tipPercent.Text = "20";
			currentValue = Convert.ToDouble (tipPercent.Text);
			tipStepper.Value = currentValue;
			billAmount.BecomeFirstResponder ();

			// Tap gesture
			this.View.AddGestureRecognizer(new UITapGestureRecognizer(tap => 
				{
					billAmount.ResignFirstResponder();
					guestNumber.ResignFirstResponder();
				}) 
				{ 
					NumberOfTapsRequired = 1 // Double tap 
				});
		}

		partial void stepperChanged (UIStepper sender)
		{
			tipPercent.Text = sender.Value.ToString();
			currentValue = sender.Value;

			if (billAmount.Text != null && tipPercent.Text != null)
			{
				DisplayResult();
			}
		}	

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void CheckGuestCount (UITextField sender)
		{
			if (guestNumber.Text != "" && guestNumber.Text != "" &&  Convert.ToInt32(guestNumber.Text) != 0)
			{
				guestNum = Convert.ToInt32(guestNumber.Text);
			}
			else
			{
				guestNumber.Text = "1";
				guestNum = 1;
			}

			DisplayResult();
		}

		partial void CalculateTip (UITextField sender)
		{
			if (billAmount.Text != "" && tipPercent.Text != "")
			{
				if (billAmount.Text.Contains("$"))
				{
					subTotal = Convert.ToDouble(billAmount.Text.Split('$')[1]);
				}
				else
				{
					subTotal = Convert.ToDouble(billAmount.Text);
				}

				subTotal = Convert.ToDouble(Math.Round(100*subTotal)/100);

				string formatedSubTotal = string.Format("{0:0.00}", subTotal);
				billAmount.Text = string.Format("${0}", formatedSubTotal);

				DisplayResult();
			}
		}

		private void DisplayResult()
		{
			calcTip = subTotal * (currentValue / 100);

			totalAmt = calcTip + subTotal;

			guestAmt = totalAmt / Convert.ToDouble (guestNum);

			tipAmount.Text = string.Format ("${0:0.00}", calcTip);

			guestAmount.Text = string.Format("${0:0.00}", guestAmt);

			totalAmount.Text = string.Format ("${0:0.00}", totalAmt);
		}
	}
}

