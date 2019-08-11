using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListViewFeaturesSample.Models;
using Xamarin.Forms;

namespace ListViewFeaturesSample.Views
{
    public partial class Animalpage : ContentPage
    {
        //public Animalpage()
        //{
        //    InitializeComponent();
        //}

       // private ObservableCollection<GroupedAnimal> groupedAnimal { get; set; }

        public Animalpage()
        {
            InitializeComponent();

            //groupedAnimal = new ObservableCollection<GroupedAnimal>();

            //var dogs = new GroupedAnimal()
            //{
            //    InicialLetter = "D",
            //    Type = "Dog"
            //};

            //var cats = new GroupedAnimal()
            //{
            //    InicialLetter = "C",
            //    Type = "Cats"
            //};

            //dogs.Add(
            //      new Animal()
            //      {
            //          Name = "Lover",
            //          Picture = "",
            //          Race = "Pequines"
            //      }
            //    );

            //cats.Add(
            //      new Animal()
            //      {
            //          Name = "Ranger",
            //          Picture = "",
            //          Race = "Gatito"
            //      }
            //    );
            //groupedAnimal.Add(dogs);
            //groupedAnimal.Add(cats);
            //lstView.ItemsSource = groupedAnimal;
        }
    }
}
