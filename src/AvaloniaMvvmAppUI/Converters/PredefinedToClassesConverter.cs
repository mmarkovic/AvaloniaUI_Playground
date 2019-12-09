namespace AvaloniaMvvmAppUI.Converters
{
    using System;
    using System.Globalization;
    using Avalonia.Data.Converters;

    public class PredefinedToClassesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            if((bool)value)
            {
                return "predefined";
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}