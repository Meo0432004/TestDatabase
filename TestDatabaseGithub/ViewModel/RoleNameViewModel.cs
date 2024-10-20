using Chap8_DB_Code_First.Utility;
using Chap8_DB_Code_First.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestDatabaseGithub.Entities;

namespace TestDatabaseGithub.ViewModel
{
    class RoleNameViewModel: BaseViewModel
    {
        public ObservableCollection<RoleName> Roles { get; set; }
        DBContext dbContext;
        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand UpdateCommand { get; }

        public RoleNameViewModel()
        {
            dbContext = new DBContext();
            Roles = new ObservableCollection<RoleName>(dbContext.RoleNames.ToList());
            
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private string _roleName;
        public string RoleName
        {
            get => _roleName;
            set
            {
                _roleName = value;
                OnPropertyChanged(nameof(RoleName));
            }
        }
    }
}
