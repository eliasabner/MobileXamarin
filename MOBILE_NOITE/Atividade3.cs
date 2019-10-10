using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "Atividade3")]

   
    public class Atividade3 : Activity
    {
        Spinner spinner;
        TextView lbl;
        ArrayAdapter arrayAdapter;
        string mostra;
        Button cadastrar;
        EditText nomeCad, nomeForm,sexoCad, endForm, endCad, ruaCad, ruaForm, cidadeCad, cidadeForm;
        EditText estadosCad;
        RadioButton sexoF, sexoM;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Atividae3);

            spinner = FindViewById<Spinner>(Resource.Id.spForm);
            //lbl = FindViewById<TextView>(Resource.Id.lb_form);
            cadastrar = FindViewById<Button>(Resource.Id.formCadastar);

            nomeCad = FindViewById<EditText>(Resource.Id.nomeCadastrado);
            nomeForm = FindViewById<EditText>(Resource.Id.nomeForm);
            sexoCad = FindViewById<EditText>(Resource.Id.sexoCad);

            endForm = FindViewById<EditText>(Resource.Id.endForm);
            endCad = FindViewById<EditText>(Resource.Id.endCad);

            ruaForm = FindViewById<EditText>(Resource.Id.ruaForm);
            ruaCad = FindViewById<EditText>(Resource.Id.ruaCad);

            cidadeForm = FindViewById<EditText>(Resource.Id.cidadeForm);
            cidadeCad = FindViewById<EditText>(Resource.Id.cidadeCad);
            estadosCad = FindViewById<EditText>(Resource.Id.estadosCad);

            sexoF = FindViewById<RadioButton>(Resource.Id.sexoF);
            sexoM = FindViewById<RadioButton>(Resource.Id.sexoM);




            // CRIAR UM ARRAY COM ITEM XML E COLOCAR NO ADAPTER
            arrayAdapter = ArrayAdapter.CreateFromResource(this,
                Resource.Array.estadoXML, Android.Resource.Layout.SimpleListItem1);
            // SE ADAPTAR AO SPINNER
            spinner.Adapter = arrayAdapter;
            spinner.ItemSelected += Spinner_ItemSelected;

            cadastrar.Click += Cadastrar_Click;

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            nomeCad.Text = nomeForm.Text;
            if (sexoF.Checked)
            {
                sexoCad.Text = "Feminino";
            }else{
                sexoCad.Text = "Masculino";
            }

            endCad.Text = endForm.Text;
            ruaCad.Text = ruaForm.Text;
            cidadeCad.Text = cidadeForm.Text;
            estadosCad.Text = spinner.SelectedItem.ToString();



        

        
        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            mostra = spinner.SelectedItem.ToString();

            Toast.MakeText(this,mostra , ToastLength.Short).Show();
        }
    }
}