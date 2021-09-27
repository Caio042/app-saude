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
    [Activity(Label = "ImcActivity")]
    public class ImcActivity : Activity
    {
        EditText txtAltura, txtPeso;
        Button btnIMC;
        TextView lblImc;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.activity_imc);

            txtAltura = FindViewById<EditText>(Resource.Id.txtAltura);
            txtPeso = FindViewById<EditText>(Resource.Id.txtPeso);
        }
    }
}