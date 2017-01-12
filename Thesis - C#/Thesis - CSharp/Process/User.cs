using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesis___CSharp.Process
{
    class User
    {
        private int id;
        private String name;
        private String username;
        private String password;

        public User(int id, String name, String username, String password) {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
        }


        public User(String name, String username, String password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public int getId() {
            return this.id;
        }

        public void setId(int id) {
            this.id = id;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getUsername()
        {
            return this.username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }
        public String getPassword()
        {
            return this.password;
        }

        public void serPassword(String password)
        {
            this.password = password;
        }
    }
}
