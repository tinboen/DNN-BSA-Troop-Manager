
/************************************************************/
/*****              SqlDataProvider                     *****/
/*****                                                  *****/
/*****                                                  *****/
/***** Note: To manually execute this script you must   *****/
/*****       perform a search and replace operation     *****/
/*****       for {databaseOwner} and {objectQualifier}  *****/
/*****                                                  *****/
/************************************************************/

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_LOOKUP]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_LOOKUP
		(
			[PORTAL_ID]		int NOT NULL,
			[LOOKUP_ID]		int NOT NULL IDENTITY(1, 1),
			[COLUMN_NAME]		nvarchar(30) NOT NULL,
			[FIELD_NAME]		nvarchar(15) NOT NULL,
			[FIELD_VALUE]		nvarchar(50) NOT NULL,
			[FIELD_DESCR]		nvarchar(200) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_LOOKUP] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_LOOKUP] PRIMARY KEY CLUSTERED ([LOOKUP_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_TROOP]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_TROOP
		(
			[PORTAL_ID]		int NOT NULL,
			[TROOP_ID]		int NOT NULL IDENTITY(1, 1),
			[TROOP_NM]		nvarchar(50) NOT NULL,
			[TROOP_STAT_CD]		nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_TROOP] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_TROOP] PRIMARY KEY CLUSTERED ([TROOP_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UNIT]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_UNIT
		(
			[PORTAL_ID]		int NOT NULL,
			[UNIT_ID]		int NOT NULL IDENTITY(1, 1),
			[TROOP_ID]		int NULL,
			[UNIT_NM]		nvarchar(50) NOT NULL,
			[UNIT_STAT_CD]		nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_UNIT] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_UNIT] PRIMARY KEY CLUSTERED ([UNIT_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_PATROL]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_PATROL
		(
			[PORTAL_ID]		int NOT NULL,
			[PATROL_ID]		int NOT NULL IDENTITY(1, 1),
			[UNIT_ID]		int NULL,
			[PATROL_NM]		nvarchar(50) NOT NULL,
			[PATROL_STAT_CD]	nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_PATROL] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_PATROL] PRIMARY KEY CLUSTERED ([PATROL_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_POSITION]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_POSITION
		(
			[PORTAL_ID]			int NOT NULL,
			[POSITION_ID]		int NOT NULL IDENTITY(1, 1),
			[UNIT_ID]			int NULL,
			[POSITION_NM]		nvarchar(50) NOT NULL,
			[POSITION_STAT_CD]	nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_POSITION] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_POSITION] PRIMARY KEY CLUSTERED ([POSITION_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_RANK]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_RANK
		(
			[PORTAL_ID]			int NOT NULL,
			[RANK_ID]			int NOT NULL IDENTITY(1, 1),
			[UNIT_ID]			int NULL,
			[RANK_NM]			nvarchar(50) NOT NULL,
			[RANK_STAT_CD]		nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_RANK] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_RANK] PRIMARY KEY CLUSTERED ([RANK_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_LEADER]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_LEADER
		(
			[PORTAL_ID]			int NOT NULL,
			[LDR_ID]			int NOT NULL IDENTITY(1, 1),
			[USER_ID]			int NULL,
			[ADMIN]				bit NOT NULL,
			[TROOP]				bit NOT NULL,
			[UNIT]				bit NOT NULL,
			[CONTACT]			bit NOT NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_LEADER] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_LEADER] PRIMARY KEY CLUSTERED ([LDR_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_CONTACT]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_CONTACT
		(
			[PORTAL_ID]			int NOT NULL,
			[CON_ID]			int NOT NULL IDENTITY(1, 1),
			[USER_ID]			int NULL,
			[PRI_CON_NM]		nvarchar(50) NOT NULL,
			[PRI_CON_CELL]		nvarchar(15) NULL,
			[PRI_CON_EMAIL]		nvarchar(50) NULL,
			[PRI_CON_REL]		nvarchar(30) NULL,
			[SEC_CON_NM]		nvarchar(50) NULL,
			[SEC_CON_CELL]		nvarchar(15) NULL,
			[SEC_CON_EMAIL]		nvarchar(50) NULL,
			[SEC_CON_REL]		nvarchar(30) NULL,
			[HOME_TEL]			nvarchar(15) NULL,
			[ADDRESS]			nvarchar(150) NULL, 
			[CITY]				nvarchar(50) NULL, 
			[STATE]				nvarchar(2) NULL, 
			[ZIP]				nvarchar(12) NULL, 
			[CON_STAT_CD]		nvarchar(15) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_CONTACT] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_CONTACT] PRIMARY KEY CLUSTERED ([CON_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_SCOUT
		(
			[PORTAL_ID]			int NOT NULL,
			[SCOUT_ID]			int NOT NULL IDENTITY(1, 1),
			[USER_ID]			int NULL,
			[FIRST_NM]			nvarchar(30) NOT NULL,
			[MIDDLE_NM]			nvarchar(30) NULL,
			[LAST_NM]			nvarchar(30) NULL,
			[NICK_NM]			nvarchar(30) NULL,
			[DOB]				smalldatetime NULL,
			[CELL]				nvarchar(15) NULL,
			[EMAIL]				nvarchar(50) NULL,
			[GRADE]				nvarchar(15) NULL, 
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_SCOUT] PRIMARY KEY CLUSTERED ([SCOUT_ID])
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT_MEDICAL]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_SCOUT_MEDICAL
		(
			[PORTAL_ID]			int NOT NULL,
			[SCOUT_MED_ID]		int NOT NULL IDENTITY(1, 1),
			[SCOUT_ID]			int NULL,
			[DR_NM]				nvarchar(50) NULL,
			[DR_TEL]			nvarchar(15) NULL,
			[INS_NM]			nvarchar(50) NULL,
			[INS_NO]			nvarchar(30) NULL,
			[EMER_CON_NM]		nvarchar(50) NULL,
			[EMER_CON_TEL]		nvarchar(15) NULL,
			[EMER_CON_REL]		nvarchar(30) NULL,
			[CURR_MED]			nvarchar(3) NULL,
			[CURR_MED_NM]		nvarchar(255) NULL,
			[NOTES]				nvarchar(max) NULL,
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT_MEDICAL] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_SCOUT_MEDICAL] PRIMARY KEY CLUSTERED ([SCOUT_MED_ID])
	END

GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE [object_id] = OBJECT_ID(N'{databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT_DATA]') AND type in (N'U'))
	BEGIN
		CREATE TABLE {databaseOwner}{objectQualifier}BSA_LDHV_SCOUT_DATA
		(
			[PORTAL_ID]			int NOT NULL,
			[SCOUT_DATA_ID]		int NOT NULL IDENTITY(1, 1),
			[SCOUT_ID]			int NULL,
			[START_DT]			smalldatetime NULL,
			[END_DT]			smalldatetime NULL,
			[SCOUT_STAT_CD]		nvarchar(15) NULL,
			[TROOP_ID]			int NULL,
			[UNIT_ID]			int NULL,
			[PATROL_ID]			int NULL,
			[POSITION_ID]		int NULL,
			[RANK_ID]			int NULL,
			[IMAGE_FILE]		nvarchar(255) NULL, 
			[CREATED_DT]		smalldatetime NOT NULL,
			[CREATED_USERID]	int NOT NULL,
			[UPDATED_DT]		smalldatetime NULL,
			[UPDATED_USERID]	int NULL
		)
		ALTER TABLE {databaseOwner}[{objectQualifier}BSA_LDHV_SCOUT_DATA] ADD CONSTRAINT [PK_{objectQualifier}BSA_LDHV_SCOUT_DATA] PRIMARY KEY CLUSTERED ([SCOUT_DATA_ID])
	END
GO

/** Drop Existing Lookup Stored Procedures **/

if exists (select * from {objectQualifier}sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetLookup]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetLookup
GO

if exists (select * from {objectQualifier}sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddLookup]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddLookup
GO

if exists (select * from {objectQualifier}sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateLookup]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateLookup
GO

if exists (select * from {objectQualifier}sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteLookup]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteLookup
GO

/** Create Lookup Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetLookup

	@PORTAL_ID		int = NULL,
	@LOOKUP_ID		int = NULL,
	@COLUMN_NAME	nvarchar(30) = NULL,
	@FIELD_NAME		nvarchar(15) = NULL
	
as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql =
	'SELECT
	PORTAL_ID,
	LOOKUP_ID,
	COLUMN_NAME,
	FIELD_NAME,
	FIELD_VALUE,
	FIELD_DESCR,
	CREATED_USERID,
	CREATED_DT,
	UPDATED_USERID,
	UPDATED_DT,
	concat(tbl_CreatedUsers.FirstName,'' '',tbl_CreatedUsers.LastName) as CreatedByUserName,
	concat(tbl_UpdatedUsers.FirstName,'' '',tbl_UpdatedUsers.LastName) as UpdatedByUserName
from {objectQualifier}BSA_LDHV_LOOKUP with (nolock)
left outer join {objectQualifier}Users as tbl_CreatedUsers on CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND PORTAL_ID = @xPORTAL_ID'

IF @LOOKUP_ID IS NOT NULL AND @LOOKUP_ID > 0
   SELECT @sql = @sql + ' AND LOOKUP_ID = @xLOOKUP_ID'

IF @COLUMN_NAME IS NOT NULL AND @COLUMN_NAME != ''
   SELECT @sql = @sql + ' AND COLUMN_NAME = @xCOLUMN_NAME'

IF @FIELD_NAME IS NOT NULL AND @FIELD_NAME != ''
   SELECT @sql = @sql + ' AND FIELD_NAME = @xFIELD_NAME'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' ORDER BY FIELD_VALUE'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xLOOKUP_ID	int,
	@xCOLUMN_NAME	nvarchar(30),
	@xFIELD_NAME	nvarchar(15)'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@LOOKUP_ID,
	@COLUMN_NAME,
	@FIELD_NAME

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddLookup

	@PORTAL_ID		int,
	@COLUMN_NAME	nvarchar(30),
	@FIELD_NAME		nvarchar(15),
	@FIELD_VALUE	nvarchar(60),
	@FIELD_DESCR	nvarchar(max),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_LOOKUP as C
where C.PORTAL_ID = @PORTAL_ID
and C.COLUMN_NAME = @COLUMN_NAME
and C.FIELD_NAME = @FIELD_NAME
)

insert into {objectQualifier}BSA_LDHV_LOOKUP (
	PORTAL_ID,
	COLUMN_NAME,
	FIELD_NAME,
	FIELD_VALUE,
	FIELD_DESCR,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@COLUMN_NAME,
	@FIELD_NAME,
	@FIELD_VALUE,
	@FIELD_DESCR,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateLookup

	@PORTAL_ID		int,
	@LOOKUP_ID		int,
	@COLUMN_NAME	nvarchar(30),
	@FIELD_NAME		nvarchar(15),
	@FIELD_VALUE	nvarchar(60),
	@FIELD_DESCR	nvarchar(max),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_LOOKUP
set	COLUMN_NAME		= @COLUMN_NAME,
	FIELD_NAME		= @FIELD_NAME,
	FIELD_VALUE		= @FIELD_VALUE,
	FIELD_DESCR		= @FIELD_DESCR,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and LOOKUP_ID = @LOOKUP_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteLookup

	@PORTAL_ID	int,
	@LOOKUP_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_LOOKUP
where PORTAL_ID =  @PORTAL_ID
and LOOKUP_ID = @LOOKUP_ID

GO

/************************************************************/
/*****              SqlDataProvider                     *****/
/************************************************************/

/** Drop Existing Troop Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_SearchTroop]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_SearchTroop
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetTroop]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetTroop
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddTroop]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddTroop
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateTroop]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateTroop
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteTroop]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteTroop
GO

/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_SearchTroop

	@PORTAL_ID		int = NULL,
	@TROOP_ID		int = NULL,
	@UNIT_ID		int = NULL,
	@PATROL_ID		int = NULL,
	@POSITION_ID		int = NULL,
	@RANK_ID		int = NULL,
	@Params			nvarchar(255) = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Troop_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''TROOP_STAT_CD''),
tbl_Unit_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''UNIT_STAT_CD''),
tbl_Patrol_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''PATROL_STAT_CD''),
tbl_Position_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''POSITION_STAT_CD''),
tbl_Rank_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''RANK_STAT_CD'')
SELECT tbl_Troop.PORTAL_ID,
	tbl_Troop.TROOP_ID,
	tbl_Troop.TROOP_NM,
	tbl_Troop.TROOP_STAT_CD,
	tbl_Troop_Status.FIELD_VALUE as TROOP_STAT_NM,
	tbl_Unit.UNIT_ID,
	tbl_Unit.UNIT_NM,
	tbl_Unit.UNIT_STAT_CD,
	tbl_Unit_Status.FIELD_VALUE as UNIT_STAT_NM,
	tbl_Patrol.PATROL_ID,
	tbl_Patrol.PATROL_NM,
	tbl_Patrol.PATROL_STAT_CD,
	tbl_Patrol_Status.FIELD_VALUE as PATROL_STAT_NM,
	tbl_Position.POSITION_ID,
	tbl_Position.POSITION_NM,
	tbl_Position.POSITION_STAT_CD,
	tbl_Position_Status.FIELD_VALUE as POSITION_STAT_NM,
	tbl_Rank.RANK_ID,
	tbl_Rank.RANK_NM,
	tbl_Rank.RANK_STAT_CD,
	tbl_Rank_Status.FIELD_VALUE as RANK_STAT_NM,
	tbl_Troop.CREATED_USERID,
	tbl_Troop.CREATED_DT,
	tbl_Troop.UPDATED_USERID,
	tbl_Troop.UPDATED_DT,'
IF @Params IS NOT NULL AND @Params != ''
   SELECT @sql = @sql + ' @xParams as Params, '
SELECT @sql = @sql + 'tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_TROOP as tbl_Troop with (nolock)
left outer join {objectQualifier}BSA_LDHV_UNIT as tbl_Unit on tbl_Troop.TROOP_ID = tbl_Unit.TROOP_ID
left outer join {objectQualifier}BSA_LDHV_PATROL as tbl_Patrol on tbl_Unit.UNIT_ID = tbl_Patrol.UNIT_ID
left outer join {objectQualifier}BSA_LDHV_POSITION as tbl_Position on tbl_Unit.UNIT_ID = tbl_Position.UNIT_ID
left outer join {objectQualifier}BSA_LDHV_RANK as tbl_Rank on tbl_Unit.UNIT_ID = tbl_Rank.UNIT_ID
left outer join tbl_Troop_Status on tbl_Troop.TROOP_STAT_CD = tbl_Troop_Status.FIELD_NAME
left outer join tbl_Unit_Status on tbl_Unit.UNIT_STAT_CD = tbl_Unit_Status.FIELD_NAME
left outer join tbl_Patrol_Status on tbl_Patrol.PATROL_STAT_CD = tbl_Patrol_Status.FIELD_NAME
left outer join tbl_Position_Status on tbl_Position.POSITION_STAT_CD = tbl_Position_Status.FIELD_NAME
left outer join tbl_Rank_Status on tbl_Rank.RANK_STAT_CD = tbl_Rank_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Troop.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Troop.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Troop.PORTAL_ID = @xPORTAL_ID'

IF @TROOP_ID IS NOT NULL AND @TROOP_ID > 0
  SELECT @sql = @sql + ' AND tbl_Troop.TROOP_ID = @xTROOP_ID'

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Unit.UNIT_ID = @xUNIT_ID'

IF @PATROL_ID IS NOT NULL AND @PATROL_ID > 0
   SELECT @sql = @sql + ' AND tbl_Patrol.PATROL_ID = @xPATROL_ID'

IF @POSITION_ID IS NOT NULL AND @POSITION_ID > 0
   SELECT @sql = @sql + ' AND tbl_Position.POSITION_ID = @xPOSITION_ID'

IF @RANK_ID IS NOT NULL AND @RANK_ID > 0
   SELECT @sql = @sql + ' AND tbl_Rank.RANK_ID = @xRANK_ID' 

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by TROOP_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xTROOP_ID	int,
	@xUNIT_ID	int,
	@xPATROL_ID	int,
	@xPOSITION_ID	int,
	@xRANK_ID	int,
	@xParams	nvarchar(255)'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@TROOP_ID,
	@UNIT_ID,
	@PATROL_ID,
	@POSITION_ID,
	@RANK_ID,
	@Params

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetTroop

	@PORTAL_ID		int = NULL,
	@TROOP_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Troop_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''TROOP_STAT_CD'')
SELECT tbl_Troop.PORTAL_ID,
	tbl_Troop.TROOP_ID,
	tbl_Troop.TROOP_NM,
	tbl_Troop.TROOP_STAT_CD,
	tbl_Troop_Status.FIELD_VALUE as TROOP_STAT_NM,
	tbl_Troop.CREATED_USERID,
	tbl_Troop.CREATED_DT,
	tbl_Troop.UPDATED_USERID,
	tbl_Troop.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_TROOP as tbl_Troop with (nolock)
left outer join tbl_Troop_Status on tbl_Troop.TROOP_STAT_CD = tbl_Troop_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Troop.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Troop.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Troop.PORTAL_ID = @xPORTAL_ID'

IF @TROOP_ID IS NOT NULL AND @TROOP_ID > 0
  SELECT @sql = @sql + ' AND tbl_Troop.TROOP_ID = @xTROOP_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by TROOP_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xTROOP_ID	int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@TROOP_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddTroop

	@PORTAL_ID		int,
	@TROOP_NM		nvarchar(50),
	@TROOP_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_TROOP as C
where C.PORTAL_ID = @PORTAL_ID
and C.TROOP_NM = @TROOP_NM
)

insert into {objectQualifier}BSA_LDHV_TROOP (
	PORTAL_ID,
	TROOP_NM,
	TROOP_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@TROOP_NM,
	@TROOP_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateTroop

	@PORTAL_ID		int,
	@TROOP_ID		int,
	@TROOP_NM		nvarchar(50),
	@TROOP_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_TROOP
set	TROOP_NM		= @TROOP_NM,
	TROOP_STAT_CD	= @TROOP_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and TROOP_ID = @TROOP_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteTroop

	@PORTAL_ID	int,
	@TROOP_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_TROOP
where PORTAL_ID = @PORTAL_ID
and TROOP_ID = @TROOP_ID

GO

/** Drop Existing Unit Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetUnit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetUnit
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddUnit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddUnit
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateUnit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateUnit
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteUnit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteUnit
GO

/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetUnit

	@PORTAL_ID		int = NULL,
	@TROOP_ID		int = NULL,
	@UNIT_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Troop_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''TROOP_STAT_CD''),
tbl_Unit_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''UNIT_STAT_CD'')
SELECT tbl_Unit.PORTAL_ID,
	tbl_Unit.UNIT_ID,
	tbl_Unit.TROOP_ID,
	tbl_Troop.TROOP_NM,
	tbl_Troop.TROOP_STAT_CD,
	tbl_Troop_Status.FIELD_VALUE as TROOP_STAT_NM,
	tbl_Unit.UNIT_NM,
	tbl_Unit.UNIT_STAT_CD,
	tbl_Unit_Status.FIELD_VALUE as UNIT_STAT_NM,
	tbl_Unit.CREATED_USERID,
	tbl_Unit.CREATED_DT,
	tbl_Unit.UPDATED_USERID,
	tbl_Unit.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_UNIT as tbl_Unit with (nolock)
left outer join tbl_Unit_Status on tbl_Unit.UNIT_STAT_CD = tbl_Unit_Status.FIELD_NAME
left outer join {objectQualifier}BSA_LDHV_TROOP as tbl_Troop on tbl_Unit.TROOP_ID = tbl_Troop.TROOP_ID
left outer join tbl_Troop_Status on tbl_Troop.TROOP_STAT_CD = tbl_Troop_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Unit.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Unit.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Unit.PORTAL_ID = @xPORTAL_ID'

IF @TROOP_ID IS NOT NULL AND @TROOP_ID > 0
  SELECT @sql = @sql + ' AND tbl_Unit.TROOP_ID = @xTROOP_ID'

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Unit.UNIT_ID = @xUNIT_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by UNIT_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xTROOP_ID	int,
	@xUNIT_ID	int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@TROOP_ID,
	@UNIT_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddUnit

	@PORTAL_ID		int,
	@TROOP_ID		int,
	@UNIT_NM		nvarchar(50),
	@UNIT_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_UNIT as C
where C.PORTAL_ID = @PORTAL_ID
and C.UNIT_NM = @UNIT_NM
)

insert into {objectQualifier}BSA_LDHV_UNIT (
	PORTAL_ID,
	TROOP_ID,
	UNIT_NM,
	UNIT_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@TROOP_ID,
	@UNIT_NM,
	@UNIT_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateUnit

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@TROOP_ID		int,
	@UNIT_NM		nvarchar(50),
	@UNIT_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_UNIT
set	TROOP_ID		= @TROOP_ID,
	UNIT_NM			= @UNIT_NM,
	UNIT_STAT_CD	= @UNIT_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and UNIT_ID = @UNIT_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteUnit

	@PORTAL_ID	int,
	@UNIT_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_UNIT
where PORTAL_ID = @PORTAL_ID
and UNIT_ID = @UNIT_ID

GO

/** Drop Existing Patrol Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetPatrol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetPatrol
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddPatrol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddPatrol
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdatePatrol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdatePatrol
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeletePatrol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeletePatrol
GO

/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetPatrol

	@PORTAL_ID		int = NULL,
	@UNIT_ID		int = NULL,
	@PATROL_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Unit_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''UNIT_STAT_CD''),
tbl_Patrol_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''PATROL_STAT_CD'')
SELECT tbl_Patrol.PORTAL_ID,
	tbl_Patrol.PATROL_ID,
	tbl_Patrol.UNIT_ID,
	tbl_Unit.UNIT_NM,
	tbl_Unit.UNIT_STAT_CD,
	tbl_Unit_Status.FIELD_VALUE as UNIT_STAT_NM,
	tbl_Patrol.PATROL_NM,
	tbl_Patrol.PATROL_STAT_CD,
	tbl_Patrol_Status.FIELD_VALUE as PATROL_STAT_NM,
	tbl_Patrol.CREATED_USERID,
	tbl_Patrol.CREATED_DT,
	tbl_Patrol.UPDATED_USERID,
	tbl_Patrol.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_PATROL as tbl_Patrol with (nolock)
left outer join tbl_Patrol_Status on tbl_Patrol.PATROL_STAT_CD = tbl_Patrol_Status.FIELD_NAME
left outer join {objectQualifier}BSA_LDHV_UNIT as tbl_Unit on tbl_Patrol.UNIT_ID = tbl_Unit.UNIT_ID
left outer join tbl_Unit_Status on tbl_Unit.UNIT_STAT_CD = tbl_Unit_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Patrol.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Patrol.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Patrol.PORTAL_ID = @xPORTAL_ID'

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Patrol.UNIT_ID = @xUNIT_ID'

IF @PATROL_ID IS NOT NULL AND @PATROL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Patrol.PATROL_ID = @xPATROL_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by PATROL_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xUNIT_ID	int,
	@xPATROL_ID	int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@UNIT_ID,
	@PATROL_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddPatrol

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@PATROL_NM		nvarchar(50),
	@PATROL_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_PATROL as C
where C.PORTAL_ID = @PORTAL_ID
and C.PATROL_NM = @PATROL_NM
)

insert into {objectQualifier}BSA_LDHV_PATROL (
	PORTAL_ID,
	UNIT_ID,
	PATROL_NM,
	PATROL_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@UNIT_ID,
	@PATROL_NM,
	@PATROL_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdatePatrol

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@PATROL_ID		int,
	@PATROL_NM		nvarchar(50),
	@PATROL_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_PATROL
set	UNIT_ID			= @UNIT_ID,
	PATROL_NM		= @PATROL_NM,
	PATROL_STAT_CD	= @PATROL_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and PATROL_ID = @PATROL_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeletePatrol

	@PORTAL_ID	int,
	@PATROL_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_PATROL
where PORTAL_ID = @PORTAL_ID
and PATROL_ID = @PATROL_ID

GO

/** Drop Existing Position Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetPosition]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetPosition
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddPosition]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddPosition
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdatePosition]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdatePosition
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeletePosition]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeletePosition
GO

/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetPosition

	@PORTAL_ID		int = NULL,
	@UNIT_ID		int = NULL,
	@POSITION_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Unit_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''UNIT_STAT_CD''),
tbl_Position_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''POSITION_STAT_CD'')
SELECT tbl_Position.PORTAL_ID,
	tbl_Position.POSITION_ID,
	tbl_Position.UNIT_ID,
	tbl_Unit.UNIT_NM,
	tbl_Unit.UNIT_STAT_CD,
	tbl_Unit_Status.FIELD_VALUE as UNIT_STAT_NM,
	tbl_Position.POSITION_NM,
	tbl_Position.POSITION_STAT_CD,
	tbl_Position_Status.FIELD_VALUE as POSITION_STAT_NM,
	tbl_Position.CREATED_USERID,
	tbl_Position.CREATED_DT,
	tbl_Position.UPDATED_USERID,
	tbl_Position.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_POSITION as tbl_Position with (nolock)
left outer join tbl_Position_Status on tbl_Position.POSITION_STAT_CD = tbl_Position_Status.FIELD_NAME
left outer join {objectQualifier}BSA_LDHV_UNIT as tbl_Unit on tbl_Position.UNIT_ID = tbl_Unit.UNIT_ID
left outer join tbl_Unit_Status on tbl_Unit.UNIT_STAT_CD = tbl_Unit_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Position.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Position.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Position.PORTAL_ID = @xPORTAL_ID'

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Position.UNIT_ID = @xUNIT_ID'

IF @POSITION_ID IS NOT NULL AND @POSITION_ID > 0
  SELECT @sql = @sql + ' AND tbl_Position.POSITION_ID = @xPOSITION_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by POSITION_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xUNIT_ID	int,
	@xPOSITION_ID	int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@UNIT_ID,
	@POSITION_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddPosition

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@POSITION_NM		nvarchar(50),
	@POSITION_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_POSITION as C
where C.PORTAL_ID = @PORTAL_ID
and C.POSITION_NM = @POSITION_NM
)

insert into {objectQualifier}BSA_LDHV_POSITION (
	PORTAL_ID,
	UNIT_ID,
	POSITION_NM,
	POSITION_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@UNIT_ID,
	@POSITION_NM,
	@POSITION_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdatePosition

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@POSITION_ID		int,
	@POSITION_NM		nvarchar(50),
	@POSITION_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_POSITION
set	UNIT_ID			= @UNIT_ID,
	POSITION_NM			= @POSITION_NM,
	POSITION_STAT_CD	= @POSITION_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and POSITION_ID = @POSITION_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeletePosition

	@PORTAL_ID	int,
	@POSITION_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_POSITION
where PORTAL_ID = @PORTAL_ID
and POSITION_ID = @POSITION_ID

GO

/** Drop Existing Rank Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetRank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetRank
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddRank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddRank
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateRank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateRank
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteRank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteRank
GO

/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetRank

	@PORTAL_ID		int = NULL,
	@UNIT_ID		int = NULL,
	@RANK_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Unit_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''UNIT_STAT_CD''),
tbl_Rank_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''RANK_STAT_CD'')
SELECT tbl_Rank.PORTAL_ID,
	tbl_Rank.RANK_ID,
	tbl_Rank.UNIT_ID,
	tbl_Unit.UNIT_NM,
	tbl_Unit.UNIT_STAT_CD,
	tbl_Unit_Status.FIELD_VALUE as UNIT_STAT_NM,
	tbl_Rank.RANK_NM,
	tbl_Rank.RANK_STAT_CD,
	tbl_Rank_Status.FIELD_VALUE as RANK_STAT_NM,
	tbl_Rank.CREATED_USERID,
	tbl_Rank.CREATED_DT,
	tbl_Rank.UPDATED_USERID,
	tbl_Rank.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_RANK as tbl_Rank with (nolock)
left outer join tbl_Rank_Status on tbl_Rank.RANK_STAT_CD = tbl_Rank_Status.FIELD_NAME
left outer join {objectQualifier}BSA_LDHV_UNIT as tbl_Unit on tbl_Rank.UNIT_ID = tbl_Unit.UNIT_ID
left outer join tbl_Unit_Status on tbl_Unit.UNIT_STAT_CD = tbl_Unit_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Rank.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Rank.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Rank.PORTAL_ID = @xPORTAL_ID'

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Rank.UNIT_ID = @xUNIT_ID'

IF @RANK_ID IS NOT NULL AND @RANK_ID > 0
  SELECT @sql = @sql + ' AND tbl_Rank.RANK_ID = @xRANK_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by RANK_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xUNIT_ID	int,
	@xRANK_ID	int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@UNIT_ID,
	@RANK_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddRank

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@RANK_NM		nvarchar(50),
	@RANK_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_RANK as C
where C.PORTAL_ID = @PORTAL_ID
and C.RANK_NM = @RANK_NM
)

insert into {objectQualifier}BSA_LDHV_RANK (
	PORTAL_ID,
	UNIT_ID,
	RANK_NM,
	RANK_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@UNIT_ID,
	@RANK_NM,
	@RANK_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateRank

	@PORTAL_ID		int,
	@UNIT_ID		int,
	@RANK_ID		int,
	@RANK_NM		nvarchar(50),
	@RANK_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_RANK
set	UNIT_ID			= @UNIT_ID,
	RANK_NM			= @RANK_NM,
	RANK_STAT_CD	= @RANK_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and RANK_ID = @RANK_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteRank

	@PORTAL_ID	int,
	@RANK_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_RANK
where PORTAL_ID = @PORTAL_ID
and RANK_ID = @RANK_ID

GO

/************************************************************/
/*****              SqlDataProvider                     *****/
/************************************************************/
/** Drop Existing Contact Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetContact]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetContact
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddContact]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddContact
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateContact]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateContact
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteContact]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteContact
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetContactUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetContactUser
GO

/** Create Contact Stored Procedures **/

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetContact

	@PORTAL_ID		int = NULL,
	@CON_ID			int = NULL,
	@USER_ID		int = NULL,
	@PRI_CON_NM		nvarchar(50) = NULL,
	@SEC_CON_NM		nvarchar(50) = NULL,
	@CON_STAT_CD	nvarchar(15) = NULL,
	@UNIT_ID		int = NULL,
	@SCOUT_NM		nvarchar(50) = NULL,
	@SCOUT_STAT_CD	nvarchar(15) = NULL,
	@Params			nvarchar(255) = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Cont_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''CON_STAT_CD''),
tbl_Scout_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''SCOUT_STAT_CD'')
SELECT tbl_Contact.PORTAL_ID,
	tbl_Contact.CON_ID,
	tbl_Contact.USER_ID,
	tbl_Contact.PRI_CON_NM,
	tbl_Contact.PRI_CON_CELL,
	tbl_Contact.PRI_CON_EMAIL,
	tbl_Contact.PRI_CON_REL,
	tbl_Contact.SEC_CON_NM,
	tbl_Contact.SEC_CON_CELL,
	tbl_Contact.SEC_CON_EMAIL,
	tbl_Contact.SEC_CON_REL,
	tbl_Contact.HOME_TEL,
	tbl_Contact.ADDRESS,
	tbl_Contact.CITY,
	tbl_Contact.STATE,
	tbl_Contact.ZIP,
	tbl_Contact.CON_STAT_CD,
	tbl_Cont_Status.FIELD_VALUE as STATUS_NM,
	tbl_Contact.CREATED_USERID,
	tbl_Contact.CREATED_DT,
	tbl_Contact.UPDATED_USERID,
	tbl_Contact.UPDATED_DT,'
IF @Params IS NOT NULL AND @Params != ''
   SELECT @sql = @sql + ' @xParams as Params, '
SELECT @sql = @sql + 'tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_CONTACT as tbl_Contact with (nolock)
left outer join {objectQualifier}BSA_LDHV_SCOUT as tbl_Scout on tbl_Contact.USER_ID = tbl_Scout.USER_ID
left outer join {objectQualifier}BSA_LDHV_SCOUT_MEDICAL as tbl_Scout_Med on tbl_Scout.USER_ID = tbl_Scout_Med.USER_ID and tbl_Scout.SCOUT_ID = tbl_Scout_Med.SCOUT_ID
left outer join {objectQualifier}BSA_LDHV_SCOUT_DATA as tbl_Scout_Data on tbl_Scout.USER_ID = tbl_Scout_Data.USER_ID and tbl_Scout.SCOUT_ID = tbl_Scout_Data.SCOUT_ID

left outer join {objectQualifier}BSA_LDHV_TROOP as tbl_Troop on tbl_Scout_Data.TROOP_ID = tbl_Troop.TROOP_ID
left outer join {objectQualifier}BSA_LDHV_UNIT as tbl_Unit on tbl_Scout_Data.UNIT_ID = tbl_Unit.UNIT_ID
left outer join {objectQualifier}BSA_LDHV_PATROL as tbl_Patrol on tbl_Scout_Data.PATROL_ID = tbl_Patrol.PATROL_ID
left outer join {objectQualifier}BSA_LDHV_POSITION as tbl_Position on tbl_Scout_Data.POSITION_ID = tbl_Position.POSITION_ID
left outer join {objectQualifier}BSA_LDHV_RANK as tbl_Rank on tbl_Scout_Data.RANK_ID = tbl_Rank.RANK_ID

left outer join tbl_Cont_Status on tbl_Contact.CON_STAT_CD = tbl_Cont_Status.FIELD_NAME
left outer join tbl_Scout_Status on tbl_Scout_Data.SCOUT_STAT_CD = tbl_Scout_Status.FIELD_NAME
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Contact.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Contact.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Contact.PORTAL_ID = @xPORTAL_ID'

IF @CON_ID IS NOT NULL AND @CON_ID > 0
  SELECT @sql = @sql + ' AND tbl_Contact.CON_ID = @xCON_ID'

IF @USER_ID IS NOT NULL AND @USER_ID > 0
  SELECT @sql = @sql + ' AND tbl_Contact.USER_ID = @xUSER_ID'

IF @PRI_CON_NM IS NOT NULL AND @PRI_CON_NM != ''
   SELECT @sql = @sql + ' AND tbl_Contact.PRI_CON_NM = @xPRI_CON_NM'

IF @SEC_CON_NM IS NOT NULL AND @SEC_CON_NM != ''
   SELECT @sql = @sql + ' AND tbl_Contact.SEC_CON_NM = @xSEC_CON_NM'

IF @CON_STAT_CD IS NOT NULL AND @CON_STAT_CD != ''
   SELECT @sql = @sql + ' AND tbl_Contact.CON_STAT_CD = @xCON_STAT_CD' 

IF @UNIT_ID IS NOT NULL AND @UNIT_ID > 0
   SELECT @sql = @sql + ' AND tbl_Scout_Data.UNIT_ID = @xUNIT_ID'

IF @SCOUT_NM IS NOT NULL AND @SCOUT_NM != ''
   SELECT @sql = @sql + ' AND tbl_Scout.FIRST_NM + tbl_Scout.MIDDLE_NM + tbl_Scout.LAST_NM like ''%'' + @xSCOUT_NM + ''%''' 

IF @SCOUT_STAT_CD IS NOT NULL AND @SCOUT_STAT_CD != ''
   SELECT @sql = @sql + ' AND tbl_Scout_Data.SCOUT_STAT_CD = @xSCOUT_STAT_CD' 

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by PRI_CON_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xCON_ID		int,
	@xUSER_ID		int,
	@xPRI_CON_NM	nvarchar(50),
	@xSEC_CON_NM	nvarchar(50),
	@xCON_STAT_CD	nvarchar(15),
	@xUNIT_ID		int,
	@xSCOUT_NM		nvarchar(50),
	@xSCOUT_STAT_CD	nvarchar(15),
	@xParams		nvarchar(255)'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@CON_ID,
	@USER_ID,
	@PRI_CON_NM,
	@SEC_CON_NM,
	@CON_STAT_CD,
	@UNIT_ID,
	@SCOUT_NM,
	@SCOUT_STAT_CD,
	@Params

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddContact

	@PORTAL_ID		int,
	@USER_ID		int,
	@PRI_CON_NM		nvarchar(50),
	@PRI_CON_CELL	nvarchar(15),
	@PRI_CON_EMAIL	nvarchar(50),
	@PRI_CON_REL	nvarchar(30),
	@SEC_CON_NM		nvarchar(50),
	@SEC_CON_CELL	nvarchar(15),
	@SEC_CON_EMAIL	nvarchar(50),
	@SEC_CON_REL	nvarchar(30),
	@HOME_TEL		nvarchar(15),
	@ADDRESS		nvarchar(150), 
	@CITY			nvarchar(50),
	@STATE			nvarchar(2),
	@ZIP			nvarchar(12),
	@CON_STAT_CD	nvarchar(15),
	@UserID			int

as

if not exists (select * from {databaseOwner}{objectQualifier}BSA_LDHV_CONTACT as C
where C.PORTAL_ID = @PORTAL_ID
and C.PRI_CON_NM = @PRI_CON_NM
)

insert into {objectQualifier}BSA_LDHV_CONTACT (
	PORTAL_ID,
	USER_ID,
	PRI_CON_NM,
	PRI_CON_CELL,
	PRI_CON_EMAIL,
	PRI_CON_REL,
	SEC_CON_NM,
	SEC_CON_CELL,
	SEC_CON_EMAIL,
	SEC_CON_REL,
	HOME_TEL,
	ADDRESS,
	CITY,
	STATE,
	ZIP,
	CON_STAT_CD,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@USER_ID,
	@PRI_CON_NM,
	@PRI_CON_CELL,
	@PRI_CON_EMAIL,
	@PRI_CON_REL,
	@SEC_CON_NM,
	@SEC_CON_CELL,
	@SEC_CON_EMAIL,
	@SEC_CON_REL,
	@HOME_TEL,
	@ADDRESS,
	@CITY,
	@STATE,
	@ZIP,
	@CON_STAT_CD,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateContact

	@PORTAL_ID		int,
	@CON_ID		int,
	@USER_ID		int,
	@PRI_CON_NM		nvarchar(50),
	@PRI_CON_CELL	nvarchar(15),
	@PRI_CON_EMAIL	nvarchar(50),
	@PRI_CON_REL	nvarchar(30),
	@SEC_CON_NM		nvarchar(50),
	@SEC_CON_CELL	nvarchar(15),
	@SEC_CON_EMAIL	nvarchar(50),
	@SEC_CON_REL	nvarchar(30),
	@HOME_TEL		nvarchar(15),
	@ADDRESS		nvarchar(150), 
	@CITY			nvarchar(50),
	@STATE			nvarchar(2),
	@ZIP			nvarchar(12),
	@CON_STAT_CD	nvarchar(15),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_CONTACT
set	USER_ID			= @USER_ID,
	PRI_CON_NM		= @PRI_CON_NM,
	PRI_CON_CELL	= @PRI_CON_CELL,
	PRI_CON_EMAIL	= @PRI_CON_EMAIL,
	PRI_CON_REL		= @PRI_CON_REL,
	SEC_CON_NM		= @SEC_CON_NM,
	SEC_CON_CELL	= @SEC_CON_CELL,
	SEC_CON_EMAIL	= @SEC_CON_EMAIL,
	SEC_CON_REL		= @SEC_CON_REL,
	HOME_TEL		= @HOME_TEL,
	ADDRESS			= @ADDRESS,
	CITY			= @CITY,
	STATE			= @STATE,
	ZIP				= @ZIP,
	CON_STAT_CD	= @CON_STAT_CD,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and CON_ID = @CON_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteContact

	@PORTAL_ID	int,
	@CON_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_CONTACT
where PORTAL_ID = @PORTAL_ID
and CON_ID = @CON_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetContactUser

	@PORTAL_ID		int = NULL,
	@USER_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'SELECT tbl_User.UserID as FIELD_NAME,
	concat(tbl_User.UserID,''-'',tbl_User.DisplayName) as FIELD_VALUE
from {objectQualifier}Users as tbl_User with (nolock)
left outer join {objectQualifier}BSA_LDHV_CONTACT as tbl_Contact on tbl_Contact.USER_ID = tbl_User.UserID
where 1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Contact.PORTAL_ID = @xPORTAL_ID'

IF @USER_ID IS NOT NULL AND @USER_ID > 0
  SELECT @sql = @sql + ' AND tbl_User.UserID = @xUSER_ID'
ELSE
  SELECT @sql = @sql + ' AND tbl_User.UserID NOT IN (SELECT USER_ID FROM {objectQualifier}BSA_LDHV_CONTACT)'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by tbl_User.UserID'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xUSER_ID		int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@USER_ID

GO


/** Drop Existing Scout Stored Procedures **/
if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetScout]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScout
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddScout]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScout
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateScout]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScout
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteScout]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScout
GO


/** Create Scout Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScout

	@PORTAL_ID		int = NULL,
	@SCOUT_ID		int = NULL,
	@USER_ID		int = NULL,
	@FIRST_NM		nvarchar(30) = NULL,
	@LAST_NM		nvarchar(30) = NULL,
	@TROOP_ID		int = NULL,
	@UNIT_ID		int = NULL,
	@SCOUT_STAT_CD	nvarchar(15) = NULL,
	@Params			nvarchar(255) = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''SCOUT_STAT_CD'')
SELECT tbl_Scout.PORTAL_ID,
	tbl_Scout.SCOUT_ID,
	tbl_Scout.USER_ID,
	tbl_Scout.FIRST_NM,
	tbl_Scout.MIDDLE_NM,
	tbl_Scout.LAST_NM,
	tbl_Scout.NICK_NM,
	tbl_Scout.DOB,
	tbl_Scout.CELL,
	tbl_Scout.EMAIL,
	tbl_Scout.GRADE,
	tbl_Status.FIELD_VALUE as STATUS_NM,
	tbl_Scout.CREATED_USERID,
	tbl_Scout.CREATED_DT,
	tbl_Scout.UPDATED_USERID,
	tbl_Scout.UPDATED_DT,'
IF @Params IS NOT NULL AND @Params != ''
   SELECT @sql = @sql + ' @xParams as Params, '
SELECT @sql = @sql + 'tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_SCOUT as tbl_Scout with (nolock)
left outer join {objectQualifier}BSA_LDHV_SCOUT_MEDICAL as tbl_Medical on tbl_Scout.USER_ID = tbl_Medical.USER_ID
left outer join {objectQualifier}BSA_LDHV_SCOUT_DATA as tbl_Data on tbl_Scout.USER_ID = tbl_Data.USER_ID
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_Scout.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_Scout.UPDATED_USERID = tbl_UpdatedUsers.UserId
left outer join tbl_Status on tbl_Data.SCOUT_STAT_CD = tbl_Status.FIELD_NAME
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_Scout.PORTAL_ID = @xPORTAL_ID'

IF @SCOUT_ID IS NOT NULL AND @SCOUT_ID > 0
  SELECT @sql = @sql + ' AND tbl_Scout.SCOUT_ID = @xSCOUT_ID'

IF @USER_ID IS NOT NULL AND @USER_ID > 0
  SELECT @sql = @sql + ' AND tbl_Scout.USER_ID = @xUSER_ID'

IF @FIRST_NM IS NOT NULL AND @FIRST_NM != ''
   SELECT @sql = @sql + ' AND tbl_Scout.FIRST_NM = @xFIRST_NM'

IF @LAST_NM IS NOT NULL AND @LAST_NM != ''
   SELECT @sql = @sql + ' AND tbl_Scout.LAST_NM = @xLAST_NM'

IF @TROOP IS NOT NULL AND @TROOP != ''
   SELECT @sql = @sql + ' AND tbl_Data.TROOP = @xTROOP'

IF @UNIT IS NOT NULL AND @UNIT != ''
   SELECT @sql = @sql + ' AND tbl_Data.UNIT = @xUNIT'

IF @SCOUT_STAT_CD IS NOT NULL AND @SCOUT_STAT_CD != ''
   SELECT @sql = @sql + ' AND tbl_Data.SCOUT_STAT_CD = @xSCOUT_STAT_CD' 

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by FIRST_NM'

SELECT @paramlist = '@xPORTAL_ID	int,
	@xSCOUT_ID		int,
	@xUSER_ID		int,
	@xFIRST_NM		nvarchar(30),
	@xLAST_NM		nvarchar(30),
	@xTROOP			nvarchar(15),
	@xUNIT			nvarchar(15),
	@xSCOUT_STAT_CD	nvarchar(15),
	@xParams		nvarchar(255)'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@SCOUT_ID,
	@USER_ID,
	@FIRST_NM,
	@LAST_NM,
	@TROOP,
	@UNIT,
	@SCOUT_STAT_CD,
	@Params

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScout

	@PORTAL_ID	int,
	@USER_ID	int,
	@FIRST_NM	nvarchar(30),
	@MIDDLE_NM	nvarchar(30),
	@LAST_NM	nvarchar(30),
	@NICK_NM	nvarchar(30),
	@DOB		smalldatetime,
	@CELL		nvarchar(15),
	@EMAIL		nvarchar(50),
	@GRADE		nvarchar(15),
	@UserID		int

as

insert into {objectQualifier}BSA_LDHV_SCOUT (
	PORTAL_ID,
	USER_ID,
	FIRST_NM,
	MIDDLE_NM,
	LAST_NM,
	NICK_NM,
	DOB,
	CELL,
	EMAIL,
	GRADE,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@USER_ID,
	@FIRST_NM,
	@MIDDLE_NM,
	@LAST_NM,
	@NICK_NM,
	@DOB,
	@CELL,
	@EMAIL,
	@GRADE,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScout

	@PORTAL_ID	int,
	@SCOUT_ID	int,
	@USER_ID	int,
	@FIRST_NM	nvarchar(30),
	@MIDDLE_NM	nvarchar(30),
	@LAST_NM	nvarchar(30),
	@NICK_NM	nvarchar(30),
	@DOB		smalldatetime,
	@CELL		nvarchar(15),
	@EMAIL		nvarchar(50),
	@GRADE		nvarchar(15),
	@UserID		int

as

update {objectQualifier}BSA_LDHV_SCOUT
set	USER_ID			= @USER_ID,
	FIRST_NM		= @FIRST_NM,
	MIDDLE_NM		= @MIDDLE_NM,
	LAST_NM			= @LAST_NM,
	NICK_NM			= @NICK_NM,
	DOB				= @DOB,
	CELL			= @CELL,
	EMAIL			= @EMAIL,
	GRADE			= @GRADE,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and SCOUT_ID = @SCOUT_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScout

	@PORTAL_ID	int,
	@SCOUT_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_SCOUT
where PORTAL_ID = @PORTAL_ID
and SCOUT_ID = @SCOUT_ID

GO


/************************************************************/
/*****              SqlDataProvider                     *****/
/************************************************************/
/** Drop Existing ScoutMedical Stored Procedures **/

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetScoutMedical]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScoutMedical
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddScoutMedical]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScoutMedical
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateScoutMedical]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScoutMedical
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteScoutMedical]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScoutMedical
GO


/** Create Scout Medical Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScoutMedical

	@PORTAL_ID			int = NULL,
	@SCOUT_MED_ID	int = NULL,
	@SCOUT_ID			int = NULL,
	@USER_ID			int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'SELECT tbl_ScoutMedical.PORTAL_ID,
	tbl_ScoutMedical.SCOUT_MED_ID,
	tbl_ScoutMedical.SCOUT_ID,
	tbl_ScoutMedical.USER_ID,
	tbl_ScoutMedical.DR_NM,
	tbl_ScoutMedical.DR_TEL,
	tbl_ScoutMedical.INS_NM,
	tbl_ScoutMedical.INS_NO,
	tbl_ScoutMedical.EMER_CON_NM,
	tbl_ScoutMedical.EMER_CON_TEL,
	tbl_ScoutMedical.EMER_CON_REL,
	tbl_ScoutMedical.CURR_MED,
	tbl_ScoutMedical.CURR_MED_NM,
	tbl_ScoutMedical.NOTES,
	tbl_ScoutMedical.CREATED_USERID,
	tbl_ScoutMedical.CREATED_DT,
	tbl_ScoutMedical.UPDATED_USERID,
	tbl_ScoutMedical.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_SCOUT_MEDICAL as tbl_ScoutMedical with (nolock)
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_ScoutMedical.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_ScoutMedical.UPDATED_USERID = tbl_UpdatedUsers.UserId
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutMedical.PORTAL_ID = @xPORTAL_ID'

IF @SCOUT_MED_ID IS NOT NULL AND @SCOUT_MED_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutMedical.SCOUT_MED_ID = @xSCOUT_MED_ID'

IF @SCOUT_ID IS NOT NULL AND @SCOUT_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutMedical.SCOUT_ID = @xSCOUT_ID'

IF @USER_ID IS NOT NULL AND @USER_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutMedical.USER_ID = @xUSER_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by DR_NM'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xSCOUT_MED_ID	int,
	@xSCOUT_ID			int,
	@xUSER_ID			int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@SCOUT_MED_ID,
	@SCOUT_ID,
	@USER_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScoutMedical

	@PORTAL_ID			int,
	@SCOUT_ID			int,
	@USER_ID			int,
	@DR_NM				nvarchar(50),
	@DR_TEL			nvarchar(15),
	@INS_NM				nvarchar(50),
	@INS_NO				nvarchar(30),
	@EMER_CON_NM	nvarchar(50),
	@EMER_CON_TEL			nvarchar(15),
	@EMER_CON_REL		nvarchar(30),
	@CURR_MED			nvarchar(3),
	@CURR_MED_NM		nvarchar(255),
	@NOTES				nvarchar(max),
	@UserID		int

as

insert into {objectQualifier}BSA_LDHV_SCOUT_MEDICAL (
	PORTAL_ID,
	SCOUT_ID,
	USER_ID,
	DR_NM,
	DR_TEL,
	INS_NM,
	INS_NO,
	EMER_CON_NM,
	EMER_CON_TEL,
	EMER_CON_REL,
	CURR_MED,
	CURR_MED_NM,
	NOTES,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@SCOUT_ID,
	@USER_ID,
	@DR_NM,
	@DR_TEL,
	@INS_NM,
	@INS_NO,
	@EMER_CON_NM,
	@EMER_CON_TEL,
	@EMER_CON_REL,
	@CURR_MED,
	@CURR_MED_NM,
	@NOTES,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScoutMedical

	@PORTAL_ID			int,
	@SCOUT_MED_ID	int,
	@SCOUT_ID			int,
	@USER_ID			int,
	@DR_NM				nvarchar(50),
	@DR_TEL			nvarchar(15),
	@INS_NM				nvarchar(50),
	@INS_NO				nvarchar(30),
	@EMER_CON_NM	nvarchar(50),
	@EMER_CON_TEL			nvarchar(15),
	@EMER_CON_REL		nvarchar(30),
	@CURR_MED			nvarchar(3),
	@CURR_MED_NM		nvarchar(255),
	@NOTES				nvarchar(max),
	@UserID				int

as

update {objectQualifier}BSA_LDHV_SCOUT_MEDICAL
set	SCOUT_ID		= @SCOUT_ID,
	USER_ID			= @USER_ID,
	DR_NM			= @DR_NM,
	DR_TEL		= @DR_TEL,
	INS_NM			= @INS_NM,
	INS_NO			= @INS_NO,
	EMER_CON_NM	= @EMER_CON_NM,
	EMER_CON_TEL		= @EMER_CON_TEL,
	EMER_CON_REL	= @EMER_CON_REL,
	CURR_MED		= @CURR_MED,
	CURR_MED_NM		= @CURR_MED_NM,
	NOTES			= @NOTES,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and SCOUT_MED_ID = @SCOUT_MED_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScoutMedical

	@PORTAL_ID			int,
	@SCOUT_MED_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_SCOUT_MEDICAL
where PORTAL_ID = @PORTAL_ID
and SCOUT_MED_ID = @SCOUT_MED_ID

GO

/************************************************************/
/*****              SqlDataProvider                     *****/
/************************************************************/
/** Drop Existing ScoutData Stored Procedures **/

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_GetScoutData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScoutData
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_AddScoutData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScoutData
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_UpdateScoutData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScoutData
GO

if exists (select * from dbo.sysobjects where id = object_id(N'{databaseOwner}[{objectQualifier}BSA_LDHV_DeleteScoutData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScoutData
GO


/** Create Location Stored Procedures **/
create procedure {databaseOwner}{objectQualifier}BSA_LDHV_GetScoutData

	@PORTAL_ID		int = NULL,
	@SCOUT_DATA_ID	int = NULL,
	@SCOUT_ID		int = NULL,
	@USER_ID		int = NULL

as

DECLARE @sql        nvarchar(MAX),
		@paramlist  nvarchar(MAX)

SELECT @sql = 'WITH 
tbl_Status(FIELD_NAME, FIELD_VALUE) AS (select FIELD_NAME, FIELD_VALUE from {objectQualifier}BSA_LDHV_LOOKUP where COLUMN_NAME = ''SCOUT_STAT_CD'')
SELECT tbl_ScoutData.PORTAL_ID,
	tbl_ScoutData.SCOUT_DATA_ID,
	tbl_ScoutData.SCOUT_ID,
	tbl_ScoutData.USER_ID,
	tbl_ScoutData.START_DT,
	tbl_ScoutData.END_DT,
	tbl_ScoutData.SCOUT_STAT_CD,
	tbl_ScoutData.TROOP_ID,
	tbl_ScoutData.UNIT_ID,
	tbl_ScoutData.PATROL_ID,
	tbl_ScoutData.POSITION_ID,
	tbl_ScoutData.RANK_ID,
	tbl_ScoutData.IMAGE_FILE,
	tbl_Status.FIELD_VALUE as STATUS_NM,
	tbl_ScoutData.CREATED_USERID,
	tbl_ScoutData.CREATED_DT,
	tbl_ScoutData.UPDATED_USERID,
	tbl_ScoutData.UPDATED_DT,
	tbl_CreatedUsers.Username as CreatedByUserName,
	tbl_UpdatedUsers.Username as UpdatedByUserName
from {objectQualifier}BSA_LDHV_SCOUT_DATA as tbl_ScoutData with (nolock)
left outer join {objectQualifier}Users as tbl_CreatedUsers on tbl_ScoutData.CREATED_USERID = tbl_CreatedUsers.UserId
left outer join {objectQualifier}Users as tbl_UpdatedUsers on tbl_ScoutData.UPDATED_USERID = tbl_UpdatedUsers.UserId
left outer join tbl_Status on tbl_ScoutData.SCOUT_STAT_CD = tbl_Status.FIELD_NAME
where  1 = 1'

IF @PORTAL_ID IS NOT NULL AND @PORTAL_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutData.PORTAL_ID = @xPORTAL_ID'

IF @SCOUT_DATA_ID IS NOT NULL AND @SCOUT_DATA_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutData.SCOUT_DATA_ID = @xSCOUT_DATA_ID'

IF @SCOUT_ID IS NOT NULL AND @SCOUT_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutData.SCOUT_ID = @xSCOUT_ID'

IF @USER_ID IS NOT NULL AND @USER_ID > 0
  SELECT @sql = @sql + ' AND tbl_ScoutData.USER_ID = @xUSER_ID'

/* IF @debug = 1 */
/*    PRINT @sql */

SELECT @sql = @sql + ' order by SCOUT_STAT_CD'


SELECT @paramlist = '@xPORTAL_ID	int,
	@xSCOUT_DATA_ID	int,
	@xSCOUT_ID		int,
	@xUSER_ID		int'

EXEC sp_executesql @sql, @paramlist,
	@PORTAL_ID,
	@SCOUT_DATA_ID,
	@SCOUT_ID,
	@USER_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_AddScoutData

	@PORTAL_ID		int,
	@SCOUT_ID		int,
	@USER_ID		int,
	@START_DT		smalldatetime,
	@END_DT			smalldatetime,
	@SCOUT_STAT_CD	nvarchar(15),
	@TROOP_ID		int,
	@UNIT_ID		int,
	@PATROL_ID		int,
	@POSITION_ID	int,
	@RANK_ID		int,
	@IMAGE_FILE		nvarchar(255),
	@UserID			int

as

insert into {objectQualifier}BSA_LDHV_SCOUT_DATA (
	PORTAL_ID,
	SCOUT_ID,
	USER_ID,
	START_DT,
	END_DT,
	SCOUT_STAT_CD,
	TROOP_ID,
	UNIT_ID,
	PATROL_ID,
	POSITION_ID,
	RANK_ID,
	IMAGE_FILE,
	CREATED_USERID,
	CREATED_DT
) 
values (
	@PORTAL_ID,
	@SCOUT_ID,
	@USER_ID,
	@START_DT,
	@END_DT,
	@SCOUT_STAT_CD,
	@TROOP_ID,
	@UNIT_ID,
	@PATROL_ID,
	@POSITION_ID,
	@RANK_ID,
	@IMAGE_FILE,
	@UserID,
	getdate()
)

--return the ID of the tranaction back so we can create a TransactionID				
Select SCOPE_IDENTITY() 

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_UpdateScoutData

	@PORTAL_ID		int,
	@SCOUT_DATA_ID	int,
	@SCOUT_ID		int,
	@USER_ID		int,
	@START_DT		smalldatetime,
	@END_DT			smalldatetime,
	@SCOUT_STAT_CD	nvarchar(15),
	@TROOP_ID		int,
	@UNIT_ID		int,
	@PATROL_ID		int,
	@POSITION_ID	int,
	@RANK_ID		int,
	@IMAGE_FILE		nvarchar(255),
	@UserID			int

as

update {objectQualifier}BSA_LDHV_SCOUT_DATA
set	SCOUT_ID		= @SCOUT_ID,
	USER_ID			= @USER_ID,
	START_DT		= @START_DT,
	END_DT			= @END_DT,
	SCOUT_STAT_CD	= @SCOUT_STAT_CD,
	TROOP_ID		= @TROOP_ID,
	UNIT_ID			= @UNIT_ID,
	PATROL_ID		= @PATROL_ID,
	POSITION_ID		= @POSITION_ID,
	RANK_ID			= @RANK_ID,
	IMAGE_FILE		= @IMAGE_FILE,
	UPDATED_USERID	= @UserID,
	UPDATED_DT		= getdate()
where PORTAL_ID = @PORTAL_ID
and SCOUT_DATA_ID = @SCOUT_DATA_ID

GO

create procedure {databaseOwner}{objectQualifier}BSA_LDHV_DeleteScoutData

	@PORTAL_ID		int,
	@SCOUT_DATA_ID	int

as

delete
from   {objectQualifier}BSA_LDHV_SCOUT_DATA
where PORTAL_ID = @PORTAL_ID
and SCOUT_DATA_ID = @SCOUT_DATA_ID

GO


/************************************************************/
/*****              SqlDataProvider                     *****/
/************************************************************/
