using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Dangl.Calculator;

namespace MAUICalculator.MVVM
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        private string _formula = "";
        public string Formula
        {
            get => _formula;
            set
            {
                if (_formula != value)
                {
                    _formula = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _result = "0";
        public string Result
        {
            get => _result;
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand OperationCommand => new Command((number) => Formula += number);
       public ICommand ResetCommand => new Command(() =>
	   {
            Result = "0";
            Formula = "";
        });

         public ICommand BackSpaceCommand => new Command(() =>
		 {
			if(Formula.Length > 0)
			{
               Formula = Formula.Substring(0,Formula.Length - 1);
			}
		 });

           
        public ICommand CalculateCommand => new Command(() =>
            {
                if (Formula.Length == 0)
                    return;
                var calculation =
                    Calculator.Calculate(Formula);
                Result = calculation.Result.ToString();
            });       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
	}
}
