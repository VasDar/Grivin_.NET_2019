using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DAL
{
	public class UserList : IUserDAL
	{
		
		private int ID;
		private List<User> users = new List<User>();

		public void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awards)
		{
			users.Add(new User(ID++, firstName, secondName, birthDay, awards));
		}

		public bool RemoveUser(int userID)
		{
			foreach (User user in users)
			{
				if (user.ID == userID)
				{
					users.Remove(user);
					return true;
				}
			}

			throw new Exception("Remove User exception ");
		}

		public bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards)
		{
			foreach (User user in users)
			{
				if (user.ID == userID)
				{
					user.UpdateUser(firstName, secondName, birthDay, awards);
					return true;
				}
			}

			throw new Exception("Update User exception");
		}

		public List<User> GetUsersList()
		{
			return users;
		}

		public bool RemoveUsersAward(int awardID)
		{
			foreach (User user in users)
			{
				user.RemoveUserAward(awardID);

			}

			return true;
		}

		public User GetUser(int userID)
		{
			foreach (User user in users)
			{
				if (user.ID == userID)
				{
					return user;
				}

			}

			throw new Exception("Get User Exception");
		}
		

	
	}
}
