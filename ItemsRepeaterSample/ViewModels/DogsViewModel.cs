using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ItemsRepeaterSample.Models;

namespace ItemsRepeaterSample.ViewModels;

public partial class DogsViewModel : ViewModelBase
{
    private readonly TabbedViewModel _tabbedViewModel;

    [ObservableProperty] private Dog _dog;
    
    [ObservableProperty] private bool _isMyDog;

    public string DogName => string.IsNullOrEmpty(Dog.Name) ? "No name" : $"Name: {Dog.Name}";

    public string DogBreed => string.IsNullOrEmpty(Dog.Breed) ? "No breed" : $"Breed: {Dog.Breed}";
    
    [RelayCommand]
    private async Task AddDogAsync()
    {
        await Task.Delay(100).ConfigureAwait(false); // Simulate async operation

        IsMyDog = true;
        await _tabbedViewModel.AddDogAsync(this.Dog).ConfigureAwait(false);
    }
    
    [RelayCommand]
    private async Task RemoveDogAsync()
    {
        IsMyDog = false;
        await _tabbedViewModel.RemoveDogsAsync([Dog.Name]).ConfigureAwait(false);
    }

    public DogsViewModel(TabbedViewModel tabbedViewModel, Dog dog)
    {
        _tabbedViewModel = tabbedViewModel;
        Dog = dog;
    }
}