using System.Windows;
using System.Windows.Data;

namespace Naterial.Controls
{
    /// <summary>
    /// Represents the attached properties for setting the <see cref="CornerRadius" /> of an element.
    /// </summary>
    public sealed class ShapeAssist
    {
        #region Attached Property: CornerRadius
        /// <summary>
        /// Identifies the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ShapeAssist),
            new PropertyMetadata(new CornerRadius(0))
        );


        /// <summary>
        /// Gets the value of the <see cref="ShapeAssist" />.CornerRadius attached property
        /// from a given <see cref="FrameworkElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </returns>
        public static CornerRadius GetCornerRadius(FrameworkElement element)
            => (CornerRadius)element.GetValue(CornerRadiusProperty);

        /// <summary>
        /// Sets the value of the <see cref="ShapeAssist" />.CornerRadius attached property
        /// to a given <see cref="DependencyObject" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetCornerRadius(FrameworkElement element, CornerRadius value)
            => element.SetValue(CornerRadiusProperty, value);
        #endregion
    }
}
