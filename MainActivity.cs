using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections;

namespace app_saude
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView listView1;
        ArrayList telas;
        ArrayAdapter adaptador;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            listView1 = FindViewById<ListView>(Resource.Id.listView1);
            telas = new ArrayList();
            telas.Add("Calculadora de IMC");
            telas.Add("Verificador de gordura corporal");
            telas.Add("Verificador de hidratação diaria");
            telas.Add("Emagrecer, manter ou engordar");
            adaptador = new ArrayAdapter(this,
                Android.Resource.Layout.SimpleListItem1, telas);

            listView1.Adapter = adaptador;

            listView1.ItemClick += ListView1_ItemClick;

        }

        private void ListView1_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int item = e.Position;

            switch (item)
            {
                case 0:
                    StartActivity(typeof(ImcActivity));
                    break;
                case 1:
                    StartActivity(typeof(GorduraActivity));
                    break;
                case 2:
                    StartActivity(typeof(AguaActivity));
                    break;
                case 3:
                    StartActivity(typeof(CaloriaActivity));
                    break;
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}