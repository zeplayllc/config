using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigINPCTesting
{
    public interface IMySettings : INotifyPropertyChanged
    {
        string Setting1 { get; set; }
    }
}
