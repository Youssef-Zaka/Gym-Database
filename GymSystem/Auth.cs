using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    public sealed class Auth
    {
        private Auth()
        {
        }
        private static readonly Lazy<Auth> lazy = new Lazy<Auth>(() => new Auth());
        public static Auth Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private int Client_ID = 1;
        public int getClient_ID()
        {
            return this.Client_ID;
        }
        public void setClient_ID(int id)
        {
            this.Client_ID = id;
        }
    }

}
