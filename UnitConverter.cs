using system;

    /// <summary>
    /// Class for unit conversion
    /// </summary>
    public static class UnitConverter
    {
        /// <summary>
        /// Converts the specified from unit.
        /// </summary>
        /// <param name="fromUnit">From unit.</param>
        /// <param name="value">The value.</param>
        /// <param name="toUnit">To unit.</param>
        /// <param name="fractional">The fractional.</param>
        /// <returns></returns>
        public static double Convert(UnitType fromUnit, double value, UnitType toUnit, int fractional)
        {
            double result = UnitConvert(ref fromUnit, ref value, ref toUnit);
            return Math.Round(result, fractional);
        }

        /// <summary>
        /// Units the convert.
        /// </summary>
        /// <param name="fromUnit">From unit.</param>
        /// <param name="value">The value.</param>
        /// <param name="toUnit">To unit.</param>
        /// <returns></returns>
        private static double UnitConvert(ref UnitType fromUnit, ref double value, ref UnitType toUnit)
        {
            double result = 0.0; ;

            switch (fromUnit)
            {
                case UnitType.Inch:
                    switch (toUnit)
                    {
                        case UnitType.Centimeter:
                            {
                                result = value * 2.54;
                                break;
                            }
                        case UnitType.Inch:
                            {
                                result = value;
                                break;
                            }
                        case UnitType.Millimeter:
                            {
                                result = value * 25.4;
                                break;
                            }
                        case UnitType.Dpi:
                            {
                                result = value * 96.0;
                                break;
                            }
                    }
                    break;
                case UnitType.Millimeter:
                    switch (toUnit)
                    {
                        case UnitType.Centimeter:
                            {
                                result = value * 0.1;
                                break;
                            }
                        case UnitType.Inch:
                            {
                                result = value * 0.0393700787;
                                break;
                            }
                        case UnitType.Millimeter:
                            {
                                result = value;
                                break;
                            }
                        case UnitType.Dpi:
                            {
                                result = value * 0.0393700787 * 96.0;
                                break;
                            }
                    }
                    break;
                case UnitType.Centimeter:
                    switch (toUnit)
                    {
                        case UnitType.Centimeter:
                            {
                                result = value;
                                break;
                            }
                        case UnitType.Inch:
                            {
                                result = value * 0.393700787;
                                break;
                            }
                        case UnitType.Millimeter:
                            {
                                result = value * 10.0;
                                break;
                            }
                        case UnitType.Dpi:
                            {
                                result = value * 0.393700787 * 96;
                                break;
                            }
                    }
                    break;
                case UnitType.Dpi:
                    switch (toUnit)
                    {
                        case UnitType.Centimeter:
                            {
                                result = value / 96.0 * 2.54;
                                break;
                            }
                        case UnitType.Inch:
                            {
                                result = value / 96.0;
                                break;
                            }
                        case UnitType.Millimeter:
                            {
                                result = value / 96.0 * 25.4;
                                break;
                            }
                        case UnitType.Dpi:
                            {
                                result = value;
                                break;
                            }
                    }
                    break;
            }

            return result;
        }
    }

    /// <summary>
    /// UnitType Enum
    /// </summary>
    public enum UnitType
    {
        Inch,
        Centimeter,
        Millimeter,
        Dpi
    }