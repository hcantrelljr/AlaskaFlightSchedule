using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using Android.Views;
using AlaskaFlightSchedule.Core.ViewModels.Main;
using AndroidX.AppCompat.Widget;

namespace AlaskaFlightSchedule.Droid.Views.Main
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            toolbar.Title = GetString(Resource.String.app_name);
        }
    }
}
