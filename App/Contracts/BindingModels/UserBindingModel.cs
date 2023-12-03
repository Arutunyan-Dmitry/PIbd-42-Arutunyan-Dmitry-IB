namespace Contracts.BindingModels
{
    public class UserBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int PasswordLength { get; set; }
        public int PasswordLifetime { get; set; }
        public bool isDisabled { get; set; }
        public bool isLettersRequired { get; set; }
        public bool isSymbolsRequired { get; set; }
        public bool isAryphmsRequired { get; set; }
        public DateTime inUsage { get; set; }
    }
}
