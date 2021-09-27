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
        TextView lblGordura;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_gordura);

            // Create your application here
            txtGorduraCorporal = FindViewById<EditText>(Resource.Id.txtGorduraCorporal);
            btnGorduraCorporal = FindViewById<Button>(Resource.Id.btnGorduraCorporal);
            lblGordura = FindViewById<TextView>(Resource.Id.lblGordura);

            btnGorduraCorporal.Click += BtnGorduraCorporal_Click;
        }

        private void BtnGorduraCorporal_Click(object sender, EventArgs e)
        {
            double gorduraCorporal = double.Parse(txtGorduraCorporal.Text);

            if (gorduraCorporal < 19)
            {
                lblGordura.Text = "Atleta";
            } else if (gorduraCorporal < 31)
            {
                lblGordura.Text = "Normal";
            } else
            {
                lblGordura.Text = "Elevado, procure um especialista";
            }
        }
    }
}