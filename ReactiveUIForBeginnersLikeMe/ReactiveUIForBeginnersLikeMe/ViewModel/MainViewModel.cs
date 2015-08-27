using ReactiveUI;
using ReactiveUIForBeginnersLikeMe.Model;
using System.Collections.Generic;

namespace ReactiveUIForBeginnersLikeMe.ViewModel
{
    public class MainViewModel : ReactiveObject
    {
        #region Properties

        private TextViewModel _textModel;

        public TextViewModel TextModel
        {
            get { return _textModel; }
            set { this.RaiseAndSetIfChanged(ref _textModel, value); }
        }

        private ListViewModel _listModel;

        public ListViewModel ListModel
        {
            get { return _listModel; }
            set { this.RaiseAndSetIfChanged(ref _listModel, value); }
        }
        #endregion

        public MainViewModel()
        {
            TextModel = new TextViewModel();
            ListModel = new ListViewModel
            {
                Names = new List<Name>
                {
                    new Name("Luke", "Skywalker"),
                    new Name("Annakin", "Skywalker"),
                    new Name("Darth", "Vader")
                }
            };
        }
    }
}
