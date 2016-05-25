using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mpc.XFApp.Pages
{
    public partial class AllComponents : ContentPage
    {
        public AllComponents()
        {
            InitializeComponent();
        }

        private void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperValue.Text = $"{e.OldValue} TO {e.NewValue}";
        }

        private void SwitchChanged(object sender, ToggledEventArgs e)
        {
            SwitchValue.Text = $"Switch is now {e.Value}";
        }
    }
}
