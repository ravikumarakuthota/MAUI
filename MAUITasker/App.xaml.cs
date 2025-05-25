using MAUITasker.MVVM.Views;

namespace MAUITasker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainView();
	}
}
