using Contracts.BindingModels;
using Contracts.ViewModels;

namespace Contracts.BusinessLogicContracts
{
    public interface IUserLogic
    {
        List<UserViewModel> Read(UserBindingModel model);
        void CreateOrUpdate(UserBindingModel model);
        void CheckPasswordLifeTime();
        void ChangePassword(UserBindingModel model);
        void Delete(UserBindingModel model);
    }
}
