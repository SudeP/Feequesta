using Feequesta.Elements.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Feequesta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : HeaderAndFooterPager
    {
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}