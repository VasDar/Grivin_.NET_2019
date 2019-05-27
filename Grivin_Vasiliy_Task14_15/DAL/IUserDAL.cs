using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Entities;

namespace DAL
{
	interface IUserDAL
	{
		
		void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awardsID);

		bool RemoveUser(int userID);

		bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards);

		List<User> GetUsersList();

		User GetUser(int userID);
		
		
	}
}
