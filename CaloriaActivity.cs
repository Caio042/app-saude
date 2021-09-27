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
    [Activity(Label = "CaloriaActivity")]
    public class CaloriaActivity : Activity
    {
        RadioButton rdPerderPeso, rdManterPeso, rdGanharPeso;
        Button btnCalorias;
        TextView lblCaloriasResposta;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_calorias);

            rdPerderPeso = FindViewById<RadioButton>(Resource.Id.rdPerderPeso);
            rdManterPeso = FindViewById<RadioButton>(Resource.Id.rdManterPeso);
            rdGanharPeso = FindViewById<RadioButton>(Resource.Id.rdGanharPeso);
            btnCalorias = FindViewById<Button>(Resource.Id.btnCalorias);

            lblCaloriasResposta = FindViewById<TextView>(Resource.Id.lblCaloriasResposta);

            btnCalorias.Click += BtnCalorias_Click;
        }

        private void BtnCalorias_Click(object sender, EventArgs e)
        {
            string dica = "";

            if (rdPerderPeso.Checked)
            {
                dica = "Coma menos calorias";
            }
            if (rdManterPeso.Checked)
            {
                dica = "Mantenha as calorias";
            }
            if (rdGanharPeso.Checked)
            {
                dica = "Coma mais calorias";
            }

            lblCaloriasResposta.Text = dica;
        }
    }
}