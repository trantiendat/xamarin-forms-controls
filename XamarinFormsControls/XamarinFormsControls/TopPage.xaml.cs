using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsControls
{
	public partial class TopPage : MasterDetailPage
	{
		public TopPage()
		{
			InitializeComponent();
			listMenu.ItemsSource = new List<MenuEnum>()
			{
				MenuEnum.Page,
				MenuEnum.Layout,
				MenuEnum.View,
				MenuEnum.Cell
			};
			Detail = new NavigationPage(new MenuPage());
		}

		void OnMenuList_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var page = (MenuEnum)e.Item;
			switch (page)
			{
				case MenuEnum.Page:
					Detail = new NavigationPage(new MenuPage());
					break;
				case MenuEnum.Layout:
					break;
				case MenuEnum.View:
					break;
				case MenuEnum.Cell:
					break;
			}
			IsPresented = false;
		}
	}

	public enum MenuEnum
	{
		Page,
		Layout,
		View,
		Cell
	}
}
