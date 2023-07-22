using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest.ViewModels;

namespace BindingTest.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(MonkeyDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}