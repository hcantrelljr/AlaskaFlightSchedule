using AlaskaFlightSchedule.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace AlaskaFlightSchedule.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class MainFragment : BaseFragment<MainViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_main;
    }
}
