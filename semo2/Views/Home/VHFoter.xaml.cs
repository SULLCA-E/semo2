using semo2.Views.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semo2.Views.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VHFoter : ContentView
	{
		public VHFoter ()
		{
			InitializeComponent ();
		}

        private async void btn_ingresar_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new VPPrincipal());
        }
    }
}