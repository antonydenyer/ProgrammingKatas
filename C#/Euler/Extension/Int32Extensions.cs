namespace SevenDigital.Kata.Euler.Problems.Extension
{
	public static class Int32Extensions
	{
		public static bool IsDivisibleBy(this int number, int divisibleBy)
		{
			return number % divisibleBy == 0;
		}
	}
}
