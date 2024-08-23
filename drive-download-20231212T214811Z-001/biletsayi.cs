using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_satishi
{
    class biletsayi
    {
        public int empty { get; set; }
        public int full { get; set; }
        //public int empty = 10;
        //public int full = 0;
        private int No;
        private bool key;
        private int index;
        private int length;

        public void setNo(int No) { this.No = No; }

        public int getNo() { return this.No; }
        public void setKey(bool Key) { this.key = Key; }

        public bool getKey() { return this.key; }

        public void setIndex(int Index) { this.index = Index; }

        public int getIndex() { return this.index; }

        public void setLength(int Length) { this.length = Length; }

        public int getLength() { return this.length; }
    }
}
