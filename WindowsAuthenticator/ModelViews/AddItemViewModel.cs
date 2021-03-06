﻿using System.Diagnostics;

namespace WindowsAuthenticator.ModelViews
{
    internal class AddItemViewModel : EditItemViewModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _secret;

        public string Secret
        {
            [DebuggerStepThrough]
            get { return _secret; }
            set
            {
                if (_secret != value)
                {
                    _secret = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}