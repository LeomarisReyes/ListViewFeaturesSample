using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewFeaturesSample.Models
{
    public class GroupedAnimal : ObservableCollection<Animal>
    {
       public string InitialLetter { get; set; }
       public string Type { get; set; }
    }
}
