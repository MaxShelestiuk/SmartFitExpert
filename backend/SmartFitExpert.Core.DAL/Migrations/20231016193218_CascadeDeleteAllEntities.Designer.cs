﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartFitExpert.Core.DAL;

#nullable disable

namespace SmartFitExpert.Core.DAL.Migrations
{
    [DbContext(typeof(SmartFitExpertCoreContext))]
    [Migration("20231016193218_CascadeDeleteAllEntities")]
    partial class CascadeDeleteAllEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.DailyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeGroup")
                        .HasColumnType("int");

                    b.Property<int>("DayNumber")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseOrganizationType")
                        .HasColumnType("int");

                    b.Property<int>("Goal")
                        .HasColumnType("int");

                    b.Property<int>("TotalDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DailyPlans");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Jointness")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("TargetMuscleGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TargetMuscleGroupId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseDailyPlans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DailyPlanId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DailyPlanId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseDailyPlans");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseEquipments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseEquipments");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseSupportMuscles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("SupportMuscleExercises");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.WeekDailyPlans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DailyPlanId")
                        .HasColumnType("int");

                    b.Property<int>("WeekPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DailyPlanId");

                    b.HasIndex("WeekPlanId");

                    b.ToTable("WeekDailyPlans");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvailableDays")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Goal")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restrictions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WeeklyPlanId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WeeklyPlanId");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.WeeklyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TotalDays")
                        .HasColumnType("int");

                    b.Property<string>("TrainingRestBalance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeekPlanType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeeklyPlans");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.Exercise", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.MuscleGroup", "TargetMuscleGroup")
                        .WithMany("Exercises")
                        .HasForeignKey("TargetMuscleGroupId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("TargetMuscleGroup");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseDailyPlans", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.DailyPlan", "DailyPlan")
                        .WithMany("ExerciseDailyPlans")
                        .HasForeignKey("DailyPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartFitExpert.Core.DAL.Entities.Exercise", "Exercise")
                        .WithMany("ExerciseDailyPlans")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyPlan");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseEquipments", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.Equipment", "Equipment")
                        .WithMany("ExerciseEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartFitExpert.Core.DAL.Entities.Exercise", "Exercise")
                        .WithMany("ExerciseEquipments")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.ExerciseSupportMuscles", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.Exercise", "Exercise")
                        .WithMany("ExerciseSupportMuscles")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartFitExpert.Core.DAL.Entities.MuscleGroup", "MuscleGroup")
                        .WithMany("ExerciseSupportMuscles")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MuscleGroup");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.JoinEntities.WeekDailyPlans", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.DailyPlan", "DailyPlan")
                        .WithMany("WeekDailyPlans")
                        .HasForeignKey("DailyPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartFitExpert.Core.DAL.Entities.WeeklyPlan", "WeeklyPlan")
                        .WithMany("WeekDailyPlans")
                        .HasForeignKey("WeekPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyPlan");

                    b.Navigation("WeeklyPlan");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.UserProfile", b =>
                {
                    b.HasOne("SmartFitExpert.Core.DAL.Entities.WeeklyPlan", "WeeklyPlan")
                        .WithMany("UserProfiles")
                        .HasForeignKey("WeeklyPlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("WeeklyPlan");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.DailyPlan", b =>
                {
                    b.Navigation("ExerciseDailyPlans");

                    b.Navigation("WeekDailyPlans");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.Equipment", b =>
                {
                    b.Navigation("ExerciseEquipments");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.Exercise", b =>
                {
                    b.Navigation("ExerciseDailyPlans");

                    b.Navigation("ExerciseEquipments");

                    b.Navigation("ExerciseSupportMuscles");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.MuscleGroup", b =>
                {
                    b.Navigation("ExerciseSupportMuscles");

                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("SmartFitExpert.Core.DAL.Entities.WeeklyPlan", b =>
                {
                    b.Navigation("UserProfiles");

                    b.Navigation("WeekDailyPlans");
                });
#pragma warning restore 612, 618
        }
    }
}