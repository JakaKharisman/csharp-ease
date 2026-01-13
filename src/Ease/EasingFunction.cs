namespace Ease
{
	public abstract class EasingFunction : IEasingFunction
	{
		public Easing Easing { get; }
		public EasingMode Mode { get; set; }

		public EasingFunction(Easing easing, EasingMode mode)
		{
			Easing = easing;
			Mode = mode;
		}

		public abstract double Interpolate(double time);
	}
}
