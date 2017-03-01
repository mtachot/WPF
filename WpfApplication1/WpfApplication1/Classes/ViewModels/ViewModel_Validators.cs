using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes.ViewModels
{
    public class ViewModel_Validators
    {
        public ViewModel_Validators()
        {
            // Set default age
            this.Age = 30;
        }

        public int Age { get; set; }
    }
}
