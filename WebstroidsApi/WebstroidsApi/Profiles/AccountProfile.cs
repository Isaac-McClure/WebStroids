using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebstroidsApi.Entities;
using WebstroidsApi.Dtos;

namespace WebstroidsApi.Profiles
{
	public class AccountProfile : Profile
	{
		public AccountProfile()
		{
			CreateMap<Account, AccountDto>();
		}
	}
}
