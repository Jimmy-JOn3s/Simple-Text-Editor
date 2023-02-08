using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTextEditiorL4DC
{
    class clsFile
    {
        public string Fno, Fname, uid;
        public string FileNO
        {
            get
            {
                return Fno;
            }
            set
            {
                Fno = value;
            }
        }
        public string FileName
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public string userid
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }
    }
}
