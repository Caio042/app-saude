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
            btnIMC = FindViewById<Button>(Resource.Id.btnIMC);
            lblImc = FindViewById<TextView>(Resource.Id.lblImc);

            btnIMC.Click += BtnIMC_Click;
        }

        private void BtnIMC_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);
            imc = peso / (altura * altura);

            exibirAlerta(imc);
        }

        private void exibirAlerta(double imc)
        {

            string alerta;

            if (imc < 18.5)
            {
                alerta = "MAGREZA, procure um especialista";
            } else if(imc < 24.9)
            {
                alerta = "IMC NORMAL";
            } else if(imc < 29.9)
            {
                alerta = "SOBREPESO";
            } else if (imc < 39.9){
                alerta = "OBESIDADE";
            } else
            {
                alerta = "OBESIDADE GRAVE, procure um especialista";
            }

            lblImc.Text = alerta;
        }
    }
}