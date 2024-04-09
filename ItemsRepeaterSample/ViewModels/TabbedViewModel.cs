using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ItemsRepeaterSample.Models;

namespace ItemsRepeaterSample.ViewModels;

public class TabbedViewModel : ViewModelBase
{
    public ObservableCollection<DogsViewModel> MyDogs { get; } = [];
    public ObservableCollection<DogsViewModel> AvailableDogs { get; } = [];

    public TabbedViewModel()
    {
        AddInitialMyDogs();
        AddAvailableDogs();
    }

    private void AddInitialMyDogs()
    {
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Rex", Breed = "German Shepherd" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Buddy", Breed = "Golden Retriever" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Max", Breed = "Beagle" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Toby", Breed = "Chihuahua" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Charlie", Breed = "Bulldog" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Milo", Breed = "Chihuahua" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Oscar", Breed = "Dachshund" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Duke", Breed = "Chihuahua" }));
        MyDogs.Add(new DogsViewModel(this, new Dog { Name = "Lucy", Breed = "Poodle" }));
    }

    private void AddAvailableDogs()
    {
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Daisy", Breed = "Rottweiler" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Sadie", Breed = "French Bulldog" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Molly", Breed = "Yorkshire Terrier" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Bailey", Breed = "Boxer" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Maggie", Breed = "Siberian Husky" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Stella", Breed = "Dalmatian" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Chloe", Breed = "Great Dane" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Penny", Breed = "Doberman" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Lola", Breed = "Chihuahua" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Sophie", Breed = "Chihuahua" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Lily", Breed = "Pug" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Ruby", Breed = "Maltese" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Rosie", Breed = "Shih Tzu" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Ellie", Breed = "Boston Terrier" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Abby", Breed = "Bichon Frise" }));
        AvailableDogs.Add(new DogsViewModel(this, new Dog { Name = "Roxy", Breed = "Havanese" }));
    }

    public async Task AddDogAsync(Dog dog)
    {
        await Task.Delay(100).ConfigureAwait(false); // Simulate async operation

        MyDogs.Add(new DogsViewModel(this, dog));
    }

    public async Task RemoveDogsAsync(List<string> dogNamesToRemove)
    {
        await Task.Delay(100).ConfigureAwait(false); // Simulate async operation

        foreach (var dogName in dogNamesToRemove)
        {
            var dogToRemove = MyDogs
                .FirstOrDefault(dogVm => dogVm.Dog.Name == dogName);

            if (dogToRemove != null)
            {
                MyDogs.Remove(dogToRemove);
            }
        }
    }
}