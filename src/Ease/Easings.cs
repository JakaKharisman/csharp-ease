using Ease.Functions;

namespace Ease
{
	/// <summary>
	/// A utility class to simplify calling easing interpolation without the need of <see cref="Easing"/> and <see cref="EasingMode"/>
	/// </summary>
	/// <remarks>
	/// Each functions defined here can be called directly using implemented <see cref="EasingFunction"/> class
	/// <br>
	/// For example, <see cref="InQuad"/> is equivalent to <see cref="QuadEasingFunction.In"/>
	/// </br>
	/// </remarks>
	public static class Easings
	{
		#region Quad
		public static double InQuad(double time)
		{
			return QuadEasingFunction.In(time);
		}

		public static double OutQuad(double time)
		{
			return QuadEasingFunction.Out(time);
		}

		public static double InOutQuad(double time)
		{
			return QuadEasingFunction.InOut(time);
		}

		public static float InQuadF(float time)
		{
			return (float)QuadEasingFunction.In(time);
		}

		public static float OutQuadF(float time)
		{
			return (float)QuadEasingFunction.Out(time);
		}

		public static float InOutQuadF(float time)
		{
			return (float)QuadEasingFunction.InOut(time);
		}
		#endregion

		#region Sine
		public static double InSine(double time)
		{
			return SineEasingFunction.In(time);
		}

		public static double OutSine(double time)
		{
			return SineEasingFunction.Out(time);
		}

		public static double InOutSine(double time)
		{
			return SineEasingFunction.InOut(time);
		}

		public static float InSineF(float time)
		{
			return (float)SineEasingFunction.In(time);
		}

		public static float OutSineF(float time)
		{
			return (float)SineEasingFunction.Out(time);
		}

		public static float InOutSineF(float time)
		{
			return (float)SineEasingFunction.InOut(time);
		}
		#endregion

		#region Cubic
		public static double InCubic(double time)
		{
			return CubicEasingFunction.In(time);
		}

		public static double OutCubic(double time)
		{
			return CubicEasingFunction.Out(time);
		}

		public static double InOutCubic(double time)
		{
			return CubicEasingFunction.InOut(time);
		}

		public static float InCubicF(float time)
		{
			return (float)CubicEasingFunction.In(time);
		}

		public static float OutCubicF(float time)
		{
			return (float)CubicEasingFunction.Out(time);
		}

		public static float InOutCubicF(float time)
		{
			return (float)CubicEasingFunction.InOut(time);
		}
		#endregion

		#region Quart
		public static double InQuart(double time)
		{
			return QuartEasingFunction.In(time);
		}

		public static double OutQuart(double time)
		{
			return QuartEasingFunction.Out(time);
		}

		public static double InOutQuart(double time)
		{
			return QuartEasingFunction.InOut(time);
		}

		public static float InQuartF(float time)
		{
			return (float)QuartEasingFunction.In(time);
		}

		public static float OutQuartF(float time)
		{
			return (float)QuartEasingFunction.Out(time);
		}

		public static float InOutQuartF(float time)
		{
			return (float)QuartEasingFunction.InOut(time);
		}
		#endregion

		#region Quint
		public static double InQuint(double time)
		{
			return QuintEasingFunction.In(time);
		}

		public static double OutQuint(double time)
		{
			return QuintEasingFunction.Out(time);
		}

		public static double InOutQuint(double time)
		{
			return QuintEasingFunction.InOut(time);
		}

		public static float InQuintF(float time)
		{
			return (float)QuintEasingFunction.In(time);
		}

		public static float OutQuintF(float time)
		{
			return (float)QuintEasingFunction.Out(time);
		}

		public static float InOutQuintF(float time)
		{
			return (float)QuintEasingFunction.InOut(time);
		}
		#endregion

		#region Expo
		public static double InExpo(double time)
		{
			return ExpoEasingFunction.In(time);
		}

		public static double OutExpo(double time)
		{
			return ExpoEasingFunction.Out(time);
		}

		public static double InOutExpo(double time)
		{
			return ExpoEasingFunction.InOut(time);
		}

		public static float InExpoF(float time)
		{
			return (float)ExpoEasingFunction.In(time);
		}

		public static float OutExpoF(float time)
		{
			return (float)ExpoEasingFunction.Out(time);
		}

		public static float InOutExpoF(float time)
		{
			return (float)ExpoEasingFunction.InOut(time);
		}
		#endregion

		#region Circ
		public static double InCirc(double time)
		{
			return CircEasingFunction.In(time);
		}

		public static double OutCirc(double time)
		{
			return CircEasingFunction.Out(time);
		}

		public static double InOutCirc(double time)
		{
			return CircEasingFunction.InOut(time);
		}

		public static float InCircF(float time)
		{
			return (float)CircEasingFunction.In(time);
		}

		public static float OutCircF(float time)
		{
			return (float)CircEasingFunction.Out(time);
		}

		public static float InOutCircF(float time)
		{
			return (float)CircEasingFunction.InOut(time);
		}
		#endregion

		#region Back
		public static double InBack(double time)
		{
			return BackEasingFunction.In(time);
		}

		public static double OutBack(double time)
		{
			return BackEasingFunction.Out(time);
		}

		public static double InOutBack(double time)
		{
			return BackEasingFunction.InOut(time);
		}

		public static float InBackF(float time)
		{
			return (float)BackEasingFunction.In(time);
		}

		public static float OutBackF(float time)
		{
			return (float)BackEasingFunction.Out(time);
		}

		public static float InOutBackF(float time)
		{
			return (float)BackEasingFunction.InOut(time);
		}
		#endregion

		#region Elastic
		public static double InElastic(double time)
		{
			return ElasticEasingFunction.In(time);
		}

		public static double OutElastic(double time)
		{
			return ElasticEasingFunction.Out(time);
		}

		public static double InOutElastic(double time)
		{
			return ElasticEasingFunction.InOut(time);
		}

		public static float InElasticF(float time)
		{
			return (float)ElasticEasingFunction.In(time);
		}

		public static float OutElasticF(float time)
		{
			return (float)ElasticEasingFunction.Out(time);
		}

		public static float InOutElasticF(float time)
		{
			return (float)ElasticEasingFunction.InOut(time);
		}
		#endregion

		#region Bounce
		public static double InBounce(double time)
		{
			return BounceEasingFunction.In(time);
		}

		public static double OutBounce(double time)
		{
			return BounceEasingFunction.Out(time);
		}

		public static double InOutBounce(double time)
		{
			return BounceEasingFunction.InOut(time);
		}

		public static float InBounceF(float time)
		{
			return (float)BounceEasingFunction.In(time);
		}

		public static float OutBounceF(float time)
		{
			return (float)BounceEasingFunction.Out(time);
		}

		public static float InOutBounceF(float time)
		{
			return (float)BounceEasingFunction.InOut(time);
		}
		#endregion
	}
}
