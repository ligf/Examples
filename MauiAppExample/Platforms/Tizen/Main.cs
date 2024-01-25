using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace MauiAppExample
{
    internal class Program : MauiAppExamplelication
    {
        protected override MauiAppExample CreateMauiAppExample() => MauiProgram.CreateMauiAppExample();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
