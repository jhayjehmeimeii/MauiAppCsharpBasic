using MauiAppCsharpBasic;
using MauiAppCsharpBasic.Classes;

namespace MauiAppCsharpBasic;

public partial class MainPage : ContentPage
{
    Car audi;
    Car nissan;
    bool isFinish = false;
    public MainPage()
    {
        InitializeComponent();

        audi = new Car("A1", 220, 10);
        audi.UseFuelRate = 10;
        nissan = new Car("S1", 180, 3);
        nissan.UseFuelRate = 8;
    }

        private void Button_Clicked(object sender, EventArgs e)
    {

        if (!this.isFinish)
        {
            var screenWidth = Application.Current.MainPage.Width;
            this.AudiRun(screenWidth);
            this.NisanRun(screenWidth);
            this.myLabel.Text = audi.ShowInfo() + "\n" + nissan.ShowInfo();
            this.isFinish = true; 
        }
        else
        {
            ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
            ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
            this.isFinish = false;
        }
    }
    private void AudiRun (double distance)
    {
        var timeuse = audi.TimeUseeForRun(distance);
        ImageCar1.TranslateTo(distance - 100, 0, timeuse*1000, Easing.Linear);
    }
    private void NisanRun(double distance)
    {
        var timeuse = nissan.TimeUseeForRun(distance);
        ImageCar2.TranslateTo(distance - 100, 0, timeuse * 1000, Easing.Linear);
    }
}
