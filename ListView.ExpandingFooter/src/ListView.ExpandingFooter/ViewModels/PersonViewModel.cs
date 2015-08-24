namespace ListView.ExpandingFooter.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private const string FirstNamePropertyName = @"FirstName";
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetField(ref _firstName, value, FirstNamePropertyName); }
        }

        private const string LastNamePropertyName = @"LastName";
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetField(ref _lastName, value, LastNamePropertyName); }
        }
    }
}