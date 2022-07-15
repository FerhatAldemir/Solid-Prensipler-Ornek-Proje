using Example.BussinesLayer.Absraction;
using Example.Core.Bussines;
using Example.Core.Concrete;
using Example.Entites.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Example.BussinesLayer.Concrete
{
    public class UserManager : Absraction.IUserManager<Entites.concrete.User,Core.Concrete.Result<object>>
    {
        private IHttpContextAccessor httpContextAccessor;
        private IResutBuilder<object> ResultBuilder;
        private DataAccessLayer.RepoStoryAbsraction.IUserRepoStory RepoStory;
        public UserManager(IHttpContextAccessor contextAccessor, IResutBuilder<object> resutBuilder, DataAccessLayer.RepoStoryAbsraction.IUserRepoStory userRepoStory)
        {
            httpContextAccessor = contextAccessor;

            ResultBuilder = resutBuilder;
            this.RepoStory = userRepoStory;
        }

        public Result<object> CreateUser(User Item)
        {
           
            if(RepoStory.User.Any(x => x.UserName == Item.UserName))
            {
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.NotAcceptable);
                ResultBuilder.AddMessage("Bu Kullanıcı Adı ile Daha Önce Kayıt Yapılmış");


            }
            else
            {
                try { 
                RepoStory.beginTransection();
                Item = RepoStory.User.Add(Item);
                RepoStory.SaveChanges();
                ResultBuilder.AddITem(Item);
                ResultBuilder.AddMessage("Kullanıcı Başarı İle Oluşturuldu.");
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Accepted);
                RepoStory.Commit();
                }
                catch (Exception Ex)
                {
                    ResultBuilder.AddMessage("Kullanıcı Kaydı Başarısız. Hata:"+Ex.Message);
                    ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.InternalServerError);

                          

                }



            }



            return ResultBuilder.GetResult();
        }

        public Task<Result<object>> CreateUserAsync(User Item)
        {
            throw new NotImplementedException();
        }

        public Result<object> RefreshToken()
        {
            throw new NotImplementedException();
        }

        public Task<Result<object>> RefreshTokenAsync()
        {
            throw new NotImplementedException();
        }

        public Result<object> SignIn(string Username, string Password)
        {


            if(!RepoStory.User.Any(x=>x.UserName == Username && x.Password == Password))
            {
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Unauthorized);
                ResultBuilder.AddMessage("Kullanıcı Bilgileri Doğrulanamadı.");


            }
            else
            {

                var authClaims = new List<Claim>
                             {
                    new Claim(ClaimTypes.Name, Username),
                   
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                   
                             };



                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BB698DAF-6E3F-45FF-8493-06ECCF2F60D0"));

                var token = new JwtSecurityToken(
                
                    expires: DateTime.Now.AddHours(24),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                ResultBuilder.AddMessage("Giriş Başarılı");
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Accepted);
                ResultBuilder.AddITem(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo
                   
                });

            }

            return ResultBuilder.GetResult();
        }

        public Task<Result<object>> SignInAsync(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }

        public Result<object> TwoFactorAuthentication(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Result<object>> TwoFactorAuthenticationAsync(string code)
        {
            throw new NotImplementedException();
        }
    }
}
