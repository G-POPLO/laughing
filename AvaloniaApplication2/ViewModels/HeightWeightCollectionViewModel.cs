using AvaloniaApplication2.Views;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace AvaloniaApplication2.ViewModels
{
    public class HeightWeightCollectionViewModel : ViewModelBase
    {
        private string _height;
        private string _weight;

        public string Height
        {
            get => _height;
            set => OnPropertyChanged(ref _height, value);
        }

        public string Weight
        {
            get => _weight;
            set => OnPropertyChanged(ref _weight, value);
        }

        public ICommand NextStepCommand { get; private set; }
        public ICommand BackCommand { get; private set; }

        public HeightWeightCollectionViewModel()
        {
            NextStepCommand = new RelayCommand(OnNextStep);
            BackCommand = new RelayCommand(OnBack);
        }

        private void OnNextStep()
        {
            var mainView = new MainView();
            mainView.Show();
        }

        private void OnBack()
        {
            var nameCollectionView = new NameCollectionView();
            nameCollectionView.Show();
        }
    }
}
