using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace AvaloniaMvvmAppUI.Converters
{
    public class NullableByteStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                byte? valueAsNullableBye = value as byte?;
                if (valueAsNullableBye == null)
                {
                    return string.Empty;
                }

                return valueAsNullableBye.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueAsString = value as string;
            if (valueAsString == null)
            {
                return (byte?)null;
            }

            byte convertedValue;
            if (byte.TryParse(valueAsString, out convertedValue))
            {
                return convertedValue;
            }

            return (byte?)null;
        }
    }
}
