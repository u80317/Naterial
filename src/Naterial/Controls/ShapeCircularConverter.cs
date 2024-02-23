using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Naterial.Controls
{
    /// <summary>
    /// Represents the converter that converts the element dimensions to <see cref="CornerRadius" />
    /// of the circular shape.
    /// </summary>
    public sealed class ShapeCircularConverter : IMultiValueConverter
    {
        /// <summary>
        /// Represents instance of converter that provides access from XAML.
        /// </summary>
        public static IMultiValueConverter Default { get; } = new ShapeCircularConverter();


        /// <summary>
        /// Converts the element dimensions to <see cref="CornerRadius" /> of the circular shape.
        /// </summary>
        /// <param name="values">
        /// The <see cref="FrameworkElement.ActualWidth" /> and <see cref="FrameworkElement.ActualHeight" />.
        /// </param>
        /// <param name="targetType">
        /// This parameter is not used.
        /// </param>
        /// <param name="parameter">
        /// This parameter is not used.
        /// </param>
        /// <param name="culture">
        /// This parameter is not used.
        /// </param>
        /// <returns>
        /// The <see cref="CornerRadius" /> of the circular shape.
        /// </returns>
        /// <remarks>
        /// The <see cref="CornerRadius" /> is equal to value of element small side divided by 2.
        /// </remarks>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2 && values[0] is double width && values[1] is double height)
            {
                return new CornerRadius(Math.Min(width, height) / 2);
            }

            return DependencyProperty.UnsetValue;
        }

        /// <summary>
        /// Not Supported.
        /// </summary>
        /// <param name="value">
        /// This parameter is not used.
        /// </param>
        /// <param name="targetTypes">
        /// This parameter is not used.
        /// </param>
        /// <param name="parameter">
        /// This parameter is not used.
        /// </param>
        /// <param name="culture">
        /// This parameter is not used.
        /// </param>
        /// <exception cref="NotSupportedException">
        /// The method was called.
        /// </exception>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
