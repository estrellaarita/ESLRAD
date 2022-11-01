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
    public partial class PageActualizar : ContentPage
    {
        public PageActualizar()
        {
            InitializeComponent();
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
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

            await App.dbemple.ActualizarContacto(emple);
               
        }
    }
}