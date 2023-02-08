using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTextEditiorL4DC
{
    class CLSuserRGISTER
    {
        private String USERID, USERNAME, PASSWORD, EMAIL;
        public String userid
        {
            get
            {
                return USERID;
            }
            set
            {
                USERID = value;
            }
        }
        public String username
        {
            get
            {
                return USERNAME;
            }
            set
            {
                USERNAME= value;
            }
        }
        public String password
        {
            get
            {
                return PASSWORD;
            }
            set
            {
                PASSWORD  = value;
            }
        }
        public String email
        {
            get
            {
                return EMAIL;
            }
            set
            {
                EMAIL  = value;
            }
        }
    }
}
