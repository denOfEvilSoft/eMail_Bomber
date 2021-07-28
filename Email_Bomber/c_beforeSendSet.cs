using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Bomber
{
    class c_beforeSendSet
    {
        private string sendName;
        private string targetName;
        private string title;
        private string includeString;

        public c_beforeSendSet(string sendName, string sendMailSet, string targetName, string targetMailSet, string title, string includeString)
        {
            this.sendName = sendName + sendMailSet;
            this.targetName = targetName + targetMailSet;
            this.title = title;
            this.includeString = includeString;
        }
        public string get_sendName()
        {
            return sendName;
        }
        public string get_targetName()
        {
            return targetName;
        }
        public string get_title()
        {
            return title;
        }
        public string get_includeString()
        {
            return includeString;
        }
    }
}
