namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullname, string email, DateTime birthDate)
        {
            Fullname = fullname;
            Email = email;
            BirthDate = birthDate;
        }

        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}