using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsDiseño
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCode : ContentPage
    {
        public EntryCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var endry = new Entry { Text = "This is a read-only Entry" };
            stack.Children.Add(endry);
            Content = stack;
        }
    }
}