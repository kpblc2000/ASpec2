namespace ASpecCore.Models
{
    public class User
    {
        public int Id { get; set; }
        /// <summary>Имя</summary>
        public string FirstName { get; set; }
        /// <summary>Отчество</summary>
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Domain { get; set; }
        public bool IsDeveloper { get; set; }
    }
}
