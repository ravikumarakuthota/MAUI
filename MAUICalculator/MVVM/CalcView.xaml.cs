namespace MAUICalculator.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		this.BindingContext=new CalcViewModel();
	}
}