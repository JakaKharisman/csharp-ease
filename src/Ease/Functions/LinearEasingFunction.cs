namespace Ease.Functions
{
	public class LinearEasingFunction : EasingFunction
	{
		public LinearEasingFunction() : base(EasingMode.InOut)
		{

		}

		public override double Interpolate(double time)
		{
			return time;
		}
	}
}
