using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsControls
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();

			listPage.ItemsSource = new List<PageEnum>()
			{
				PageEnum.TabbedPage,
				PageEnum.TabbedPageCS,
				PageEnum.TemplatedPage,
				PageEnum.TemplatedPageCS,
				PageEnum.CarouselPage,
				PageEnum.CarouselPageCS
			};
		}

		void OnPageList_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var page = (PageEnum)e.Item;
			switch (page)
			{
				case PageEnum.TabbedPage:
					Navigation.PushAsync(new DemoTabbedPage(), true);
					break;
				case PageEnum.TabbedPageCS:
					Navigation.PushAsync(new DemoTabbedPageCS(), true);
					break;
				case PageEnum.TemplatedPage:
					break;
				case PageEnum.TemplatedPageCS:
					break;
				case PageEnum.CarouselPage:
					Navigation.PushAsync(new DemoCarouselPage(), true);
					break;
				case PageEnum.CarouselPageCS:
					Navigation.PushAsync(new DemoCarouselPageCS(), true);
					break;
			}
		}
	}

	public enum PageEnum
	{
		TabbedPage,
		TabbedPageCS,
		TemplatedPage,
		TemplatedPageCS,
		CarouselPage,
		CarouselPageCS
	}
}