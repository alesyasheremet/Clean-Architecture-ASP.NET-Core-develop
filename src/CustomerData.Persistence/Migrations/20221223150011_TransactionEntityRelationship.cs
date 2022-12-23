using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerData.Persistence.Migrations
{
    public partial class TransactionEntityRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4", "3e9a6677-f546-4959-9e70-c913a4da4a09" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32dd0976-4c2b-47d7-a53d-adcf9cc58036", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ea90126-397d-4dd6-b560-4f31485f3a64", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c0c2686-682b-4a6b-9c0e-de39a1c837bf", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "32dd0976-4c2b-47d7-a53d-adcf9cc58036");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ea90126-397d-4dd6-b560-4f31485f3a64");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9c0c2686-682b-4a6b-9c0e-de39a1c837bf");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "3e9a6677-f546-4959-9e70-c913a4da4a09");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12132dad-5b33-48bc-8152-f77d3992a7d3", "745468bc-a45b-4452-b274-04e0fe6808c8", "Basic", "Basic" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f9d140f-a1d1-473b-91fb-9ab3ae430501", "6e17f4ea-f10a-43ae-8687-a4cf1eba42e2", "Admin", "Admin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "742974c6-a091-457c-a2e3-da2858d0c24b", "457203a0-32d2-476c-b2cc-69e7109be16c", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb5952ca-a092-4887-b6b8-e9ef73411731", "16b28ef4-c263-4b71-864a-c88379707853", "Moderator", "Moderator" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "016a2093-b6d3-4804-8a30-fa07cbf61cd6", 0, "b09b69ab-71b7-42ea-b942-a0034d7e1a1a", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "ca4bd726-1e23-4905-9d61-520abcffdedf", false, "basicuser" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe", 0, "fe0f7dce-f111-45dd-a4e3-8745c2ded27f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "e00ec0f1-30d7-4fbc-a49a-917c80e0a476", false, "superadmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "12132dad-5b33-48bc-8152-f77d3992a7d3", "016a2093-b6d3-4804-8a30-fa07cbf61cd6" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "12132dad-5b33-48bc-8152-f77d3992a7d3", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f9d140f-a1d1-473b-91fb-9ab3ae430501", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "742974c6-a091-457c-a2e3-da2858d0c24b", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb5952ca-a092-4887-b6b8-e9ef73411731", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12132dad-5b33-48bc-8152-f77d3992a7d3", "016a2093-b6d3-4804-8a30-fa07cbf61cd6" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12132dad-5b33-48bc-8152-f77d3992a7d3", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f9d140f-a1d1-473b-91fb-9ab3ae430501", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "742974c6-a091-457c-a2e3-da2858d0c24b", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb5952ca-a092-4887-b6b8-e9ef73411731", "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12132dad-5b33-48bc-8152-f77d3992a7d3");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2f9d140f-a1d1-473b-91fb-9ab3ae430501");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "742974c6-a091-457c-a2e3-da2858d0c24b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bb5952ca-a092-4887-b6b8-e9ef73411731");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "016a2093-b6d3-4804-8a30-fa07cbf61cd6");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "c0b76e68-1bb2-4eb6-85e4-ca07cb3af6fe");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32dd0976-4c2b-47d7-a53d-adcf9cc58036", "d948a46b-f2a1-41e4-b73a-d7bb0c09613b", "Admin", "Admin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ea90126-397d-4dd6-b560-4f31485f3a64", "ded44075-271f-442d-be44-ce23063e3838", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4", "a928a209-3352-4f40-a535-42e447bc4c30", "Basic", "Basic" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c0c2686-682b-4a6b-9c0e-de39a1c837bf", "c7ba4c33-4a43-4799-9f4a-879a3160b31a", "Moderator", "Moderator" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e9a6677-f546-4959-9e70-c913a4da4a09", 0, "e26cb62b-d4a0-4881-a5a1-91c66375a847", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "0c578a69-c5a4-42c8-b696-f6780c34de72", false, "basicuser" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7", 0, "2b3c9304-c9ad-4393-8116-b0757978fcb1", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "97682725-e7ee-4315-bc36-9fa6670abea4", false, "superadmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4", "3e9a6677-f546-4959-9e70-c913a4da4a09" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "32dd0976-4c2b-47d7-a53d-adcf9cc58036", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3ea90126-397d-4dd6-b560-4f31485f3a64", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76a3daa7-8e55-4b02-9e5a-e82bd6cf59d4", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c0c2686-682b-4a6b-9c0e-de39a1c837bf", "5f0a7633-bba7-47b9-b3dc-97eb5a474ef7" });
        }
    }
}
