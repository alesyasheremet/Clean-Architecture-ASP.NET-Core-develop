using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerData.Persistence.Migrations
{
    public partial class TransactionEntityRelationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountId1",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AccountId1",
                table: "Transactions");

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

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "Transactions");

            migrationBuilder.AlterColumn<Guid>(
                name: "AccountId",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4", "1791cd6b-2625-4896-aeee-6489c1fbb439", "Basic", "Basic" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c13a246-197d-450a-b4af-16b00177c37f", "705bc296-cca3-44be-9aaa-849feca03ca8", "Admin", "Admin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88ff44e9-6cd9-47f9-adda-bf49c92995ae", "0715df65-9d35-4065-948c-1fdf663b141f", "Moderator", "Moderator" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "976fedf4-db0b-446e-82e9-f13959b52cfa", "34a344e0-b4ea-4560-99f1-c309d31a60ce", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "159516f3-db1c-4f03-88ba-d154983c718e", 0, "2351dc5e-71dd-42de-bc03-252247fe2155", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "d6059f61-6469-44e9-a232-ee1bbf7afaa7", false, "basicuser" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2eebc6c6-9425-4f38-9ea7-b174ed592dbb", 0, "e89c9b5a-c8b5-4553-9e25-788c7ec343f9", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "7e2e3433-a404-4f4b-b77d-b004c09299d9", false, "superadmin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4", "159516f3-db1c-4f03-88ba-d154983c718e" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1c13a246-197d-450a-b4af-16b00177c37f", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "88ff44e9-6cd9-47f9-adda-bf49c92995ae", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "976fedf4-db0b-446e-82e9-f13959b52cfa", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4", "159516f3-db1c-4f03-88ba-d154983c718e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c13a246-197d-450a-b4af-16b00177c37f", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88ff44e9-6cd9-47f9-adda-bf49c92995ae", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "976fedf4-db0b-446e-82e9-f13959b52cfa", "2eebc6c6-9425-4f38-9ea7-b174ed592dbb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0b4cf004-2c20-4c4e-9636-6a19f72a5fd4");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1c13a246-197d-450a-b4af-16b00177c37f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "88ff44e9-6cd9-47f9-adda-bf49c92995ae");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "976fedf4-db0b-446e-82e9-f13959b52cfa");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "159516f3-db1c-4f03-88ba-d154983c718e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "2eebc6c6-9425-4f38-9ea7-b174ed592dbb");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Transactions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId1",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId1",
                table: "Transactions",
                column: "AccountId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountId1",
                table: "Transactions",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
