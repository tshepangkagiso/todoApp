using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace todo.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;


    [ObservableProperty]
    string text;

    [RelayCommand]
    void add()
    {
        if (string.IsNullOrWhiteSpace(Text){
            return;
        }
        else
        {
            Items.Add(Text);
            Text = string.Empty;
        }


    }
}
