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
    [Activity(Label = "GorduraActivity")]
    public class GorduraActivity : Activity
    {
        EditText txtGorduraCorporal;
        Button btnGorduraCorporal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_gordura);

            // Create your application here
            txtGorduraCorporal = FindViewById<EditText>(Resource.Id.txtGorduraCorporal);
        }
    }
}