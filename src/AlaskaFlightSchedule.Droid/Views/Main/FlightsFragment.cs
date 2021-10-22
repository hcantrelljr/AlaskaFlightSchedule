using AlaskaFlightSchedule.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace AlaskaFlightSchedule.Droid.Views.Main
{
    [MvxFragmentPresentation(
        typeof(MainContainerViewModel),
        Resource.Id.content_frame,
        AddToBackStack = true,
        AddFragment = true,
        ViewModelType = typeof(FlightsViewModel))]
    public class FlightsFragment : BaseFragment<FlightsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_flights;
    }
}
