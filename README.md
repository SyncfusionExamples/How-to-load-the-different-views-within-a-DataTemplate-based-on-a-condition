# How to load the different views within a DataTemplate based on a condition?

This article demonstrates how to load different views within a [CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html#Syncfusion_Maui_DataGrid_DataGridTemplateColumn_CellTemplate) based using the DataTemplateSelector in a .NET [MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).


**Step 1:** Define two `DataTemplate` objects with the required controls, each assigned a unique key value in the corresponding ContentPage ResourceDictionary.

 
 ```xml
 <ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="trackButton">
            <Button Text="Track Order" 
                    WidthRequest="120"
                    TextColor="Black" 
                    BackgroundColor="GreenYellow" 
                    HorizontalOptions="Center" 
                    VerticalOptions="Center" 
                    Clicked="Track_Order_Button_Clicked"/>
        </DataTemplate>
        <DataTemplate x:Key="detailsbutton">
            <Button Text="Check Details" 
                    WidthRequest="120"
                    TextColor="Black"  
                    BackgroundColor="PaleVioletRed"
                    HorizontalOptions="Center" 
                    VerticalOptions="Center" 
                    Clicked="Check_Details_Button_Clicked"/>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

 ```

**Step 2:** Implement a custom class that extends `DataTemplateSelector`. In this class, define the necessary DataTemplate properties to display in the CellTemplate. Based on a condition, return the corresponding DataTemplate.

 
 ```C#
 public class DetailsTemplateSelector : DataTemplateSelector
 {
    public DataTemplate? TrackOrderButton { get; set; }

    public DataTemplate? CheckDetailsButton { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        bool value = ((OrderInfo)item).IsShipped;

        return value ? TrackOrderButton : CheckDetailsButton;
    }
 }
 
 ```

**Step 3:** Bind the `DataTemplateSelector.DataTemplate` properties with the respective `DataTemplate` key values in the `DataGridTemplateColumn.CellTemplate`.

 
 ```xml
         <dataGrid:SfDataGrid.Columns>
            <dataGrid:DataGridTextColumn MappingName="OrderID" 
                                         Width="100"
                                         HeaderText="Order ID"/>
            <dataGrid:DataGridTextColumn MappingName="CustomerID" 
                                         Width="110"
                                         HeaderText="Customer ID"/>
            <dataGrid:DataGridTextColumn MappingName="Customer" 
                                         Width="150"
                                         HeaderText="Customer Name"/>
            <dataGrid:DataGridTextColumn MappingName="ShipCity" 
                                         Width="100"
                                         HeaderText="Ship City"/>
            <dataGrid:DataGridTextColumn MappingName="ShipCountry"
                                         Width="120"
                                         HeaderText="Ship Country"/>
            <dataGrid:DataGridDateColumn MappingName="ShippedDate" 
                                         Width="120"
                                         CellTextAlignment="Start"
                                         HeaderText="Shipped Date"/>
            <dataGrid:DataGridTextColumn MappingName="Price" 
                                         Width="70"
                                         HeaderText="Price"/>
            <dataGrid:DataGridTemplateColumn HeaderText="Status"
                                             Width="150">
                <dataGrid:DataGridTemplateColumn.CellTemplate>
                    <local:DetailsTemplateSelector TrackOrderButton="{StaticResource trackButton}"
                                                   CheckDetailsButton="{StaticResource detailsbutton}"/>
                </dataGrid:DataGridTemplateColumn.CellTemplate>
            </dataGrid:DataGridTemplateColumn>
        </dataGrid:SfDataGrid.Columns>
 ```


 
 ![DataGrid-template-selector.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE5MTQ1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.JSUh1IsKZdGLc3f1_BPHX9makVhwF2q41PCgf0cNKYI)

Download the complete sample in [GitHub](https://github.com/SyncfusionExamples/How-to-load-the-different-views-within-a-DataTemplate-based-on-a-condition).