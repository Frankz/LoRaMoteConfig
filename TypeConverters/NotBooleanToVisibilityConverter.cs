﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoRaMoteConfig.TypeConverters
{
	public class NotBooleanToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
				return ((bool)value ? Visibility.Collapsed : Visibility.Visible);
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
				return ((bool)value ? Visibility.Collapsed : Visibility.Visible);
			return value;
		}
	}
}
