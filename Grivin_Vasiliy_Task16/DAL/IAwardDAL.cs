using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Entities;

namespace DAL
{
	public interface IAwardDAL
	{
		
		void AddAward(string title, string description);

		bool RemoveAward(int awardID);

		bool UpdateAward(int awardID, string title, string description);

		List<Award> GetAwards();

		Award GetAward(int awardID);

	}
}
