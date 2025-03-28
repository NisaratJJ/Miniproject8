using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Miniproject.Model;
using Miniproject.Pages;

namespace Miniproject.Viewmodel;

[QueryProperty(nameof(ReceivedStudent), "StudentData")]
public partial class HomeViewmodel : ObservableObject
{
    [ObservableProperty]
    private Students receivedStudent;

    [ObservableProperty]
    private Students currentStudent;

    [ObservableProperty]
    ObservableCollection<Students> student = new ObservableCollection<Students>();
    partial void OnReceivedStudentChanged(Students value)
    {
        if (value != null)
        {
            CurrentStudent = value;
            Student = new ObservableCollection<Students> { CurrentStudent };
        }
    }

    [RelayCommand]
    public async Task GotoPage(string page)
    {
        if (CurrentStudent != null)
        {
            var parameters = new Dictionary<string, object>
            {
                { "StudentData", CurrentStudent }
            };
            await Shell.Current.GoToAsync(page, parameters);
        }
    }
}
