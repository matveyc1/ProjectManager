using ProjectVPK.Models;

namespace ProjectVPK;

public partial class SingUpPage : ContentPage
{
        public string ItemId 
    {
        set
        {
            LoadNote(value);
        } 
    }

    public SingUpPage()
    {
        InitializeComponent();

        BindingContext = new Note();
    }
    
    private async void LoadNote(string value)
    {
        try
        {
            int id = Convert.ToInt32(value);

            Note note = await App.NotesDB.GetNoteByIdAsync(id);

            BindingContext = note;
        }

        catch { }
    }

    private async void RegistrationClicked(object sender, EventArgs e)
    {
        Note note = (Note)BindingContext;

        if (!string.IsNullOrEmpty(note.email) & !string.IsNullOrEmpty(note.password))
        {
            await App.NotesDB.SaveNoteAsync(note);
            await DisplayAlert("Успешно", "Войдите в свой аккаунт", "Далее");
        } else
        {
            await DisplayAlert("Ошибка", "Данный пользователь уже существует", "Далее");
        }
        
    }

    private async void SingInBtnClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new LogPage());

    }
}