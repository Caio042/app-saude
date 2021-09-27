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
        Button btnAgua;
        TextView lblAgua;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_agua);

            txtAgua = FindViewById<EditText>(Resource.Id.txtAgua);
            btnAgua = FindViewById<Button>(Resource.Id.btnAgua);

            lblAgua = FindViewById<TextView>(Resource.Id.lblAgua);

            btnAgua.Click += BtnAgua_Click;
        }

        private void BtnAgua_Click(object sender, EventArgs e)
        {
            double agua = double.Parse(txtAgua.Text);

            if (agua < 2)
            {
                lblAgua.Text = "Beba mais " + (2 - agua) + " litros de agua";
            }
            else if (agua < 3)
            {
                lblAgua.Text = "Parabéns, está hidratado";
            }
            else
            {
                lblAgua.Text = "Wow, vai com calma na hidratação ai";
            }
        }
    }
}