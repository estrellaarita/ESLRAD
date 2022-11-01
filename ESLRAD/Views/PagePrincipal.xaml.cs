using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESLRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.dbemple.listaempleados();

        }
        //Agregar Contacto
        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageEmple());
        }
        //Eliminar contacto
        private async void tooldelete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageEliminar());
        }
        //Actualuzar Contacto
        private async void toolactualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageActualizar());
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

    }
}