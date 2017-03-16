using System;
using System.Globalization;
using Xamarin.Forms;

namespace ShowDataBinding.ValueConverters {
	class CountToCapacityConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			// value is the bound data
			// targetType is the expected data type
			String capacityText = "Slots available";
			double currentValue = (double)value;
			if (currentValue > 16.0)
			{
				capacityText = "Sold Out";
			}
			else if (currentValue > 10.0)
			{
				capacityText = "Nearly Full";
			}

			return capacityText;

		}

		public object ConvertBack(object value, Type targetType, object parameter, 
															CultureInfo culture) {
			throw new NotImplementedException();


		}

	}
}
