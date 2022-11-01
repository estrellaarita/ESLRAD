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
    public partial class PageEliminar : ContentPage
    {
        public PageEliminar()
        {
            InitializeComponent();
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Contactos
            {
                Id = Convert.ToInt32(txtcodigo.Text),

            };
            await App.dbemple.Deleteempleado(emple);

        }
    }
}