DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_doctor`(in ID int,
 in NameTxt nvarchar(200), in StatusID int,
 in OrderCode int, in Arabic_doctorName nvarchar(200),
 in FilterString nvarchar(2000) )
BEGIN
SET @table_name ='doctor';
Set @Actionquery = '';
if (ID is null and NameTxt is not null and StatusID is not null and OrderCode is not null and Arabic_doctorName is not null and FilterString is not null )
then
set @Actionquery=CONCAT('insert into ',@table_name,' (NameTxt,StatusID,OrderCode,Arabic_doctorName )
 values(''',NameTxt,''',',StatusID,',',OrderCode,',''',Arabic_doctorName,''')');
elseif(ID is not null and NameTxt is null and StatusID is null and OrderCode is null and Arabic_doctorName is null and FilterString is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);
elseif(ID is not null and NameTxt is not null and StatusID is not null and OrderCode is not null and Arabic_doctorName is not null  and FilterString is not null )
then
set @Actionquery=CONCAT('update ',@table_name,' set NameTxt= ''',NameTxt,''', StatusID= ',StatusID,', OrderCode= ',OrderCode,', Arabic_doctorName= ''',Arabic_doctorName,''' where ID= ',ID);
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
