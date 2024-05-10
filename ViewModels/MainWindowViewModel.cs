using ReportBuilder.Services;

namespace ReportBuilder.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public PersonsListViewModel PersonsList {get;}
    public MainWindowViewModel()
    {
        var service = new PersonsService();
        PersonsList = new PersonsListViewModel(service.GetPeople());

    }
}
