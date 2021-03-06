﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver_Module
{
    class CellViewModel : INotifyPropertyChanged
    {
        public int? Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }
        private int? _number;


        #region Property Change Support

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
