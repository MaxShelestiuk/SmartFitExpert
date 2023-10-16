using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFitExpert.Core.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteExerciseJoinEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseEquipments_Equipment_EquipmentId",
                table: "ExerciseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseEquipments_Exercise_ExerciseId",
                table: "ExerciseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportMuscleExercises_Exercise_ExerciseId",
                table: "SupportMuscleExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportMuscleExercises_MuscleGroups_MuscleGroupId",
                table: "SupportMuscleExercises");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseEquipments_Equipment_EquipmentId",
                table: "ExerciseEquipments",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseEquipments_Exercise_ExerciseId",
                table: "ExerciseEquipments",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportMuscleExercises_Exercise_ExerciseId",
                table: "SupportMuscleExercises",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportMuscleExercises_MuscleGroups_MuscleGroupId",
                table: "SupportMuscleExercises",
                column: "MuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseEquipments_Equipment_EquipmentId",
                table: "ExerciseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseEquipments_Exercise_ExerciseId",
                table: "ExerciseEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportMuscleExercises_Exercise_ExerciseId",
                table: "SupportMuscleExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportMuscleExercises_MuscleGroups_MuscleGroupId",
                table: "SupportMuscleExercises");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseEquipments_Equipment_EquipmentId",
                table: "ExerciseEquipments",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseEquipments_Exercise_ExerciseId",
                table: "ExerciseEquipments",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportMuscleExercises_Exercise_ExerciseId",
                table: "SupportMuscleExercises",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupportMuscleExercises_MuscleGroups_MuscleGroupId",
                table: "SupportMuscleExercises",
                column: "MuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
