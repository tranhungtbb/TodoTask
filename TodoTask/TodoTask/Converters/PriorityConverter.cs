using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TodoTask.Consts;
using Xamarin.Forms;

namespace TodoTask.Converters
{
    public class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = new System.Drawing.Color();

            switch ((EnumPriority)value)
            {
                case EnumPriority.Hight:
                    color = Color.FromHex("#FA3E23");

                    break;
                case EnumPriority.Medium:
                    color = Color.FromHex("#FBD242");
                    break;
                case EnumPriority.Low:
                    color = Color.FromHex("#3EAE8F");
                    break;
                default:
                    color = Color.FromHex("#FA3E23");
                    break;
            }
            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
