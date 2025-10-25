using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.ModelViewVM.Models;

namespace MVVM.ModelViewVM.ViewModels
{
    internal class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewsModel()
        {
            Person = new Person()
            {
                Name = "Jose",
                Age = 30,
                Married = true,
                Birthday = new DateTime(1993, 1, 1),
                Wight = 70,
                LunchTime = new TimeSpan(14, 0, 0)
            };
        }
    }
}
