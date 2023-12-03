using AssetRipper.HashAlgorithms;
using Contracts.BindingModels;
using Contracts.BusinessLogicContracts;
using Contracts.StorageContracts;
using Contracts.ViewModels;
using System.Text;
using System.Text.RegularExpressions;


namespace BusinessLogic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserStorage _userStorage;
        public UserLogic(IUserStorage userStorage)
        {
            _userStorage = userStorage;
        }
        public List<UserViewModel> Read(UserBindingModel model)
        {
            if (model == null)
            {
                return _userStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<UserViewModel> { _userStorage.GetElement(model) };
            }
            return _userStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(UserBindingModel model)
        {
            var element = _userStorage.GetElement(new UserBindingModel
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть пользователь с таким именем");
            }    
            if (model.Id.HasValue)
            {
                _userStorage.Update(model);
            }
            else
            {
                _userStorage.Insert(model);
            }
        }

        public void CheckPasswordLifeTime() 
        {
            var users = _userStorage.GetFullList();
            foreach (var user in users) 
            {             
                TimeSpan difference = DateTime.Now.Subtract(user.inUsage);
                int monthsDifference = (int)(difference.TotalDays / 30.436875); // Приближенное количество дней в месяце
                if (user.PasswordLifetime != 0 && monthsDifference > user.PasswordLifetime) 
                {
                    _userStorage.Update(new UserBindingModel {
                        Id = user.Id,
                        Name = user.Name,
                        Password = "",
                        PasswordLength = user.PasswordLength,
                        PasswordLifetime = user.PasswordLifetime,
                        isDisabled = user.isDisabled,
                        isLettersRequired = user.isLettersRequired,
                        isSymbolsRequired = user.isSymbolsRequired,
                        isAryphmsRequired = user.isAryphmsRequired,
                        inUsage = DateTime.Now
                    });
                }
            }
        }

        public void ChangePassword(UserBindingModel model)
        {
            var user = _userStorage.GetElement(new UserBindingModel
            {
                Name = model.Name,
            });

            if (user.isLettersRequired)
            {
                if (!Regex.IsMatch(model.Password, "[a-zA-Zа-яА-Я]"))
                {
                    throw new Exception("Пароль должен содержать хотя бы одну букву английского или русского алфавита.");
                }
            }
            if (user.isSymbolsRequired)
            {
                if (!Regex.IsMatch(model.Password, @"[\p{P}\p{S}]"))
                {
                    throw new Exception("Пароль должен содержать хотя бы один знак препинания.");
                }
            }
            if (user.isAryphmsRequired)
            {
                if (!Regex.IsMatch(model.Password, @"[\+\-\*/]"))
                {
                    throw new Exception("Пароль должен содержать хотя бы один знак арифметической операции.");
                }
            }
            if (user.PasswordLength != 0 && model.Password.Length < user.PasswordLength)
            {
                throw new Exception("Пароль должен быть длиной не менне " + user.PasswordLength + " символов.");
            }
            MD4 md4 = new MD4();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(model.Password);
            byte[] hashBytes = md4.ComputeHash(passwordBytes);
            _userStorage.Update(new UserBindingModel
            {
                Id = user.Id,
                Name = user.Name,
                Password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower(),
                PasswordLength = user.PasswordLength,
                PasswordLifetime = user.PasswordLifetime,
                isDisabled = user.isDisabled,
                isLettersRequired = user.isLettersRequired,
                isSymbolsRequired = user.isSymbolsRequired,
                isAryphmsRequired = user.isAryphmsRequired,
                inUsage = user.inUsage
            });
        }

        public void Delete(UserBindingModel model)
        {
            var element = _userStorage.GetElement(new UserBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Пользователь не найден");
            }
            _userStorage.Delete(model);
        }
    }
}
