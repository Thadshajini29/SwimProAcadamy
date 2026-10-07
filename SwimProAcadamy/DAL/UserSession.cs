using System;
using System.Collections.Generic;

namespace SwimProAcadamy.DAL
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; } = string.Empty;
        public static string FullName { get; set; } = string.Empty;
        public static string RoleName { get; set; } = string.Empty;
        public static HashSet<string> Permissions { get; } = new(StringComparer.OrdinalIgnoreCase);

        public static bool HasPermission(string permission) => IsAdmin() || Permissions.Contains(permission);

        public static bool IsAdmin() => HasRole("Admin");
        public static bool IsManager() => HasRole("Manager");
        public static bool IsStaff() => HasRole("Staff");
        public static bool IsStudent() => HasRole("Student");

        private static bool HasRole(string role) =>
            string.Equals(RoleName?.Trim(), role, StringComparison.OrdinalIgnoreCase);

        public static void Clear()
        {
            UserId = 0;
            Username = string.Empty;
            FullName = string.Empty;
            RoleName = string.Empty;
            Permissions.Clear();
        }
    }
}
