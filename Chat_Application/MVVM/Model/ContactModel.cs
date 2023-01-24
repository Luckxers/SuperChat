using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application.MVVM.Model
{
    class ContactModel
    {
        public string Username { get; set; }
        public string imageSource { get; set; }
        public ObservableCollection<MessageModel> Messages { get; set; }
        public string lastMessage => Messages.Last().Message;

    }
}
