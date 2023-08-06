﻿using System;
using System.ComponentModel;

namespace Plumber.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        protected BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            OnDispose();
        }

        protected virtual void OnDispose()
        {
        }
    }
}