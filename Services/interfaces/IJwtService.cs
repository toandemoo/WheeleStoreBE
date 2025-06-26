using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Project.DTOs;
using Project.DTOs.Request;
using Project.DTOs.Response;
using Project.Entities;
using ProjectBE.Dtos.Response;

namespace ProjectBE.Services.interfaces
{
    public interface IJwtService
    {
        Task<RegisterResponse> Register(RegisterRequest dto);
        Task<LoginResponse> Login(LoginRequest dto);
        Task<VerifiedResponse> Verified(string token);
        Task<string> GenerateJwtToken(Users user);
        Task<LoginResponse> ValidateRefreshToken(string token);
        Task<string> GenerateRefreshToken(int userId);
        Task<ChangePasswordResponse> ChangePassword(int userid, ChangePasswordRequest changePasswordRequest);
        Task<ValidateTokenResponse> ValidateToken(string token);

    }
}