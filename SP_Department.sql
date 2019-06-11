DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Department`( in ID int(11),
 in Departmenttxt varchar(255),
 in DeptartmentCode varchar(255),
 in FacultyID int(11),
 in OrderCode int(11), 
 in FilterString nvarchar(2000) )
BEGIN
SET @table_name ='department';
Set @Actionquery = '';

if (ID is null and Departmenttxt is not null and DeptartmentCode is not null and
FacultyID is not null and OrderCode is not null and FilterString is not null )
then
set @Actionquery=CONCAT('insert into ',@table_name,' (Departmenttxt, DeptartmentCode, 
FacultyID, OrderCode)
values(''',Departmenttxt,''',''',DeptartmentCode,''',',FacultyID,',',OrderCode,')');

elseif(ID is not null and Departmenttxt is null and DeptartmentCode is null and
FacultyID is null and OrderCode is null and FilterString is not null  )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);

elseif(ID is not null and Departmenttxt is not null and DeptartmentCode is not null and
FacultyID is not null and OrderCode is not null and FilterString is not null )
then
set @Actionquery = CONCAT('update ',@table_name,' set Departmenttxt= ''',Departmenttxt,
''', DeptartmentCode= ''',DeptartmentCode,''', FacultyID= ',FacultyID,', OrderCode= ',OrderCode,
' where ID= ',ID);

end if;

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
