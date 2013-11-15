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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Client
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Assign the same event to all buttons.
            Button_Empleados.Click += Button_Click;
            Button_Inventario.Click += Button_Click;
            Button_Proveedores.Click += Button_Click;
            Button_AgregarEntidad.Click += Button_Click;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button_sender = sender as Button;

            switch (button_sender.Name)
            {
                case "Button_Empleados":
                    {
                        this.Frame.Navigate(typeof(EmpleadosPage));
                        break;
                    }
                case "Button_Inventario":
                    {
                        this.Frame.Navigate(typeof(InventarioPage));
                        break;
                    }
                case "Button_Proveedores":
                    {
                        this.Frame.Navigate(typeof(ProveedoresPage));
                        break;
                    }
            }
        }

    }
}
