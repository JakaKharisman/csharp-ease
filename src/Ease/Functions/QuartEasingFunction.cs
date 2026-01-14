namespace Ease.Functions
{
	public class QuartEasingFunction : EasingFunction
	{
		public QuartEasingFunction(EasingMode mode) : base(Easing.Quart, mode)
		{

		}

		public override double Interpolate(double time)
		{
			return Mode switch
			{
				EasingMode.In => In(time),
				EasingMode.Out => Out(time),
				_ => InOut(time),
			};
		}

		public static double In(double time)
		{
			return time * time * time * time;
		}

		public static double Out(double time)
		{
			return 1 - In(1 - time);
		}

		public static double InOut(double time)
		{
			if (time < 0.5) return In(time * 2) * 0.5;
			return 1 - In((1 - time) * 2) * 0.5;
		}
	}
}
