namespace ProjectVPK;

public partial class LogPage: ContentPage
{
    public LogPage()
    {
        InitializeComponent();
    }

    private void LogInBtnClicked(object sender, EventArgs e)
    {
        string email = loggInField.Text;
        string password = passField.Text;
        
        if ((email.Length < 5 || !email.Contains('@') || !email.Contains('.') || email == null) & (password == "" || password.Length < 5))
        {
            errorText.Text = "Неверно указан пароль и email";
        }
        else if (email.Length < 5 || !email.Contains('@') || !email.Contains('.') || email == " ")
            errorText.Text = "Неверно указан email";
        else if (password == " " || password.Length < 5)
        {
            errorText.Text = "Неверно указан пароль";
        }
        else
        {
            errorText.Text = "";
            email = "";
            passField.Text = "";
            DisplayAlert("Вход успешен", "Для продолжения нажмите далее", "Далее");
        }
     }

    private async void SingUpBtnClicked(object sender, EventArgs e)
    {
        
       await Navigation.PushAsync(new SingUpPage());

    }
}