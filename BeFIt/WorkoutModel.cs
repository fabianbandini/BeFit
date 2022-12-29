using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeFIt
{
    public class WorkoutModel : INotifyPropertyChanged
    {
        int _id;
        string _name;
        string _desc;
        int _sets;
        public int Id
        {
            get
            {
                return this._id;
            }

            set
            {
                if (value != this._id)
                {
                    this._id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Sets
        {
            get
            {
                return this._sets;
            }

            set
            {
                if (value != this._sets)
                {
                    this._sets = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (value != this._name)
                {
                    this._name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Desc
        {
            get
            {
                return this._desc;
            }

            set
            {
                if (value != this._desc)
                {
                    this._desc = value;
                    NotifyPropertyChanged();
                }
            }
        }
       
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
