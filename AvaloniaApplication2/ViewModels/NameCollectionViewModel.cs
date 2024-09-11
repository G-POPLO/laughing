using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;

namespace AvaloniaApplication2.ViewModels
{
  

    public class NameCollectionViewModel : ViewModelBase
    {
        private string name;

        public string Name
        {
            get => name;
            set => OnPropertyChanged(ref name, value);
        }

        public ICommand NextStepCommand { get; private set; }
        public ICommand BackCommand { get; private set; }

        public NameCollectionViewModel()
        {
            NextStepCommand = new RelayCommand(OnNextStep);
            BackCommand = new RelayCommand(OnBack);
        }

        private void OnNextStep()
        {
            // 导航到收集身高体重界面
            var heightWeightCollectionView = new HeightWeightCollectionView();
            heightWeightCollectionView.Show();
        }

        private void OnBack()
        {
            // 返回到欢迎界面
            var welcomeView = new WelcomeView();
            welcomeView.Show();
        }
    }
}


