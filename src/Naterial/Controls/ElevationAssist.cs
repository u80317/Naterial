using System.Windows;

namespace Naterial.Controls
{
    /// <summary>
    /// Represents attached properties for setting the elevation along the z-axis of the element.
    /// </summary>
    public sealed class ElevationAssist
    {
        #region Attached Property: Level
        /// <summary>
        /// Identifies the <see cref="ElevationAssist" />.Level attached property.
        /// </summary>
        public static readonly DependencyProperty LevelProperty = DependencyProperty.RegisterAttached(
            "Level",
            typeof(ElevationLevel),
            typeof(ElevationAssist),
            new PropertyMetadata(ElevationLevel.Level0)
        );


        /// <summary>
        /// Gets the value of the <see cref="ElevationAssist" />.Level attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="ElevationAssist" />.Level attached property.
        /// </returns>
        public static ElevationLevel GetLevel(UIElement element)
            => (ElevationLevel)element.GetValue(LevelProperty);

        /// <summary>
        /// Sets the value of the <see cref="ElevationAssist" />.Level attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="ElevationAssist" />.Level attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetLevel(UIElement element, ElevationLevel value)
            => element.SetValue(LevelProperty, value);
        #endregion
    }
}
