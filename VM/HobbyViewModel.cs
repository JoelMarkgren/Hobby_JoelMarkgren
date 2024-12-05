
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobbys_JoelMarkgren.VM
{
    class HobbyViewModel : ViewModelBase
    {
		private ObservableCollection<string> hobbies = new();

		public ObservableCollection<string> Hobbies
		{	
			get { return hobbies; }
			set { hobbies = value;
				OnPropertyChanged();
			}
		}

		private string newHobby;

		public string NewHobby
		{
			get { return newHobby; }
			set { newHobby = value;
				OnPropertyChanged();
			}			
		}

		public DelegateCommand AddCommand { get; }

		public HobbyViewModel()
		{
			Hobbies = new ObservableCollection<string> { "Judo", "Fågelskådning", "Simning" };
			AddCommand = new DelegateCommand(AddHobby);
		}

		public void AddHobby(object? parameter)
		{
			Hobbies.Add(NewHobby);
			NewHobby = string.Empty;
		}
	}
}
