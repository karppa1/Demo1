using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_2.Model
{
    /// <summary>
    /// This class holds employee properties.
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.        
        /// </summary>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string ID { get; set; }
        private string firstname;
        public string Firstname
        {
            get
            {
                // return employees firstname
                return firstname;
            }
            set
            {
                // set a new value for firstname
                firstname = value;
                // set a new value for Fullname
                Fullname = firstname + lastname;
                // raise firtstname property changed method
                RaisePropertyChanged();
            }
        }
        private string lastname;
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                Fullname = firstname + lastname;
                RaisePropertyChanged();
            }
        }
        private string jobTitle;
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
                RaisePropertyChanged();
            }
        }
        private EmployeeImage image;
        public EmployeeImage Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                RaisePropertyChanged();
            }
        }

        private string fullname;
        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
            set
            {
                fullname = value;
                RaisePropertyChanged();
            }
        }
    }

    /// <summary>
    /// This class holds employee view model data.
    /// </summary>
    public class EmployeeViewModel
    {
        // private List<Employee> employees = new List<Employee>();
        // public List<Employee> Employees { get { return employees; } }
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public void AddEmployee(string firstName, string lastName, string jobTitle, EmployeeImage image)
        {
            employees.Add(new Employee { ID = "1001", Firstname = firstName, Lastname = lastName, JobTitle = jobTitle, Image = image });
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public EmployeeViewModel()
        {
        }
    }
}
