using System.ComponentModel;

namespace Contracts.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [DisplayName("Имя пользователя")]
        public string Name { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Минимальная длина пароля")]
        public int PasswordLength { get; set; }
        [DisplayName("Срок действия пароля (мес)")]
        public int PasswordLifetime { get; set; }
        [DisplayName("Блокировка пользователя")]
        public bool isDisabled { get; set; }
        [DisplayName("Наличие букв в пароле")]
        public bool isLettersRequired { get; set; }
        [DisplayName("Наличие знаков препинания в пароле")]
        public bool isSymbolsRequired { get; set; }
        [DisplayName("Наличие знаков арифм. операций в пароле")]
        public bool isAryphmsRequired { get; set; }
        [DisplayName("Пользуется с")]
        public DateTime inUsage { get; set; }
    }
}
