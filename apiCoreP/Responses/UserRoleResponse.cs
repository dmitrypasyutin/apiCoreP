using System.Collections.Generic;
using apiCoreP.Model;

namespace apiCoreP.Responses
{
    /// <summary>
    /// user role details response
    /// </summary>
    public class UserRoleResponse : UserRole //сомневаюсь что UserRole подходит для респонса
    {
        /// <summary>
        /// users without role
        /// </summary>
        public List<UserResponse> AvailableUsers { get; set; } = new List<UserResponse>();
    }
}
