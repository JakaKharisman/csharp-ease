using Ease.Functions;

namespace Ease
{
	public static class EasingExtensions
	{
		public static IEasingFunction ToFunction(this Easing easing, EasingMode mode = EasingMode.InOut)
		{
			return easing switch
			{
				Easing.Quad => new QuadEasingFunction(mode),
				Easing.Sine => new SineEasingFunction(mode),
				Easing.Cubic => new CubicEasingFunction(mode),
				Easing.Quart => new QuartEasingFunction(mode),
				Easing.Quint => new QuintEasingFunction(mode),
				Easing.Expo => new ExpoEasingFunction(mode),
				Easing.Circ => new CircEasingFunction(mode),
				Easing.Back => new BackEasingFunction(mode),
				Easing.Elastic => new ElasticEasingFunction(mode),
				Easing.Bounce => new BounceEasingFunction(mode),
				_ => new LinearEasingFunction()
			};
		}
		
		public static double Interpolate(this Easing easing, EasingMode mode, double time)
		{
			// alternatively, you can use the following for shorter code.
			// return ToFunction(easing, mode).Interpolate(time);
			// however, it would likely introduce overhead
			// since the it creates new instance of EasingFunction
			switch (easing)
			{
				case Easing.Quad:
					switch (mode)
					{
						case EasingMode.In:
							return QuadEasingFunction.In(time);
						case EasingMode.Out:
							return QuadEasingFunction.Out(time);
						case EasingMode.InOut:
							return QuadEasingFunction.InOut(time);
					}
					break;
				case Easing.Sine:
					switch (mode)
					{
						case EasingMode.In:
							return SineEasingFunction.In(time);
						case EasingMode.Out:
							return SineEasingFunction.Out(time);
						case EasingMode.InOut:
							return SineEasingFunction.InOut(time);
					}
					break;
				case Easing.Cubic:
					switch (mode)
					{
						case EasingMode.In:
							return CubicEasingFunction.In(time);
						case EasingMode.Out:
							return CubicEasingFunction.Out(time);
						case EasingMode.InOut:
							return CubicEasingFunction.InOut(time);
					}
					break;
				case Easing.Quart:
					switch (mode)
					{
						case EasingMode.In:
							return QuartEasingFunction.In(time);
						case EasingMode.Out:
							return QuartEasingFunction.Out(time);
						case EasingMode.InOut:
							return QuartEasingFunction.InOut(time);
					}
					break;
				case Easing.Quint:
					switch (mode)
					{
						case EasingMode.In:
							return QuintEasingFunction.In(time);
						case EasingMode.Out:
							return QuintEasingFunction.Out(time);
						case EasingMode.InOut:
							return QuintEasingFunction.InOut(time);
					}
					break;
				case Easing.Expo:
					switch (mode)
					{
						case EasingMode.In:
							return ExpoEasingFunction.In(time);
						case EasingMode.Out:
							return ExpoEasingFunction.Out(time);
						case EasingMode.InOut:
							return ExpoEasingFunction.InOut(time);
					}
					break;
				case Easing.Circ:
					switch (mode)
					{
						case EasingMode.In:
							return CircEasingFunction.In(time);
						case EasingMode.Out:
							return CircEasingFunction.Out(time);
						case EasingMode.InOut:
							return CircEasingFunction.InOut(time);
					}
					break;
				case Easing.Back:
					switch (mode)
					{
						case EasingMode.In:
							return BackEasingFunction.In(time);
						case EasingMode.Out:
							return BackEasingFunction.Out(time);
						case EasingMode.InOut:
							return BackEasingFunction.InOut(time);
					}
					break;
				case Easing.Elastic:
					switch (mode)
					{
						case EasingMode.In:
							return ElasticEasingFunction.In(time);
						case EasingMode.Out:
							return ElasticEasingFunction.Out(time);
						case EasingMode.InOut:
							return ElasticEasingFunction.InOut(time);
					}
					break;
				case Easing.Bounce:
					switch (mode)
					{
						case EasingMode.In:
							return BounceEasingFunction.In(time);
						case EasingMode.Out:
							return BounceEasingFunction.Out(time);
						case EasingMode.InOut:
							return BounceEasingFunction.InOut(time);
					}
					break;
			}
			return time;
		}

		public static float InterpolateF(this Easing easing, EasingMode mode, float time)
		{
			return (float)easing.Interpolate(mode, time);
		}

		public static double Interpolate(this Easing easing, double time)
		{
			return easing.Interpolate(EasingMode.InOut, time);
		}

		public static float InterpolateF(this Easing easing, float time)
		{
			return (float)easing.Interpolate(time);
		}
	}
}
