﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VendasEstoque.Banco;
using Xamarin.Forms;
using VendasEstoque.Droid.Banco;
using System.IO;


[assembly:Dependency(typeof(Caminho))]
namespace VendasEstoque.Droid.Banco
{
   public class Caminho : ICaminho
   {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }

        public string GetPath()
        {
            return Android.App.Application.Context.GetExternalFilesDir("").AbsolutePath;
        }
   }
}