using ReactiveUI;

namespace ReactiveUIForBeginnersLikeMe.ViewModel
{
    public class MainViewModel : ReactiveObject
    {
        private TextViewModel _textModel;

        public TextViewModel TextModel
        {
            get { return _textModel; }
            set { this.RaiseAndSetIfChanged(ref _textModel, value); }
        }

        public MainViewModel()
        {
            TextModel = new TextViewModel();
        }
    }
}
