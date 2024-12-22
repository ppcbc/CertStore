﻿using CertStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CertStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddRoleController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AddRoleController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost("add-role")]
        public async Task<IActionResult> AddRole([FromBody] string role)
        {
            if (!await _roleManager.RoleExistsAsync(role))
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(role));
                if (result.Succeeded)
                {
                    return Ok(new { message = "Role added successfully" });
                }

                return BadRequest(result.Errors);
            }

            return BadRequest("Role already exists");
        }
        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] UserRole model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            var result = await _userManager.AddToRoleAsync(user, model.Role);
            if (result.Succeeded)
            {
                return Ok(new { message = "Role assigned successfully" });
            }

            return BadRequest(result.Errors);
        }
        [HttpPost("remove-user-role")]
        public async Task<IActionResult> RemoveUserRole([FromBody] UserRole model)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(model.Email) || string.IsNullOrWhiteSpace(model.Role))
            {
                return BadRequest(new { message = "User ID and Role cannot be empty." });
            }

            // Find the user
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            // Check if the user is in the role
            if (!await _userManager.IsInRoleAsync(user, model.Role))
            {
                return BadRequest(new { message = $"User is not in the role '{model.Role}'." });
            }

            // Remove the role
            var result = await _userManager.RemoveFromRoleAsync(user, model.Role);
            if (result.Succeeded)
            {
                return Ok(new { message = $"Role '{model.Role}' removed from user successfully." });
            }

            // Handle errors
            return BadRequest(result.Errors);
        }



        [Authorize]
        [HttpGet("get-id")]
        public IActionResult GetProfile()
        {
            // Retrieve the user ID from the ClaimsPrincipal
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return Ok(new { UserId = userId });
        }
        [Authorize]
        [HttpGet("get-role")]
        public IActionResult GetRole()
        {
            // Retrieve the user ID from the ClaimsPrincipal
            var userRole = User.FindFirstValue(ClaimTypes.Role);

            return Ok(new { UserRole = userRole });
        }
    }
}
