using System.Collections.ObjectModel;
using MAUITasker.MVVM.Models;

namespace MAUITasker.MVVM.ViewModels;

public class MainViewModel : ContentPage
{
	public ObservableCollection<Category> Categories { get; set; }

	public MainViewModel()
	{
		FillData();
	}

	private void FillData()
	{
		Categories = new ObservableCollection<Category>
		{
					new Category
					{
						 Id = 1,
						 CategoryName = ".NET MAUI Course",
						 Color = "#CF14DF"
					},
					new Category
					{
						 Id = 2,
						 CategoryName = "Tutorials",
						 Color = "#df6f14"
					},
					new Category
					{
						 Id = 3,
						 CategoryName = "Shopping",
						 Color = "#14df80"
					}
		 };
	}
}