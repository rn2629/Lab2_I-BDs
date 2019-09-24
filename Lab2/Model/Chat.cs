using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Chat : Animal
    {
        private string couleurChat;
        public Chat(string _nomChat, int _ageChat, string _couleurChat):base("Tom", 79)
        {
            CouleurChat = _couleurChat;
        }


        public string CouleurChat
        {
            get { return couleurChat; }
            set { couleurChat = value ; }
        }

        
    }
}
