﻿using System.Collections.Generic;

namespace P5
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> _AppUsers;

        public FakeAppUserRepository()
        {
            // A temporary dictionary to fake a database
            _AppUsers = new Dictionary<string, AppUser>();
            _AppUsers.Add("dave", new AppUser
            {
                UserName = "dave",
                Password = "go",
                FirstName = "Dave",
                LastName = "Bishop",
                EmailAddress = "david.b.bishop@gmail.com",
                IsAuthenticated = false
            });
            _AppUsers.Add("Kyle", new AppUser
            {
                UserName = "Kyle",
                Password = "fast",
                FirstName = "Kyle",
                LastName = "Gosh",
                EmailAddress = "Kyle.Gosh@trojans.dsu.edu",
                IsAuthenticated = false
            });
            _AppUsers.Add("Andrew", new AppUser
            {
                UserName = "Andrew",
                Password = "big",
                FirstName = "Andrew",
                LastName = "Stange",
                EmailAddress = "andrew.stange@trojans.dsu.edu",
                IsAuthenticated = false
            });
        }
        public bool Login(string UserName, string givenPassword)
        {
            bool match = false;
            AppUser appUser;
            if (_AppUsers.TryGetValue(UserName,out appUser))
            {
                match = appUser.Password == givenPassword;
            }
            return match;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            _AppUsers[UserName].IsAuthenticated = IsAuthenticated;
        }
        public List<AppUser> GetAll()
        {
            List<AppUser> appUsers = new List<AppUser>();
            foreach (AppUser appUser in _AppUsers.Values)
            {
                appUsers.Add(appUser);
            }
            return appUsers;
        }
        public AppUser GetByUserName(string UserName)
        {
            AppUser curUser;
            try
            {
                curUser = _AppUsers[UserName];
            }
            catch
            {
                curUser = null;
            }
            return curUser;
        }
    }
}
