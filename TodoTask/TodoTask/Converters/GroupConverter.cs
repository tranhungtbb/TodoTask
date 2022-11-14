using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TodoTask.Consts;
using Xamarin.Forms;


namespace TodoTask.Converters
{
    public class GroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null) return false;
            switch ((EnumTaskGroup)value)
            {
                case EnumTaskGroup.Today:
                    return true;
                case EnumTaskGroup.Inbox:
                case EnumTaskGroup.Upcoming:
                    return false;
                default:
                    return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}


