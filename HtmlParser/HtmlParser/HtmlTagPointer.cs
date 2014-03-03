using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlParser
{
    public class HtmlTagPointer
    {
        private int startLineNumber;
        public int StartLineNumber
        {
            get { return startLineNumber; }
            set { startLineNumber = value; }
        }

        private int endLineNumber;
        public int EndLineNumber
        {
            get { return endLineNumber; }
            set { endLineNumber = value; }
        }

        public HtmlTagPointer()
        {

        }

        public HtmlTagPointer(int start, int end)
        {
            this.startLineNumber = start;
            this.endLineNumber = end;
        }

    }
}
