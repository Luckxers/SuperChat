using Chat_Application.Core;
using Chat_Application.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application.MVVM.ViewModel
{
    internal class MainViewModel: ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        /*  COMMANDS  */

        public RelayCommand SendCommand { get; set; }

        private ContactModel _SelectedContact;

        public ContactModel SelectedContact
        {
            get { return _SelectedContact; }
            set { _SelectedContact = value;
            OnPropertyChanged();}  
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value;
                OnPropertyChanged();
            }
        }
            
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            SendCommand = new RelayCommand(o => 
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";

            });

            Messages.Add(new MessageModel
            {
                Username = "Jesus Varela",
                UsernameColor = "#BA55D3",
                imageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Como estas",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for(int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Jesus Varela",
                    UsernameColor = "#BA55D3",
                    imageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Como estas",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Carlos Henriquez",
                    UsernameColor = "#BA55D3",
                    imageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Carlos Henriquez",
                UsernameColor = "#BA55D3",
                imageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
            });

            for(int i = 0; i < 5 ; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Jesus Varela {i}",
                    imageSource = "https://i.imgur.com/i2szTsp.png",
                    Messages = Messages
                });
            }

        }

    }
}
