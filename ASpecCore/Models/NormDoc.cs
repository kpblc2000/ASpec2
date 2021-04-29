namespace ASpecCore.Models
{
    public class NormDoc
    {
        private string _Name;
        private string _Description;
        public int Id { get; set; }
        public string Name { get => _Name; set { _Name = value.Trim(); } }
        public string Description { get => _Description; set { _Description = value.Trim(); } }
        public NormDocType DocType { get; set; }
    }
}
