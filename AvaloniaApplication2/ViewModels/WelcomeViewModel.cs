using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;

namespace AvaloniaApplication2.ViewModels
{
    public class WelcomeViewModel : ViewModelBase
    {
        public ICommand NextStepCommand { get; private set; }

        public WelcomeViewModel()
        {
            NextStepCommand = new RelayCommand(OnNextStep);
        }

        private void OnNextStep()
        {
            try
            {
                var nameCollectionView = new NameCollectionView();
                nameCollectionView.Show();
                Console.WriteLine("NameCollectionView shown.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error showing NameCollectionView: {ex.Message}");
            }
        }
    }



}
