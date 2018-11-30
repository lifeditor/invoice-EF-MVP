using System;

namespace Invoice
{
    internal class CustomEventArgs : EventArgs
    {
        private int _tag;
        private bool _checked;

        internal bool Checked { get => _checked; set => _checked = value; }

        internal CustomEventArgs(int tag = 0)
        {
            _tag = tag;
        }

        internal int Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
    }
}
