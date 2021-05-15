using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChainStores.Core
{
    class ObservableObject : INotifyPropertyChanged //Механизм привязки изменения элемента формы
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));// вызвать делегат который принадлежит основному дескриптору
        }
    }
}
