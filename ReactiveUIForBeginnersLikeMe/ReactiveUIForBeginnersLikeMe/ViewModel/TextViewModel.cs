using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;

namespace ReactiveUIForBeginnersLikeMe.ViewModel
{
    public class TextViewModel : ReactiveObject
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { this.RaiseAndSetIfChanged(ref _firstName, value); }
        }
    }
}
