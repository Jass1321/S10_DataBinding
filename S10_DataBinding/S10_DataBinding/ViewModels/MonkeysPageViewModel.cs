using System;
using System.Collections.Generic;
using System.Text;
using S10_DataBinding.Models;
using S10_DataBinding.Services;

namespace S10_DataBinding.ViewModels
{
    class MonkeysPageViewModel : ViewModelBase
    {
        public IList<Monkey> Monkeys { get { return MonkeyData.Monkeys; } }

        Monkey selectedMonkey;
        public Monkey SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
