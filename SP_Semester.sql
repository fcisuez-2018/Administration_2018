DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Semester`(in ID int(11),
  in Semester varchar(255),
  in SemesterFullName varchar(255),
  in SemesterArabicName varchar(255),
  in SemesterEnumID int(11),
  in StatusID int(11),
  in FilterString nvarchar(2000))
BEGIN
Set @table_name ='semester';

Set @Actionquery = '';
if (ID is null and Semester is not null and SemesterFullName is not null and SemesterArabicName is not null and SemesterEnumID is not null and StatusID is not null and FilterString is not null )
then

Set @Actionquery=CONCAT('insert into ',@table_name,' (Semester,SemesterFullName, SemesterArabicName, SemesterEnumID, StatusID)
Values( ''',Semester,''',''',SemesterFullName,''',''',SemesterArabicName,''',', SemesterEnumID, ',',StatusID,')');
elseif(ID is not null and Semester is null and SemesterFullName is null and SemesterArabicName is null and SemesterEnumID is null and StatusID is null and FilterString is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);
elseif(ID is not null and Semester is not null and SemesterFullName is not null and SemesterArabicName is not null and SemesterEnumID is not null and StatusID is not null and FilterString is not null )
then
set @Actionquery=CONCAT('update ',@table_name,' set Semester= ''',Semester,''', SemesterFullName= ''',SemesterFullName,''', SemesterArabicName= ''',SemesterArabicName,''', SemesterEnumID= ',SemesterEnumID,', StatusID= ',StatusID,' where ID= ',ID);
end if;
/*
Select @Actionquery;
*/
PREPARE stmt FROM @Actionquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
SET @selectquery=CONCAT('SELECT * FROM ',@table_name,' where 1=1');
Set @selectquery = replace(@selectquery,'1=1', FilterString);
PREPARE stmt FROM @selectquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

END$$
DELIMITER ;
