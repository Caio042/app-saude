using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_saude
{
    [Activity(Label = "AguaActivity")]
    public class AguaActivity : Activity
    {
        EditText txtAgua;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_agua);

            txtAgua = FindViewById<EditText>(Resource.Id.txtAgua);
        }
    }
}