using AutoMapper;
using Domain.Models;
using InfraStructure.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
	public class MyProfile : Profile
	{
		public MyProfile()
		{
			CreateMap<Domain.Models.User, InfraStructure.Entity.User>();
		}
	}
}
