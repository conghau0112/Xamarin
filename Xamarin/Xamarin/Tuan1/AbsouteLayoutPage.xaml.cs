using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsouteLayoutPage : ContentPage
    {
        public AbsouteLayoutPage()
        {
            InitializeComponent();
            //Button btnTest = new Button();
            //absLayout.ChildAdded(btnTest);
        }
    }
}