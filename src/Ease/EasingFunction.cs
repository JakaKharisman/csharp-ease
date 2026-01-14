namespace Ease
{
	public abstract class EasingFunction : IEasingFunction
	{
		public EasingMode Mode { get; set; }

		public EasingFunction(EasingMode mode)
		{
			Mode = mode;
		}

		public abstract double Interpolate(double time);
	}
}
