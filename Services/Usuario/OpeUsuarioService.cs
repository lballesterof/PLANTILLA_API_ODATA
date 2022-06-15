using AutoMapper;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using Spring.Objects.Factory.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;

namespace PLANTILLA_API_ODATA.Services.Usuario
{
    public class OpeUsuarioService:IOpeUsuarioService
    {


        private DataContext db;
        private readonly IMapper _mapper;
      

        public OpeUsuarioService(DataContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }
       

        public IQueryable<OpeUsuario> RetrieveAllUsers()
        {
            //_context = new DataContext();
           List<OpeUsuario>_List =db.OpeUsuarios.ToList();
            IQueryable<OpeUsuario> retrievedUsers = _List.AsQueryable();
            return retrievedUsers;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress)
        {

            IEnumerable<OpeUsuarioDTO> listado = null;
            using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                {

                    DynamicParameters cmd = new DynamicParameters();
                    cmd.Add("@DNI", model.Usuariomozo);
                    cmd.Add("@CONTRASENA", model.Passmozo);
                    var procedure = "GetLoginUserComanda";

                    listado = db.Query<OpeUsuarioDTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);
                    db.Dispose();
                }
            }


            var user = listado.SingleOrDefault();

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = generateJwtToken(user);
            var refreshToken = generateRefreshToken(ipAddress);

            // save refresh token
            //user.RefreshTokens.Add(refreshToken);
            //_context.Update(user);
            //_context.SaveChanges();

            return new AuthenticateResponse(user, jwtToken, refreshToken.Token);
        }
        //public AuthenticateResponse RefreshToken(string token, string ipAddress)
        //{
        //    var user = db.OpeUsuarios.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

        //    // return null if no user found with token
        //    if (user == null) return null;

        //    var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

        //    // return null if token is no longer active
        //    if (!refreshToken.IsActive) return null;

        //    // replace old refresh token with a new one and save
        //    var newRefreshToken = generateRefreshToken(ipAddress);
        //    refreshToken.Revoked = DateTime.UtcNow;
        //    refreshToken.RevokedByIp = ipAddress;
        //    refreshToken.ReplacedByToken = newRefreshToken.Token;
        //    user.RefreshTokens.Add(newRefreshToken);
        //    _context.Update(user);
        //    _context.SaveChanges();

        //    // generate new jwt
        //    var jwtToken = generateJwtToken(user);

        //    return new AuthenticateResponse(user, jwtToken, newRefreshToken.Token);
        //}

        //public bool RevokeToken(string token, string ipAddress)
        //{
        //    var user = _context.OPE_USUARIO.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

        //    // return false if no user found with token
        //    if (user == null) return false;

        //    var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

        //    // return false if token is not active
        //    if (!refreshToken.IsActive) return false;

        //    // revoke token and save
        //    refreshToken.Revoked = DateTime.UtcNow;
        //    refreshToken.RevokedByIp = ipAddress;
        //    _context.Update(user);
        //    _context.SaveChanges();

        //    return true;
        //}


        public OpeUsuario finById(string CODIGO)
        {
            return db.OpeUsuarios.Find(CODIGO);
        }

        private string generateJwtToken(OpeUsuarioDTO user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Global.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.USUARIO.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
               
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private RefreshToken generateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = DateTime.UtcNow.AddDays(7),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };
            }
        }

        public OpeUsuario finbyId(string id)
        {
            return db.OpeUsuarios.Find(id);
        }
    }
}
