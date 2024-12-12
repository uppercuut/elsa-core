﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.MySql.Migrations.Management
{
    [DbContext(typeof(ManagementElsaDbContext))]
    partial class ManagementElsaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<byte[]>("BinaryData")
                        .HasColumnType("longblob");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MaterializerContext")
                        .HasColumnType("longtext");

                    b.Property<string>("MaterializerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderName")
                        .HasColumnType("longtext");

                    b.Property<string>("StringData")
                        .HasColumnType("longtext");

                    b.Property<string>("ToolVersion")
                        .HasColumnType("longtext");

                    b.Property<bool?>("UsableAsActivity")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsLatest")
                        .HasDatabaseName("IX_WorkflowDefinition_IsLatest");

                    b.HasIndex("IsPublished")
                        .HasDatabaseName("IX_WorkflowDefinition_IsPublished");

                    b.HasIndex("IsSystem")
                        .HasDatabaseName("IX_WorkflowDefinition_IsSystem");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowDefinition_Name");

                    b.HasIndex("UsableAsActivity")
                        .HasDatabaseName("IX_WorkflowDefinition_UsableAsActivity");

                    b.HasIndex("Version")
                        .HasDatabaseName("IX_WorkflowDefinition_Version");

                    b.HasIndex("DefinitionId", "Version")
                        .IsUnique()
                        .HasDatabaseName("IX_WorkflowDefinition_DefinitionId_Version");

                    b.ToTable("WorkflowDefinitions", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowInstance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<string>("DataCompressionAlgorithm")
                        .HasColumnType("longtext");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("FinishedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IncidentCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ParentWorkflowInstanceId")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowInstance_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_DefinitionId");

                    b.HasIndex("FinishedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FinishedAt");

                    b.HasIndex("IsSystem")
                        .HasDatabaseName("IX_WorkflowInstance_IsSystem");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowInstance_Name");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_WorkflowInstance_Status");

                    b.HasIndex("SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_UpdatedAt");

                    b.HasIndex("Status", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_Status_DefinitionId");

                    b.HasIndex("Status", "SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus");

                    b.HasIndex("SubStatus", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus_DefinitionId");

                    b.HasIndex("Status", "SubStatus", "DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus_DefinitionId_Version");

                    b.ToTable("WorkflowInstances", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
