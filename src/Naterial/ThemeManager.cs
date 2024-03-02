using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Naterial
{
    /// <summary>
    /// Represents utility methods for palette theming.
    /// </summary>
    public sealed class ThemeManager
    {
        /// <summary>
        /// Provides access to the methods for theming associated with the app.
        /// </summary>
        public static ThemeManager Current { get; } = new ThemeManager();

        /// <summary>
        /// Sets or gets a collection of <see cref="Uri" /> associated with a key that stores palettes
        /// for the entire app and is used for theming scenarios.
        /// </summary>
        public IDictionary<object, Uri> ThemeUries { get; set; } = new Dictionary<object, Uri>
        {
            { BaseTheme.Light, new Uri("pack://application:,,,/Naterial;component/Themes/Light.xaml") },
            { BaseTheme.Dark, new Uri("pack://application:,,,/Naterial;component/Themes/Dark.xaml") },
        };


        /// <summary>
        /// Gets the palette key of contained the root <see cref="ResourceDictionary" />.
        /// </summary>
        /// <param name="root">
        /// The root <see cref="ResourceDictionary" /> for get palette.
        /// </param>
        /// <returns>
        /// The palette key from <see cref="ThemeUries" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="root" /> or <see cref="ThemeUries" /> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// The specified root <see cref="ResourceDictionary" /> is not contain palette.
        /// </exception>
        public object GetTheme(ResourceDictionary root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }
            if (ThemeUries == null)
            {
                throw new ArgumentNullException($"{ nameof(ThemeManager) }.{ nameof(ThemeUries) }");
            }

            ResourceDictionary actualTheme = FirstOrNullTheme(root);

            if (actualTheme == null)
            {
                throw new InvalidOperationException(
                    "The given root resource dictionary was not contain palette."
                );
            }

            return ThemeUries.First(uri => uri.Value == actualTheme.Source).Key;
        }

        /// <summary>
        /// Sets the palette to root <see cref="ResourceDictionary" /> by specified key.
        /// </summary>
        /// <param name="root">
        /// The root <see cref="ResourceDictionary" /> for set palette.
        /// </param>
        /// <param name="key">
        /// The palette key from the <see cref="ThemeUries" />.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="root" />, <paramref name="key" /> or <see cref="ThemeUries" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The specified palette key is not defined in the <see cref="ThemeUries" />.
        /// </exception>
        public void SetTheme(ResourceDictionary root, object key)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (ThemeUries == null)
            {
                throw new ArgumentNullException($"{ nameof(ThemeManager) }.{ nameof(ThemeUries) }");
            }

            if (!ThemeUries.ContainsKey(key))
            {
                throw new ArgumentException(
                    $"The given key was not defined in the { nameof(ThemeManager) }.{ nameof(ThemeUries) }."
                );
            }

            ResourceDictionary oldTheme = FirstOrNullTheme(root);

            // It is important to add a new one before removing the old palette, otherwise warnings
            // for missing resources are created.
            root.MergedDictionaries.Add(new ResourceDictionary { Source = ThemeUries[key] });

            if (oldTheme != null)
            {
                root.MergedDictionaries.Remove(oldTheme);
            }
        }


        private ResourceDictionary FirstOrNullTheme(ResourceDictionary root)
        {
            return root.MergedDictionaries.FirstOrDefault(
                md => md.Source != null && md.Source.IsAbsoluteUri && ThemeUries.Values.Contains(md.Source)
            );
        }
    }
}
