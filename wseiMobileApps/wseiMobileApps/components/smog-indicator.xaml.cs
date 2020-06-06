using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wseiMobileApps.components {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmogIndicator {
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
            propertyName: nameof(Value),
            returnType: typeof(int),
            declaringType: typeof(SmogIndicator),
            defaultValue: null);

        public int Value {
            get { return (int) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public SmogIndicator() {
            InitializeComponent();
        }
    }
}