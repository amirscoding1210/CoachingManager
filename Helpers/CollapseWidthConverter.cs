using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CoachingCenterApp.Helpers
{
    public class CollapseWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 70 : 220; // Collapsed: 70px, Expanded: 220px
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}