using AutoMapper;
using InfraStructure.Database;
using InfraStructure.Entity;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class UserRpository: GenericRepository<User>
	{
		public UserRpository(MyDbContext _context):base(_context){}
	}
}
