using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM.Model;
using System.Windows;
using System.Windows.Input;


namespace Wpf_MVVM.ViewModel
{
    internal class MainViewModel
    {
        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            People = new PeopleModel
            {
                FirstName = "First name",
                LastName = "Last name"
            };
        }
        #endregion
        #region Properties
        /// <summary>
        /// Get or set people.
        /// </summary>
        public PeopleModel People { get; set; }
        #endregion
    }
}
