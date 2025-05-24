using System.Collections.ObjectModel;
using UnitsNet;
using UnitsNet.Units;
namespace MauiVerter.MVVM.ViewModel;

public class ConverterViewModel : ContentPage
{
	   public string QuantityName { get; set; }
	   public ObservableCollection<string> FromMeasures { get; set; }
	   public ObservableCollection<string> ToMeasures { get; set; }

	   public ConverterViewModel()
	   {
		//  QuantityName="Length";
		//  FromMeasures = LoadMeasures();
		//  ToMeasures=LoadMeasures();
	   }
	//    private ObservableCollection<string> LoadMeasures()
	//    {
	// 	   var types = Quantity.GetAllQuantityInfos()
	// 	               .FirstOrDefault(X => X.Name == QuantityName)
	// 				   .UnitInfos
	// 				   .Select(X => X.Name)
	// 				   .ToList();

	// 		return new ObservableCollection<string>(types);
	//    }
}