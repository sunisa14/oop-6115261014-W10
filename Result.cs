using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  oop_6115261014_w10
{
    class Result
    {
        private string ResultTitle; 
        private string ResultFName;
        private string ResultLname;

        public Result(string resultTitle, string resultFName, string resultLname)
        {
            this.resultTitle = resultTitle;
            this.resultFName = resultFName;
            this.resultLname = resultLname;
        }

        public string resultTitle { get => resultTitle; set => resultTitle = value; }
        public string resultFName { get => resultFName; set => resultFName = value; }
        public string resultLname { get => resultLname; set => resultLname = value; }
    }
}
