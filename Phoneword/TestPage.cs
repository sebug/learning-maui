namespace Phoneword;

public partial class TestPage : ContentPage {
    int count = 0;

    Label counterLabel;

    public TestPage()
    {
        var myScrollView = new ScrollView();
        var myStackLayout = new StackLayout();
        myScrollView.Content = myStackLayout;

        counterLabel = new Label
        {
            Text = "Current count: 0",
            FontSize = 18,
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center
        };
        myStackLayout.Children.Add(counterLabel);

        var myButton = new Button
        {
            Text = "Clickety me",
            HorizontalOptions = LayoutOptions.Center
        };
        myStackLayout.Children.Add(myButton);

        myButton.Clicked += OnCounterClicked;

        this.Content = myScrollView;
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count += 1;
        counterLabel.Text = "Current count: " + count;
        SemanticScreenReader.Announce(counterLabel.Text);
    }
}