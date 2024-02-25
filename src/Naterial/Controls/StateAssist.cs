using System.Windows;
using System.Windows.Media;

namespace Naterial.Controls
{
    /// <summary>
    /// Represents attached properties for setting the opacity values of the state layer.
    /// </summary>
    public sealed class StateAssist
    {
        #region Attached Property: Fill
        /// <summary>
        /// Identifies the <see cref="StateAssist" />.Fill attached property.
        /// </summary>
        public static readonly DependencyProperty FillProperty = DependencyProperty.RegisterAttached(
            "Fill",
            typeof(Brush),
            typeof(StateAssist),
            new PropertyMetadata(null)
        );


        /// <summary>
        /// Gets the value of the <see cref="StateAssist" />.Fill attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="StateAssist" />.Fill attached property.
        /// </returns>
        public static Brush GetFill(UIElement element)
            => (Brush)element.GetValue(FillProperty);

        /// <summary>
        /// Sets the value of the <see cref="StateAssist" />.Fill attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="StateAssist" />.Fill attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetFill(UIElement element, Brush value)
            => element.SetValue(FillProperty, value);
        #endregion


        #region Attached Property: IsMouseOver
        /// <summary>
        /// Identifies the <see cref="StateAssist" />.IsMouseOver attached property.
        /// </summary>
        public static readonly DependencyProperty IsMouseOverProperty = DependencyProperty.RegisterAttached(
            "IsMouseOver",
            typeof(bool),
            typeof(StateAssist),
            new PropertyMetadata(false)
        );


        /// <summary>
        /// Gets the value of the <see cref="StateAssist" />.IsMouseOver attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="StateAssist" />.IsMouseOver attached property.
        /// </returns>
        public static bool GetIsMouseOver(UIElement element)
            => (bool)element.GetValue(IsMouseOverProperty);

        /// <summary>
        /// Sets the value of the <see cref="StateAssist" />.IsMouseOver attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="StateAssist" />.IsMouseOver attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetIsMouseOver(UIElement element, bool value)
            => element.SetValue(IsMouseOverProperty, value);
        #endregion


        #region Attached Property: IsFocused
        /// <summary>
        /// Identifies the <see cref="StateAssist" />.IsFocused attached property.
        /// </summary>
        public static readonly DependencyProperty IsFocusedProperty = DependencyProperty.RegisterAttached(
            "IsFocused",
            typeof(bool),
            typeof(StateAssist),
            new PropertyMetadata(false)
        );


        /// <summary>
        /// Gets the value of the <see cref="StateAssist" />.IsFocused attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="StateAssist" />.IsFocused attached property.
        /// </returns>
        public static bool GetIsFocused(UIElement element)
            => (bool)element.GetValue(IsFocusedProperty);

        /// <summary>
        /// Sets the value of the <see cref="StateAssist" />.IsFocused attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="StateAssist" />.IsFocused attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetIsFocused(UIElement element, bool value)
            => element.SetValue(IsFocusedProperty, value);
        #endregion


        #region Attached Property: IsSelected
        /// <summary>
        /// Identifies the <see cref="StateAssist" />.IsSelected attached property.
        /// </summary>
        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.RegisterAttached(
            "IsSelected",
            typeof(bool),
            typeof(StateAssist),
            new PropertyMetadata(false)
        );


        /// <summary>
        /// Gets the value of the <see cref="StateAssist" />.IsSelected attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="StateAssist" />.IsSelected attached property.
        /// </returns>
        public static bool GetIsSelected(UIElement element)
            => (bool)element.GetValue(IsSelectedProperty);

        /// <summary>
        /// Sets the value of the <see cref="StateAssist" />.IsSelected attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="StateAssist" />.IsSelected attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetIsSelected(UIElement element, bool value)
            => element.SetValue(IsSelectedProperty, value);
        #endregion


        #region Attached Property: IsPressed
        /// <summary>
        /// Identifies the <see cref="StateAssist" />.IsPressed attached property.
        /// </summary>
        public static readonly DependencyProperty IsPressedProperty = DependencyProperty.RegisterAttached(
            "IsPressed",
            typeof(bool),
            typeof(StateAssist),
            new PropertyMetadata(false)
        );


        /// <summary>
        /// Gets the value of the <see cref="StateAssist" />.IsPressed attached property
        /// from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="StateAssist" />.IsPressed attached property.
        /// </returns>
        public static bool GetIsPressed(UIElement element)
            => (bool)element.GetValue(IsPressedProperty);

        /// <summary>
        /// Sets the value of the <see cref="StateAssist" />.IsPressed attached property
        /// to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="StateAssist" />.IsPressed attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetIsPressed(UIElement element, bool value)
            => element.SetValue(IsPressedProperty, value);
        #endregion
    }
}
