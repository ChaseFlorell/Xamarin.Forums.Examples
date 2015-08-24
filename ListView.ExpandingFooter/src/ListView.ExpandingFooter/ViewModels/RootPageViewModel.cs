using System.Collections.ObjectModel;

namespace ListView.ExpandingFooter.ViewModels
{
    public class RootPageViewModel : ViewModelBase
    {
        public RootPageViewModel()
        {
            // just seed the list with something
            People = new ObservableCollection<PersonViewModel>();
            for (var i = 0; i <= 5; i++)
            {
                People.Add(new PersonViewModel
                {
                    FirstName = string.Format("John {0}", i),
                    LastName = string.Format("John {0}", i)
                });
            }
        }

        private const string PeoplePropertyName = @"People";
        private ObservableCollection<PersonViewModel> _people;
        public ObservableCollection<PersonViewModel> People
        {
            get { return _people; }
            set { SetField(ref _people, value, PeoplePropertyName); }
        }

        private const string FooterHeightPropertyName = @"FooterHeight";
        private double _footerHeight;
        public double FooterHeight
        {
            get { return _footerHeight;}
            set { SetField(ref _footerHeight, value, FooterHeightPropertyName); }
        }
    }
}