using System;
using System.ComponentModel;


namespace ChangeTracking.ViewModels
{
    public class UIViewModel
    {
        public BindingList<Person> _people;

        public UIViewModel(BindingList<Person> people)
        {
            this._people = people;
        }
    }

}
