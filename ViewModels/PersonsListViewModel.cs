
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReportBuilder.DataModels;

namespace ReportBuilder.ViewModels
{
    public class PersonsListViewModel
    {
        public ObservableCollection<Persons> ListItems {get; }

        public PersonsListViewModel(IEnumerable<Persons> persons)
        {
            ListItems = new ObservableCollection<Persons>(persons);
        }
    }
}