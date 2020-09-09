using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261014_w10
{
    class Wijai
    {
        private string wijaiName;
        private string wijaiPage;
        private string wijaihPublisher;
        private string wijaiDate;
        private string wijaiRank;
        private string wijaiWeight;

        public Wijai(string wijaiName, string wijaiPage, string wijaihPublisher, string  wijaiDate, string wijaiRank, string wijaiWeight)
        {
            this.wijaiName = wijaiName;
            this.wijaiPage = wijaiPage;
            this.wijaihPublisher = wijaihPublisher;
            this. wijaiDate =  wijaiDate;
            this.wijaiRank = wijaiRank;
            this.wijaiWeight = wijaiWeight;
        }

        public string WijaiName { get => wijaiName; set => wijaiName = value; }
        public string WijaiPage { get => wijaiPage; set => wijaiPage = value; }
        public string WijaihPublisher { get => wijaihPublisher; set => wijaihPublisher = value; }
        public string  WijaiDate { get =>  wijaiDate; set =>  wijaiDate = value; }
        public string WijaiRank{ get => wijaiRank; set => wijaiRank = value; }
        public string WijaiWeight { get => wijaiWeight; set => wijaiWeight = value; }
    }
}
