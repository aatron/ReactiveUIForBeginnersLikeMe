using System.Collections.Generic;

using ReactiveUI;

using ReactiveUIForBeginnersLikeMe.Model;

namespace ReactiveUIForBeginnersLikeMe.ViewModel
{
    public class ListViewModel : ReactiveObject
    {
        private List<Name> _names;

        public List<Name> Names
        {
            get { return _names; }
            set { this.RaiseAndSetIfChanged(ref _names, value); }
        }

        private Name _selectedName;

        public Name SelectedName
        {
            get { return _selectedName; }
            set { this.RaiseAndSetIfChanged(ref _selectedName, value); }
        }
    }
}
