using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFitExpert.Core.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_MuscleGroups_TargetMuscleGroupId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseDailyPlans_DailyPlans_DailyPlanId",
                table: "ExerciseDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseDailyPlans_Exercise_ExerciseId",
                table: "ExerciseDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_WeeklyPlans_WeeklyPlanId",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDailyPlans_DailyPlans_DailyPlanId",
                table: "WeekDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDailyPlans_WeeklyPlans_WeekPlanId",
                table: "WeekDailyPlans");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_MuscleGroups_TargetMuscleGroupId",
                table: "Exercise",
                column: "TargetMuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseDailyPlans_DailyPlans_DailyPlanId",
                table: "ExerciseDailyPlans",
                column: "DailyPlanId",
                principalTable: "DailyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseDailyPlans_Exercise_ExerciseId",
                table: "ExerciseDailyPlans",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_WeeklyPlans_WeeklyPlanId",
                table: "UserProfiles",
                column: "WeeklyPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDailyPlans_DailyPlans_DailyPlanId",
                table: "WeekDailyPlans",
                column: "DailyPlanId",
                principalTable: "DailyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDailyPlans_WeeklyPlans_WeekPlanId",
                table: "WeekDailyPlans",
                column: "WeekPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_MuscleGroups_TargetMuscleGroupId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseDailyPlans_DailyPlans_DailyPlanId",
                table: "ExerciseDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseDailyPlans_Exercise_ExerciseId",
                table: "ExerciseDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_WeeklyPlans_WeeklyPlanId",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDailyPlans_DailyPlans_DailyPlanId",
                table: "WeekDailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDailyPlans_WeeklyPlans_WeekPlanId",
                table: "WeekDailyPlans");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_MuscleGroups_TargetMuscleGroupId",
                table: "Exercise",
                column: "TargetMuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseDailyPlans_DailyPlans_DailyPlanId",
                table: "ExerciseDailyPlans",
                column: "DailyPlanId",
                principalTable: "DailyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseDailyPlans_Exercise_ExerciseId",
                table: "ExerciseDailyPlans",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_WeeklyPlans_WeeklyPlanId",
                table: "UserProfiles",
                column: "WeeklyPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDailyPlans_DailyPlans_DailyPlanId",
                table: "WeekDailyPlans",
                column: "DailyPlanId",
                principalTable: "DailyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDailyPlans_WeeklyPlans_WeekPlanId",
                table: "WeekDailyPlans",
                column: "WeekPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
