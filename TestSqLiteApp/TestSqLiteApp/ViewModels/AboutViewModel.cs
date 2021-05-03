using System;
using System.Windows.Input;
using TestSqLiteApp.Entiyes;
using TestSqLiteApp.Repository;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestSqLiteApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private FriendRepository _friendRepository;
        public AboutViewModel()
        {
            _friendRepository = DependencyService.Get<FriendRepository>();
            
            Title = "About";
        }

        public ICommand AddItemCommand => new Command(AddItem);

        public ICommand ShowItemCommand => new Command(ShowItem);

        public void AddItem()
        {
            var friend = new Friend
            {
                Email = "dsad@",
                Name = "Vasya",
                Phone = "8919"
            };
            _friendRepository.SaveItem(friend);
        }

        public void ShowItem()
        { 
            var  a = _friendRepository.GetItems();
        }
    }
}