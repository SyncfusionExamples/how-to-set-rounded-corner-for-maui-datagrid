# how-to-set-rounded-corner-for-maui-datagrid

You can set the rounded corner for the .NET [MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid)(SfDataGrid) by loading the DataGrid in the [Border](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/border?view=net-maui-7.0).

## XAML
Define the StrokeShape as RoundRectangle with CornerRadius as 10 for the border to apply rounded corners to the DataGrid.

```XML
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DataGridMAUI"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             x:Class="DataGridMAUI.MainPage">
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="ViewModel"></local:ViewModel>
    </ContentPage.BindingContext>
<Border Stroke="LightGray"
        StrokeThickness="2"
        StrokeShape="RoundRectangle 10,10,10,10" VerticalOptions="Start"
        HorizontalOptions="Center">
        <syncfusion:SfDataGrid x:Name="dataGrid" AutoGenerateColumnsMode="None" GridLinesVisibility="Both" HeaderGridLinesVisibility="Both" WidthRequest="300" HeightRequest="520"  ItemsSource="{Binding OrderInfoCollection}" >
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn MappingName="OrderID" Format="D">
                </syncfusion:DataGridNumericColumn>
                <syncfusion:DataGridTextColumn MappingName="Customer" HeaderText="Name"></syncfusion:DataGridTextColumn>
                <syncfusion:DataGridTextColumn MappingName="Country"></syncfusion:DataGridTextColumn>
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>
    </Border>
</ContentPage>
```

![RoundedCorner](RoundedCorner.png)
