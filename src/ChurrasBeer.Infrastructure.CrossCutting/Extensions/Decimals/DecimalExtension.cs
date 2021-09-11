namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.Decimals
{
    public static class DecimalExtension
    {
        public static bool IsBetween(this decimal? value, decimal minValue, decimal maxValue)
        {
            if (value == null)
                return false;

            return value.Value.IsBetween(minValue, maxValue);
        }

        public static bool IsBetween(this decimal value, decimal minValue, decimal maxValue)
        {
            return value >= minValue && value <= maxValue;
        }
    }
}
