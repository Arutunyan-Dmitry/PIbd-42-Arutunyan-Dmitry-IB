using Contracts.BindingModels;
using Contracts.StorageContracts;
using Contracts.ViewModels;
using FileImplement.Models;

namespace FileImplement.Implements
{
    public class UserStorage : IUserStorage
    {
        private readonly FileDataListSingleton source;
        public UserStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<UserViewModel> GetFullList()
        {
            return source.Users.Select(CreateModel).ToList();
        }
        public List<UserViewModel> GetFilteredList(UserBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Users.Where(rec => rec.Name.Contains(model.Name))
           .Select(CreateModel)
           .ToList();
        }
        public UserViewModel GetElement(UserBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var user = source.Users
                .FirstOrDefault(rec => rec.Name == model.Name || rec.Id == model.Id);
            return user != null ? CreateModel(user) : null;
        }
        public void Insert(UserBindingModel model)
        {
            int maxId = source.Users.Count > 0 ? source.Users.Max(rec => rec.Id) : 0;
            var element = new User { Id = maxId + 1 };
            model.inUsage = DateTime.Now;
            source.Users.Add(CreateModel(model, element));
        }
        public void Update(UserBindingModel model)
        {
            var element = source.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }
        public void Delete(UserBindingModel model)
        {
            User element = source.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                if (element.Name != "ADMIN") {
                    source.Users.Remove(element);
                } else
                {
                    throw new Exception("Администратора невозможно удалить");
                }
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private static User CreateModel(UserBindingModel model, User user)
        {
            user.Name = model.Name;
            user.Password = model.Password;
            user.PasswordLength = model.PasswordLength;
            user.PasswordLifetime = model.PasswordLifetime;
            user.isDisabled = model.isDisabled;
            user.isLettersRequired = model.isLettersRequired;
            user.isSymbolsRequired = model.isSymbolsRequired;
            user.isAryphmsRequired = model.isAryphmsRequired;
            user.inUsage = model.inUsage;
            return user;
        }
        private static UserViewModel CreateModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Password = user.Password,
                PasswordLength = user.PasswordLength,
                PasswordLifetime = user.PasswordLifetime,
                isDisabled = user.isDisabled,
                isLettersRequired = user.isLettersRequired,
                isSymbolsRequired = user.isSymbolsRequired,
                isAryphmsRequired = user.isAryphmsRequired,
                inUsage = user.inUsage
            };
        }
    }
}
