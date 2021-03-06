using System;
using Formulaic.Maths;

namespace Formulaic.Finance
{

    public static class CompoundDepreciation
    {
        //Calculate final value using compound depreciation
        public static double CalculateFinalValue(double principalValue, double interest, double years)
        {
            return principalValue * Math.Pow((1 - (interest / 100.0)), years);
        }

        //Calculate principal value using compound depreciation
        public static double CalculatePrincipalValue(double finalValue, double interest, double years)
        {
            return finalValue / Math.Pow((1 - (interest / 100.0)), years);
        }

        //Calculate depreciation using compound depreciation
        public static double CalculateDepreciation(double principalValue, double finalValue, double years)
        {
            return (MathExt.Root((finalValue / principalValue), years) - 1) * (-1) * 100.0;
        }

        //Calculate year timeframe using compound depreciation
        public static double CalculateYears(double principalValue, double finalValue, double interest)
        {
            return Math.Log10(finalValue / principalValue) / Math.Log10(1 - (interest / 100.0));
        }
    }
}
