using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.ViewModels;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
    {
        if (!EqualityComparer<T>.Default.Equals(field, value))
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


