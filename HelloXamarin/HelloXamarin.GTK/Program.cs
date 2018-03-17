using GLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.GTK;

namespace HelloXamarin.GTK
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			ExceptionManager.UnhandledException += OnUnhandledException;

			GtkOpenGL.Init();
			GtkThemes.Init();
			Gtk.Application.Init();
			Xamarin.Forms.Forms.Init();
			var app = new HelloXamarin.App();
			var window = new FormsWindow();
			window.LoadApplication(app);
			window.SetApplicationTitle("Xamarin.Forms GTK# Backend");
			window.Show();
			Gtk.Application.Run();
		}
		private static void OnUnhandledException(UnhandledExceptionArgs args)
		{
			System.Diagnostics.Debug.WriteLine($"Unhandled GTK# exception: {args.ExceptionObject}");
		}
	}
}
