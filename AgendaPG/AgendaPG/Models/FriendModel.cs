using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AgendaPG.Models
{
    public class FriendModel : INotifyProperyChanged
    {
        private int idFriend;

        [PrimaryKey]
        public int IdUsuario
        {
            get; set;
        }

        public string Nome
        {
            get; set;
        }

        public int Level
        {
            get; set;
        }
    }
}
