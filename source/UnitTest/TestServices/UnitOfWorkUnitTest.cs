namespace TestServices
{
    using Pulse.Core.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pulse.Core.Repository.Entity;
    using Pulse.Domain;
    using Pulse.Domain.Entity;
    using System.Security.Principal;
    using Moq;

    public class UnitOfWorkUnitTest : IUnitOfWork
    {

        public IRepository<Client> Clients => new Mock<IRepository<Client>>().Object;

        public IRepository<ClientsCountries> ClientsCountries => new Mock<IRepository<ClientsCountries>>().Object;

        public IRepository<Country> Countries => new Mock<IRepository<Country>>().Object;

        public IRepository<EncryptionUser> EncryptionUsers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Group> Groups
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<History> Histories
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Kiosk> Kiosks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<KioskSecurity> KioskSecurities
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPrincipal PrincipalUser
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<RefreshToken> RefreshTokens
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<UserProfile> UserProfiles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Commit()
        {
        }

        public Task CommitAsync()
        {
            return Task.FromResult(0);
        }

        public void Dispose()
        {
        }
    }
}
