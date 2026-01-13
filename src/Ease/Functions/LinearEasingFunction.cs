namespace Ease.Functions
{
	public class LinearEasingFunction : EasingFunction
	{
		public LinearEasingFunction() : base(Easing.None, EasingMode.InOut)
		{

		}

		public override double Interpolate(double time)
		{
			return time;
		}
	}
}
