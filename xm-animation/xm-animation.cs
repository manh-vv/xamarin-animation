using System;

using Xamarin.Forms;

namespace xmanimation
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = creatRootView()
			};
		}

		View creatRootView ()
		{
			Label _label = new Label {
				BackgroundColor = Color.White.WithSaturation(0.66),
				XAlign = TextAlignment.Center,
				Text = "Welcome to Xamarin Forms!",
				HeightRequest = 60
			};

			Entry _entry = new Entry {
				HeightRequest = 40,
				Keyboard = Keyboard.Numeric,
				Text = "180",
				TextColor = Color.White
			};

			Entry _entry2 = new Entry {
				HeightRequest = 40,
				Keyboard = Keyboard.Numeric,
				Text = "1",
				TextColor = Color.White
			};

			Entry _entry3 = new Entry {
				HeightRequest = 40,
				Keyboard = Keyboard.Numeric,
				Text = "10",
				TextColor = Color.White
			};

			TapGestureRecognizer t = new TapGestureRecognizer ();
			t.Tapped += (object sender, EventArgs e) => {
				System.Diagnostics.Debug.WriteLine("Enter animation by click on icon");

				Label l = (Label) sender;
				//l.RelRotateTo (30, 100, Easing.BounceIn);
				Easing easing = null;

				switch (Convert.ToInt16(_entry2.Text))
				{
				case 1:
					easing = Easing.BounceIn;
					break;
				case 2:
					easing = Easing.BounceOut;
					break;
				case 3:
					easing = Easing.CubicIn;
					break;
				case 4:
					easing = Easing.CubicInOut;
					break;
				case 5:
					easing = Easing.CubicOut;
					break;
				case 6:
					easing = Easing.Linear;
					break;
				case 7:
					easing = Easing.SinIn;
					break;
				case 8:
					easing = Easing.SinInOut;
					break;
				case 9:
					easing = Easing.SinOut;
					break;
				case 10:
					easing = Easing.SpringIn;
					break;
				case 11:
					easing = Easing.SpringOut;
					break;
				}


				l.RotateXTo(Convert.ToDouble(_entry.Text), Convert.ToUInt16(_entry3.Text), easing);

				if ("180".Equals(_entry.Text))
				{
					l.BackgroundColor = Color.Red.WithSaturation(0.4);
					_entry.Text = "0";
				}
				else 
				{
					l.BackgroundColor = Color.Pink.WithSaturation(0.6);
					_entry.Text = "180";
				}
			};

			_label.GestureRecognizers.Add (t);

			StackLayout stackLayout = new StackLayout {
				BackgroundColor = Color.FromHex("#696969"),
				Orientation = StackOrientation.Vertical,
				Spacing = 30,
				Padding = new Thickness(10),

				Children = {
					_label,
					_entry,
					_entry2,
					_entry3
				}
			};

			return stackLayout;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

