using MvvmCross.Core.ViewModels;

namespace Mobile._3ndey.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public MvxCommand SignInCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<LoginViewModel>());
            }
        }
    }
}
