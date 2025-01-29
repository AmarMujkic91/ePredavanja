using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public class UsersService : BaseCRUDService<Model.Users, UsersSearchObject,Database.Users,UsersInsertRequests,UsersUpdateRequests>,IUsersService
    {
        ILogger<UsersService> _logger;

        public UsersService(eGostujucaPredavanjaContext dbContext, IMapper mapper, ILogger<UsersService> logger) : base(dbContext,mapper)
        {
            _logger = logger;
        }

        //public virtual Model.PagedResult<Model.Users> GetList(UsersSearchObject searchObject)
        //{   
        //    var query = _dbContext.Users.AsQueryable();

        //    int count = query.Count();

        //    if (!string.IsNullOrWhiteSpace(searchObject?.FirstNameGTE))
        //    {
        //        query = query.Where(x => x.Firstname.StartsWith(searchObject.FirstNameGTE));
        //    }

        //    if (!string.IsNullOrWhiteSpace(searchObject?.LastNameGTE))
        //    {
        //        query = query.Where(x => x.Lastname.StartsWith(searchObject.LastNameGTE));
        //    }
        //    if (!string.IsNullOrWhiteSpace(searchObject?.Email))
        //    {
        //        query = query.Where(x => x.Email==searchObject.Email);
        //    }

        //    if (!string.IsNullOrEmpty(searchObject?.UserName))
        //    {
        //        query = query.Where(x => x.UserName==searchObject.UserName);
        //    }

        //    if(searchObject.IsUserPositionIncluded == true)
        //    {
        //        query = query.Include(x => x.UserPositions).ThenInclude(x => x.Positions);
        //    }

        //    if(!string.IsNullOrWhiteSpace(searchObject.OrderBy))
        //    {
        //        var item = searchObject.OrderBy.Split(' ');
        //        if(item.Length > 2 || item.Length == 0) 
        //        {
        //            throw new ApplicationException("You can only sort by one field ");
        //        }
        //        if (item.Length == 1)
        //        {
        //            query = query.OrderBy("@0", searchObject.OrderBy);
        //        }
        //        else
        //        {
        //            query = query.OrderBy(string.Format("{0} {1}", item[0], item[1]));
        //        }
        //    }

        //    if(searchObject?.Page.HasValue == true && searchObject?.PageSize.HasValue == true)
        //    {
        //        query = query.Skip(searchObject.Page.Value * searchObject.PageSize.Value).Take(searchObject.PageSize.Value);
        //    }



        //    var list = query.ToList();

        //    List<Model.Users> konvertedList = new List<Model.Users>();

        //    konvertedList = _mapper.Map(list, konvertedList);
        //    //DA smo gore ostavili da je funkcija List<Model.Users> GetList a ne Model.PagedResult<Model.Users> GetList
        //    //return konvertedList;

        //    //ovo dole ide ako hocemo da idemo po novom 
        //    Model.PagedResult<Model.Users> pagedListResult = new Model.PagedResult<Model.Users>();
        //    pagedListResult.Count = count;
        //    pagedListResult.ResultList = konvertedList;

        //    return pagedListResult;
        //}

        public override IQueryable<Database.Users> AddFilter(UsersSearchObject search, IQueryable<Database.Users> query)
        {
            query = base.AddFilter(search, query);

            if (!string.IsNullOrWhiteSpace(search?.FirstNameGTE))
            {
                query = query.Where(x => x.Firstname.StartsWith(search.FirstNameGTE));
            }

            if (!string.IsNullOrWhiteSpace(search?.LastNameGTE))
            {
                query = query.Where(x => x.Lastname.StartsWith(search.LastNameGTE));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.Email == search.Email);
            }

            if (!string.IsNullOrEmpty(search?.UserName))
            {
                query = query.Where(x => x.UserName == search.UserName);
            }

            if (search.IsUserPositionIncluded == true)
            {
                query = query.Include(x => x.UserPositions).ThenInclude(x => x.Positions);
            }

            return query;
        }

        //public Model.Users Insert(UsersInsertRequests request)
        //{
        //    if (request.Password != request.ConfirmPassword)
        //    {
        //        throw new Exception("Lozinka i lozinka potwrda moraju bit iste");
        //    }
        //    //istanciranje novog korisnika
        //    Database.Users entity = new Database.Users();

        //    _mapper.Map(request, entity);

        //    entity.LozinkaSalt = GenerateSalt();
        //    entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

        //    _dbContext.Add(entity);
        //    _dbContext.SaveChanges();

        //    return _mapper.Map<Model.Users>(entity);
        //}

        public override void BeforeInsert(UsersInsertRequests request, Database.Users entity)
        {
            _logger.LogInformation($"Befor insert add infor {entity.UserName}");
            if (request.Password != request.ConfirmPassword)
            {
                throw new Exception("Lozinka i lozinka potwrda moraju bit iste");
            }
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            base.BeforeInsert(request, entity);
        }

        //public Model.Users Update(int id, UsersUpdateRequests request)
        //{
        //    var entity = _dbContext.Users.Find(id);
        //    var ime = entity.Firstname;
        //    var prezime = entity.Lastname;

        //    _mapper.Map(request, entity);

        //    if(request.Password!= null) {
        //        if (request.Password != request.ConfirmPassword)
        //        {
        //            throw new Exception("Lozinka i lozinka potwrda moraju bit iste");
        //        }
        //        entity.LozinkaSalt = GenerateSalt();
        //        entity.LozinkaHash = GenerateHash(entity.LozinkaSalt,request.Password);
        //    }

        //    if (request.Firstname == "string")
        //    {
        //        entity.Firstname = ime;
        //    }

        //    if (request.Lastname=="string" ) {
        //        entity.Lastname = prezime;
        //    }

        //    _dbContext.SaveChanges();

        //    return _mapper.Map<Model.Users>(entity);    
        //}

        public override void BeforUpdate(UsersUpdateRequests request, Database.Users entity)
        {
            var ime = entity.Firstname;
            var prezime = entity.Lastname;
            if (request.Password != null)
            {
                if (request.Password != request.ConfirmPassword)
                {
                    throw new Exception("Lozinka i lozinka potwrda moraju bit iste");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            if (request.Firstname == "string")
            {
                entity.Firstname = ime;
            }

            if (request.Lastname == "string")
            {
                entity.Lastname = prezime;
            }

            base.BeforUpdate(request, entity);
        }

        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Users Login(string username, string password)
         {
            var entity = _dbContext.Users.FirstOrDefault(u=>u.UserName == username);
            if (entity == null)
            {
                return null;
            }
            var has = GenerateHash(entity.LozinkaSalt, password);

            if(has != entity.LozinkaHash) {
                return null;
            }

            return _mapper.Map<Model.Users>(entity);
        }
    }
}
