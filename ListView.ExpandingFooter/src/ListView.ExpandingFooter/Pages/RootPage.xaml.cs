using System;
using ListView.ExpandingFooter.ViewModels;

namespace ListView.ExpandingFooter.Pages
{
    public partial class RootPage
    {
        private RootPageViewModel _viewModel;

        public RootPage()
        {
            InitializeComponent();

            Button.Clicked += (sender, args) => AddAPerson();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel = new RootPageViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            UpdateFooterHeight();
        }

        private void AddAPerson()
        {
            var i = _viewModel.People.Count + 1;
            _viewModel.People.Add(new PersonViewModel
            {
                FirstName = string.Format("John {0}", i),
                LastName = string.Format("John {0}", i)
            });
            UpdateFooterHeight();
        }

        private void UpdateFooterHeight()
        {
            const int minHeight = 80;
            // why the extra 2? Good question, I'm not sure what's accounting for that extra spacing.
            var requestedHeight = Math.Floor(App.Device.Height - (MyListView.RowHeight * _viewModel.People.Count) - App.Device.StatusBarHeight - 2);
            FooterWrapper.HeightRequest = requestedHeight >= minHeight ? requestedHeight : minHeight;
        }
    }
}