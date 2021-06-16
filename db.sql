USE [master]
GO
/****** Object:  Database [LCDZIM]    Script Date: 2021/06/16 02:37:19 ******/
CREATE DATABASE [LCDZIM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LCDZIM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LCDZIM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LCDZIM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LCDZIM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LCDZIM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LCDZIM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LCDZIM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LCDZIM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LCDZIM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LCDZIM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LCDZIM] SET ARITHABORT OFF 
GO
ALTER DATABASE [LCDZIM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LCDZIM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LCDZIM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LCDZIM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LCDZIM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LCDZIM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LCDZIM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LCDZIM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LCDZIM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LCDZIM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LCDZIM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LCDZIM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LCDZIM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LCDZIM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LCDZIM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LCDZIM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LCDZIM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LCDZIM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LCDZIM] SET  MULTI_USER 
GO
ALTER DATABASE [LCDZIM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LCDZIM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LCDZIM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LCDZIM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LCDZIM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LCDZIM] SET QUERY_STORE = OFF
GO
USE [LCDZIM]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[care_report.care_giver]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[care_report.care_giver](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NULL,
	[care_giver_name] [varchar](50) NULL,
	[care_giver_dob] [date] NULL,
	[care_giver_sex] [varchar](50) NULL,
	[care_giver_phone_number] [varchar](200) NULL,
	[care_giver_address] [varchar](max) NULL,
 CONSTRAINT [PK_care_report.care_giver] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_plan.case_log]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_plan.case_log](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[date] [date] NULL,
	[action_taken_activity] [varchar](200) NULL,
	[outcome] [varchar](200) NULL,
	[attending_person] [varchar](50) NULL,
 CONSTRAINT [PK_case_plan.case_log] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_plan.case_workplan]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_plan.case_workplan](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[action_to_be_taken] [varchar](200) NULL,
	[date] [date] NULL,
	[responsibility] [varchar](200) NULL,
	[done] [bit] NULL,
 CONSTRAINT [PK_case_plan.case_workplan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report](
	[id] [varchar](50) NOT NULL,
	[date] [datetime] NULL,
	[case_number] [varchar](200) NULL,
	[referred_by_name_and_institution] [varchar](200) NULL,
	[police_station] [varchar](200) NULL,
	[cr_ref] [varchar](200) NULL,
	[name_of_investigating_officer] [varchar](200) NULL,
	[mobile_number] [varchar](200) NULL,
	[court_handling_the_case] [varchar](200) NULL,
	[date_case_was_reported] [datetime] NULL,
	[force_number] [varchar](200) NULL,
	[compiled_by] [varchar](200) NULL,
	[date_compiled] [datetime] NULL,
 CONSTRAINT [PK_case_report] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.case_plan_and_follow_up]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.case_plan_and_follow_up](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NULL,
	[stage_case_refered] [varchar](50) NULL,
	[action_taken_by_anyone_date_this_form_was_completed] [varchar](max) NULL,
	[any_other_important_notes] [varchar](max) NULL,
	[state_other_needs_of_the_beneficiary_for_referal_to_other_service_providers] [varchar](max) NULL,
	[compiled_by] [varchar](200) NULL,
	[approved_by] [varchar](200) NULL,
	[approved_by_signature] [varchar](200) NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_case_report.case_plan_and_follow_up] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.client_information]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.client_information](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[name_of_client] [varchar](200) NULL,
	[DOB] [date] NULL,
	[age] [int] NULL,
	[sex] [varchar](50) NULL,
	[level_of_education] [varchar](50) NULL,
	[clients_address] [varchar](max) NULL,
	[phone_number_home] [varchar](200) NULL,
	[mobile] [varchar](200) NULL,
	[description_of_disability] [varchar](50) NULL,
	[give_details_of_the_disability] [varchar](max) NULL,
 CONSTRAINT [PK_case_report.client_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.description_of_the_case_problem]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.description_of_the_case_problem](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[beneficiary_status] [varchar](50) NULL,
	[beneficiary_status_other_specify] [varchar](max) NULL,
	[relationship_client_and_accused] [varchar](200) NULL,
	[relationship_client_and_witness] [varchar](200) NULL,
	[relationship_client_and_survivor_victim_complainant] [varchar](200) NULL,
	[nature_of_the_matter_case] [varchar](50) NULL,
	[nature_of_the_matter_case_other_specify] [varchar](max) NULL,
	[details_of_case_and_charge] [varchar](max) NULL,
 CONSTRAINT [PK_case_report.description_of_the_case_problem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.justification_report_for_attended_cases]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.justification_report_for_attended_cases](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NULL,
	[name_of_beneficiary] [varchar](200) NULL,
	[place_of_origin_residence] [varchar](200) NULL,
	[place_of_activity] [varchar](200) NULL,
	[date_when_the_beneficiary_was_assisted] [date] NULL,
	[type_of_assistance_logistical_support] [bit] NULL,
	[type_of_assistance_disability_expert] [bit] NULL,
	[type_of_assistance_home_visit] [bit] NULL,
	[summary_of_activity] [varchar](max) NULL,
	[outcome] [varchar](max) NULL,
	[date_of_court_hearing] [date] NULL,
	[prepared_by] [varchar](50) NULL,
	[prepared_by_date] [date] NULL,
	[approved_by] [varchar](50) NULL,
	[approved_by_date] [date] NULL,
 CONSTRAINT [PK_case_report.justification_report_for_attended_cases] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.needs_assesment]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.needs_assesment](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[where_does_the_beneficiary_live] [varchar](50) NULL,
	[who_is_taking_care_of_the_beneficiary] [varchar](50) NULL,
	[who_is_taking_care_of_the_beneficiary_other_specify] [varchar](max) NULL,
	[how_many_people_live_with_the_beneficiary] [int] NULL,
	[how_many_people_live_with_the_beneficiary_relation] [varchar](max) NULL,
	[is_the_beneficiary_able_to_verbally_communicate] [bit] NULL,
	[if_no_how_does_he_she_communicate] [varchar](max) NULL,
	[is_the_beneficiary_able_to_move_independently] [bit] NULL,
	[if_not_what_assistance_is_needed_movement] [varchar](max) NULL,
	[beneficiary_well_being_at_the_point_of_intake] [varchar](50) NULL,
	[beneficiary_well_being_at_the_point_of_intake_other_specify] [varchar](max) NULL,
	[beneficiary_immediate_concerns] [varchar](max) NULL,
	[other_relevant_issues] [varchar](max) NULL,
 CONSTRAINT [PK_case_report.needs_assesment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.next_of_kin]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.next_of_kin](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[name] [varchar](200) NULL,
	[age] [int] NULL,
	[address] [varchar](max) NULL,
	[phone_number] [varchar](200) NULL,
	[email] [varchar](200) NULL,
	[occupation] [varchar](200) NULL,
	[employer] [varchar](200) NULL,
 CONSTRAINT [PK_case_report.next_of_kin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.parents_guardians_spouses_information]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.parents_guardians_spouses_information](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[name] [varchar](200) NULL,
	[age] [int] NULL,
	[address] [varchar](max) NULL,
	[phone_number] [varchar](200) NULL,
	[email] [varchar](200) NULL,
	[occupation] [varchar](200) NULL,
	[employer] [varchar](200) NULL,
	[marital_status] [varchar](50) NULL,
	[marital_status_other_specify] [varchar](max) NULL,
 CONSTRAINT [PK_case_report.parents_guardians_spouses_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[case_report.payments_to_beneficiaries]    Script Date: 2021/06/16 02:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_report.payments_to_beneficiaries](
	[id] [varchar](50) NOT NULL,
	[case_id] [varchar](50) NOT NULL,
	[date] [date] NULL,
	[purpose] [varchar](200) NULL,
	[program] [varchar](200) NULL,
	[name] [varchar](50) NULL,
	[id_number] [varchar](50) NULL,
	[bus_fare] [decimal](18, 2) NULL,
	[breakfast] [decimal](18, 2) NULL,
	[lunch] [decimal](18, 2) NULL,
	[dinner] [decimal](18, 2) NULL,
	[accomodation] [decimal](18, 2) NULL,
	[per_diem] [decimal](18, 2) NULL,
	[other] [decimal](18, 2) NULL,
	[signature_of_recipient] [varchar](200) NULL,
	[expense_code] [varchar](50) NULL,
	[paid_by_name] [varchar](200) NULL,
	[paid_by_signature] [varchar](200) NULL,
	[paid_by_date] [date] NULL,
	[checked_by_name] [varchar](200) NULL,
	[checked_by_signature] [varchar](200) NULL,
	[checked_by_date] [date] NULL,
	[authorised_by_name] [varchar](200) NULL,
	[authorised_by_signature] [varchar](200) NULL,
	[authorised_by_date] [date] NULL,
 CONSTRAINT [PK_case_report.payments_to_beneficiaries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 2021/06/16 02:37:19 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 2021/06/16 02:37:19 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 2021/06/16 02:37:19 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 2021/06/16 02:37:19 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 2021/06/16 02:37:19 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 2021/06/16 02:37:19 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 2021/06/16 02:37:19 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[case_report.client_information]  WITH CHECK ADD  CONSTRAINT [FK_case_report.client_information_case_report.client_information] FOREIGN KEY([case_id])
REFERENCES [dbo].[case_report] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_report.client_information] CHECK CONSTRAINT [FK_case_report.client_information_case_report.client_information]
GO
ALTER TABLE [dbo].[case_report.description_of_the_case_problem]  WITH CHECK ADD  CONSTRAINT [FK_case_report.description_of_the_case_problem_case_report] FOREIGN KEY([case_id])
REFERENCES [dbo].[case_report] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_report.description_of_the_case_problem] CHECK CONSTRAINT [FK_case_report.description_of_the_case_problem_case_report]
GO
ALTER TABLE [dbo].[case_report.needs_assesment]  WITH CHECK ADD  CONSTRAINT [FK_case_report.needs_assesment_case_report] FOREIGN KEY([case_id])
REFERENCES [dbo].[case_report] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_report.needs_assesment] CHECK CONSTRAINT [FK_case_report.needs_assesment_case_report]
GO
ALTER TABLE [dbo].[case_report.next_of_kin]  WITH CHECK ADD  CONSTRAINT [FK_case_report.next_of_kin_case_report] FOREIGN KEY([case_id])
REFERENCES [dbo].[case_report] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_report.next_of_kin] CHECK CONSTRAINT [FK_case_report.next_of_kin_case_report]
GO
ALTER TABLE [dbo].[case_report.parents_guardians_spouses_information]  WITH CHECK ADD  CONSTRAINT [FK_case_report.parents_guardians_spouses_information_case_report] FOREIGN KEY([case_id])
REFERENCES [dbo].[case_report] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_report.parents_guardians_spouses_information] CHECK CONSTRAINT [FK_case_report.parents_guardians_spouses_information_case_report]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'case report' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'case_report'
GO
USE [master]
GO
ALTER DATABASE [LCDZIM] SET  READ_WRITE 
GO
