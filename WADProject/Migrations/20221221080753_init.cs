using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WADProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccName = table.Column<string>(type: "varchar(15)", nullable: false),
                    userName = table.Column<string>(type: "varchar(12)", nullable: false),
                    Password = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccId);
                });

            migrationBuilder.CreateTable(
                name: "DonorData",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donor = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    dAddress = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    dContact = table.Column<int>(type: "int", nullable: false),
                    dEmail = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    dAge = table.Column<int>(type: "int", nullable: false),
                    dGender = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    dBloodType = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    dRemarks = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorData", x => x.DonorId);
                });

            migrationBuilder.CreateTable(
                name: "RecipientData",
                columns: table => new
                {
                    RecipientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipient = table.Column<string>(type: "varchar(15)", nullable: false),
                    rAddress = table.Column<string>(type: "varchar(20)", nullable: false),
                    rContact = table.Column<int>(type: "int", nullable: false),
                    rEmail = table.Column<string>(type: "varchar(20)", nullable: false),
                    rAge = table.Column<int>(type: "int", nullable: false),
                    rGender = table.Column<string>(type: "varchar(6)", nullable: false),
                    rBloodType = table.Column<string>(type: "varchar(4)", nullable: false),
                    rRemarks = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipientData", x => x.RecipientId);
                });

            migrationBuilder.CreateTable(
                name: "logsData",
                columns: table => new
                {
                    logId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccNameAccId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    loginTime = table.Column<string>(type: "varchar(9)", nullable: false),
                    logoutTime = table.Column<string>(type: "varchar(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logsData", x => x.logId);
                    table.ForeignKey(
                        name: "FK_logsData_Accounts_AccNameAccId",
                        column: x => x.AccNameAccId,
                        principalTable: "Accounts",
                        principalColumn: "AccId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bloodCollectData",
                columns: table => new
                {
                    BloodColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    bldType = table.Column<string>(type: "varchar(5)", nullable: false),
                    Hospital = table.Column<string>(type: "varchar(20)", nullable: false),
                    noOfBags = table.Column<string>(type: "varchar(3)", nullable: false),
                    dateOfCollection = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bloodCollectData", x => x.BloodColId);
                    table.ForeignKey(
                        name: "FK_bloodCollectData_DonorData_DonorId",
                        column: x => x.DonorId,
                        principalTable: "DonorData",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bloodReqData",
                columns: table => new
                {
                    BloodReqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    controlNo = table.Column<int>(type: "int", nullable: false),
                    requestedBy = table.Column<string>(type: "varchar(15)", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<string>(type: "varchar(4)", nullable: false),
                    noOfBags = table.Column<string>(type: "varchar(3)", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(10)", nullable: false),
                    Purpose = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bloodReqData", x => x.BloodReqId);
                    table.ForeignKey(
                        name: "FK_bloodReqData_RecipientData_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "RecipientData",
                        principalColumn: "RecipientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bloodIssuedData",
                columns: table => new
                {
                    BloodIsudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    controlNoBloodReqId = table.Column<int>(type: "int", nullable: false),
                    dateOfIssuance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amountPaid = table.Column<int>(type: "int", nullable: false),
                    issuedBY = table.Column<string>(type: "varchar(15)", nullable: false),
                    issuedTo = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bloodIssuedData", x => x.BloodIsudId);
                    table.ForeignKey(
                        name: "FK_bloodIssuedData_bloodReqData_controlNoBloodReqId",
                        column: x => x.controlNoBloodReqId,
                        principalTable: "bloodReqData",
                        principalColumn: "BloodReqId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bloodCollectData_DonorId",
                table: "bloodCollectData",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_bloodIssuedData_controlNoBloodReqId",
                table: "bloodIssuedData",
                column: "controlNoBloodReqId");

            migrationBuilder.CreateIndex(
                name: "IX_bloodReqData_RecipientId",
                table: "bloodReqData",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_logsData_AccNameAccId",
                table: "logsData",
                column: "AccNameAccId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bloodCollectData");

            migrationBuilder.DropTable(
                name: "bloodIssuedData");

            migrationBuilder.DropTable(
                name: "logsData");

            migrationBuilder.DropTable(
                name: "DonorData");

            migrationBuilder.DropTable(
                name: "bloodReqData");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "RecipientData");
        }
    }
}
