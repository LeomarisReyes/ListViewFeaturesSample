using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListViewFeaturesSample.Models;

namespace ListViewFeaturesSample.ViewModels
{
    public class AnimalViewModel
    {
        public ObservableCollection<GroupedAnimal> groupedAnimal { get; set; }

        public AnimalViewModel()
        {
            groupedAnimal = new ObservableCollection<GroupedAnimal>();

            var dogs = new GroupedAnimal()
            {
                 Type="Dog",
                 InitialLetter="D"
            };

            var cats = new GroupedAnimal()
            {
                Type = "Cat",
                InitialLetter = "C"
            };

            cats.Add( new Animal() { Name = "Kevin",  Race = "British Shorthair" });
            cats.Add( new Animal() { Name = "Mike",   Race = "Ragdoll" });
            cats.Add( new Animal() { Name = "Junior", Race = "Abisinio"  });

            dogs.Add( new Animal() { Name = "Lover", Race = "Poodle" } );
            dogs.Add( new Animal() { Name = "Roster", Race = "Bulldog" } );

            groupedAnimal.Add(dogs);
            groupedAnimal.Add(cats);
        }
    }
}


  