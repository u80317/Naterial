using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Naterial.Controls
{
    /// <summary>
    /// Represents the converter that converts the element dimensions to <see cref="Geometry" />
    /// of the clipping shape.
    /// </summary>
    public sealed class ShapeClipConverter : IMultiValueConverter
    {
        /// <summary>
        /// Represents instance of converter that provides access from XAML.
        /// </summary>
        public static IMultiValueConverter Default { get; } = new ShapeClipConverter();


        /// <summary>
        /// Converts the element dimensions to <see cref="Geometry" /> of the clipping shape.
        /// </summary>
        /// <param name="values">
        /// The <see cref="FrameworkElement.ActualWidth" />, <see cref="FrameworkElement.ActualHeight" />
        /// and <see cref="CornerRadius" />.
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
        /// The <see cref="Geometry" /> of the clipping shape.
        /// </returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 3 && values[0] is double width &&
                                      values[1] is double height &&
                                      values[2] is CornerRadius radius)
            {
                var rectangle = new RectangleGeometry(
                    new Rect(0, 0, width, height), radius.TopLeft, radius.TopLeft
                );
                rectangle.Freeze();

                return rectangle;
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
