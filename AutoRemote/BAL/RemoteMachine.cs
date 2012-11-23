using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRemote.BAL
{
    class RemoteMachine
    {

        public static List<RemoteMachine> list = new List<RemoteMachine>();

        public string IP, Title, Username, Password, Description, FilePath;

        public RemoteMachine()
        {
        }
        public RemoteMachine(string _IP, string _Title, string _Username, string _Password, string _Description, string _FilePath)
        {
            IP = _IP;
            Title = _Title;
            Username = _Username;
            Password = _Password;
            Description = _Description;
            FilePath = _FilePath;
        }

        public static List<RemoteMachine> GetList(string search)
        {
            if (search == "")
            {
                return list;
            }

            search = search.ToLower();
            var qry=from c in list
                    where c.IP.ToLower().Contains(search) ||  c.Title.ToLower().Contains(search)
                    select c;

            return  qry.ToList();
        }
    }
}
