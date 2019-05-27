using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
	public class Storage
	{
		AwardList awardDAL = new AwardList();
		UserList userDAL = new UserList();
		User user1 = new User(1, "Василий", "Гривин", new DateTime(1998, 04, 3), null);

			public void AddAward(string title, string description)
		{
			awardDAL.AddAward(title, description);
		}

			public void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awards)
			{

				userDAL.AddUser(firstName, secondName, birthDay, awards);
			}

			public Award GetAward(int awardID)
			{
				return awardDAL.GetAward(awardID);
			}

			public List<Award> GetAwards()
			{
				return awardDAL.GetAwards();
			}

			public User GetUser(int userID)
			{
				return userDAL.GetUser(userID);
			}

			public List<User> GetUsersList()
			{
				return userDAL.GetUsersList();
			}

			public bool RemoveAward(int awardID)
			{
				userDAL.RemoveUsersAward(awardID);
				awardDAL.RemoveAward(awardID);
				return true;
			}

			public bool RemoveUser(int userID)
			{
				userDAL.RemoveUser(userID);
				return true;
			}

			public bool UpdateAward(int awardID, string title, string description)
			{
				awardDAL.UpdateAward(awardID, title, description);
				return true;
			}

			public bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards)
			{
				userDAL.UpdateUser(userID, firstName, secondName, birthDay, awards);
				return true;
			}

			public List<User> SortUsersByFirstNameDesc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.FirstName ascending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result;
		}

			public List<User> SortUsersByFirstNameAsc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.FirstName descending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result; ;
		}

			public List<User> SortUsersByLastNameDesc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.LastName ascending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result;
		}

			public List<User> SortUsersByLastNameAsc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.LastName descending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result; ;
		}
	
			public List<User> SortUsersByBirthdayDesc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.BirthDay ascending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result;
		}

			public List<User> SortUsersByBirthdayAsc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.BirthDay descending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result; ;
		}

			public List<User> SortUsersByAgeDesc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.Age ascending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result;
		}

			public List<User> SortUsersByAgeAsc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.Age descending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result; ;
		}

			public List<User> SortUsersByAwardsDesc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.StrOfUsersAwawrds ascending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result;
		}

			public List<User> SortUsersByAwardsAsc()
		{
			IEnumerable<User> userslist = GetUsersList();

			userslist = (from s in userslist
						 orderby s.StrOfUsersAwawrds descending
						 select s);

			List<User> result = userslist.ToList<User>();

			return result; ;
		}

			public List<Award> SortAwardsByTitleDesc()
		{
			IEnumerable<Award> awardsList = GetAwards();

			awardsList = (from s in awardsList
						  orderby s.Title ascending
						  select s);

			List<Award> result = awardsList.ToList<Award>();

			return result;
		}

			public List<Award> SortAwardsByTitleAsc()
		{
			IEnumerable<Award> awardsList = GetAwards();

			awardsList = (from s in awardsList
						  orderby s.Title descending
						  select s);

			List<Award> result = awardsList.ToList<Award>();

			return result; ;
		}

			public List<Award> SortAwardsByDescriptionDesc()
		{
			IEnumerable<Award> awardsList = GetAwards();

			awardsList = (from s in awardsList
						  orderby s.Description ascending
						  select s);

			List<Award> result = awardsList.ToList<Award>();

			return result;
		}

			public List<Award> SortAwardsByDescriptionAsc()
		{
			IEnumerable<Award> awardsList = GetAwards();

			awardsList = (from s in awardsList
						  orderby s.Description descending
						  select s);

			List<Award> result = awardsList.ToList<Award>();

			return result; ;
		}

	}
}
