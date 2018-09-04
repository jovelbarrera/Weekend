using System;
using Xamarin.Forms;

namespace Weekend.Controls
{
	public class CustomImage : Image
	{
		public static readonly BindableProperty BorderWidthProperty =
			BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(CustomImage), 0f);
		public float BorderWidth
		{
			get { return (float)GetValue(BorderWidthProperty); }
			set { SetValue(BorderWidthProperty, value); }
		}

		public static readonly BindableProperty BorderColorProperty =
			BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomImage), Color.Transparent);
		public Color BorderColor
		{
			get { return (Color)GetValue(BorderColorProperty); }
			set { SetValue(BorderColorProperty, value); }
		}

		public static readonly BindableProperty BorderRadiusProperty =
			BindableProperty.Create(nameof(BorderRadius), typeof(float), typeof(CustomImage), 0f);
		public float BorderRadius
		{
			get { return (float)GetValue(BorderRadiusProperty); }
			set { SetValue(BorderRadiusProperty, value); }
		}
	}
}


