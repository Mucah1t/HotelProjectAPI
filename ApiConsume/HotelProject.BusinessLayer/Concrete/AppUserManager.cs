﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TInsert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
           return _appUserDal.UsersListWithWorkLocations();
        }
    }
}
