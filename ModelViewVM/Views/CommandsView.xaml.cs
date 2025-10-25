using MVVM.ModelViewVM.ViewModels;

namespace MVVM.ModelViewVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
    }

	
}