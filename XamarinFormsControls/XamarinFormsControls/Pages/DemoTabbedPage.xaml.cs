using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsControls
{
	public partial class DemoTabbedPage : TabbedPage
	{
		public DemoTabbedPage()
		{
			InitializeComponent();

			Title = "TabbedPage";

			ItemsSource = new NamedColor[] {
				new NamedColor ("Red", Color.Red),
				new NamedColor ("Yellow", Color.Yellow),
				new NamedColor ("Green", Color.Green),
				new NamedColor ("Aqua", Color.Aqua),
				new NamedColor ("Blue", Color.Blue),
				new NamedColor ("Purple", Color.Purple)
			};
		}
	}
}
