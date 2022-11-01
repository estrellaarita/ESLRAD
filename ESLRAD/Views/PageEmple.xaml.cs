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
    public partial class PageEmple : ContentPage
    {
        public PageEmple()
        {
            InitializeComponent();
        }
        private async void btnagregar_Clicked(object sender, EventArgs e)
        {

            var emple = new Models.Contactos
        {
            Id = Convert.ToInt32(txtcodigo.Text),
            nombres = txtnombres.Text,
            apellidos = txtapellidos.Text,
            edad = Convert.ToInt32(txtedad.Text),
            pais = txtpais.Text,
            nota = txtnota.Text,
        };

            if (await App.dbemple.StoreEmple(emple) > 0)
                await DisplayAlert("Aviso", "Registro Ingresado con exito !!","OK");

    }
}
}

    
