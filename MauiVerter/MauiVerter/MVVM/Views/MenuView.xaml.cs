using MauiVerter.MVVM.ViewModel;

namespace MauiVerter.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}
}