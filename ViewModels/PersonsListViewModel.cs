
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReportBuilder.DataModels;

namespace ReportBuilder.ViewModels
{
    public class PersonsListViewModel
    {
        public ObservableCollection<Persons> PersonsList {get; }

        public PersonsListViewModel(IEnumerable<Persons> persons)
        {
            PersonsList = new ObservableCollection<Persons>(persons);
        }
    }
}