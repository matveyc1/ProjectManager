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
            errorText.Text = "������� ������ ������ � email";
        }
        else if (email.Length < 5 || !email.Contains('@') || !email.Contains('.') || email == " ")
            errorText.Text = "������� ������ email";
        else if (password == " " || password.Length < 5)
        {
            errorText.Text = "������� ������ ������";
        }
        else
        {
            errorText.Text = "";
            email = "";
            passField.Text = "";
            DisplayAlert("���� �������", "��� ����������� ������� �����", "�����");
        }
     }

    private async void SingUpBtnClicked(object sender, EventArgs e)
    {
        
       await Navigation.PushAsync(new SingUpPage());

    }
}