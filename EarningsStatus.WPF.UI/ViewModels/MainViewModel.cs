﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }
        public MainViewModel()
        {
            CurrentViewModel = new AddGoldViewModel();
        }
    }
}
