using System;
using Android.Content;
using Android.Graphics;
using Weekend.Controls;
using Weekend.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(DroidCustomBoxView))]
namespace Weekend.Droid.Renderers
{
	public class DroidCustomBoxView : BoxRenderer
	{
		private Context _currentContext;

		public DroidCustomBoxView(Context context) : base(context)
		{
			_currentContext = context;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null)
			{
				if ((int)Android.OS.Build.VERSION.SdkInt < 21)
					SetLayerType(Android.Views.LayerType.Software, null);
			}
		}

		public override void Draw(Canvas canvas)
		{
			try
			{
				var logicalDensity = _currentContext.Resources.DisplayMetrics.Density;

				var radius = ((CustomBoxView)Element).BorderRadius * logicalDensity;
				var borderThickness = ((CustomBoxView)Element).BorderWidth;
				float strokeWidth = 0f;

				if (borderThickness > 0)
				{
					strokeWidth = (float)Math.Ceiling(borderThickness * logicalDensity + .5f);
				}
				radius -= strokeWidth / 2f;

				var path = new Path();
				path.AddRoundRect(new RectF(0, 0, Width - strokeWidth * 2, Height - strokeWidth * 2), radius, radius, Path.Direction.Ccw);

				canvas.Save();
				canvas.ClipPath(path);

				var paint = new Paint
				{
					AntiAlias = true
				};
				paint.SetStyle(Paint.Style.Fill);
				paint.Color = ((CustomBoxView)Element).BackgroundColor.ToAndroid();
				canvas.DrawPath(path, paint);
				paint.Dispose();

				path.Dispose();
				canvas.Restore();

				path = new Path();
				path.AddRoundRect(new RectF(0, 0, Width - strokeWidth * 2, Height - strokeWidth * 2), radius, radius, Path.Direction.Ccw);

				if (strokeWidth > 0.0f)
				{
					paint = new Paint();
					paint.AntiAlias = true;
					paint.StrokeWidth = strokeWidth;
					paint.SetStyle(Paint.Style.Stroke);
					paint.Color = ((CustomBoxView)Element).BorderColor.ToAndroid();
					canvas.DrawPath(path, paint);
					paint.Dispose();
				}

				path.Dispose();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Unable to create circle image: " + ex);
			}
		}
	}
}

