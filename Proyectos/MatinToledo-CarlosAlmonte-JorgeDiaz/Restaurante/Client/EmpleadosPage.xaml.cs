using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Client
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class EmpleadosPage : Client.Common.LayoutAwarePage
    {
        public EmpleadosPage()
        {
            this.InitializeComponent();
            
            // Opciones de búsqueda para el ComboBox.
            string[] busqueda_filtros = new string[6] { "ID", "Nombre", "Apellido", "Puesto", "Sueldo", "Activo" };
            this.ComboBox_Search.ItemsSource = busqueda_filtros;

        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void ComboBox_Search_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Se ocultan todos los controles y se muestra el correspondiente al filtro seleccionado.
            switch (this.ComboBox_Search.SelectedIndex)
            {
                case 3:
                    {
                        this.TextBox_Search.Visibility = Visibility.Collapsed;
                        this.CheckBox_Search_Activo.Visibility = Visibility.Collapsed;
                        this.ComboBox_Search_Puesto.Visibility = Visibility.Visible;
                        break;
                    }
                case 5:
                    {
                        this.TextBox_Search.Visibility = Visibility.Collapsed;
                        this.ComboBox_Search_Puesto.Visibility = Visibility.Collapsed;
                        this.CheckBox_Search_Activo.Visibility = Visibility.Visible;
                        break;
                    }
                default:
                    {
                        this.ComboBox_Search_Puesto.Visibility = Visibility.Collapsed;
                        this.CheckBox_Search_Activo.Visibility = Visibility.Collapsed;
                        this.TextBox_Search.Visibility = Visibility.Visible;
                        break;
                    }
            }
        }

    }
}
