using System.Globalization;

namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Label_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		if(e.PropertyName== "FontAttributes")
		{
			var a = (sender as Label).FontAttributes;
		}
    }
}

