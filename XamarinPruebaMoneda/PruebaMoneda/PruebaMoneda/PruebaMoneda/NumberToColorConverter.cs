using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace PruebaMoneda
{
	public class NumberToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string color = "";
			int colorNumber = (int)value;

			switch (colorNumber)
			{
				case 1:
					color = "#ed0707";
					break;

				case 2:
					color = "#34db25";
					break;

				case 3:
					color = "#fcd46d";
					break;

				case 4:
					color = "#2e15eb";
					break;

				case 5:
					color = "#0ff2e3";
					break;

				default:
					color = "#000000";
					break;
			}

			return color;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}


}
