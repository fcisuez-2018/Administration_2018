DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Course_Grade`(in ID int(11),
  in Grade_English varchar(255),
  in Grade_Arabic varchar(255),
  in OrderCode int(11),
  in Points float,
  in Percentage float,
  in semesterID int(11),
  in Notes varchar(255),
  in FilterString nvarchar(2000))
BEGIN
Set @table_name ='course_grade';
Set @Actionquery = '';
if (ID is null and Grade_English is not null and Grade_Arabic is not null and OrderCode is not null and Points is not null and Percentage is not null and semesterID is not null and Notes is not null and FilterString is not null )
then
Set @Actionquery=CONCAT('insert into ',@table_name,' (Grade_English, Grade_Arabic, OrderCode, Points, Percentage, semesterID, Notes)
Values(''',Grade_English,''',''',Grade_Arabic,''',',OrderCode,',',Points,',',Percentage,',',semesterID,',''',Notes,''')');
elseif(ID is not null and Grade_English is null and Grade_Arabic is null and OrderCode is null and Points is null and Percentage is null and semesterID is null and Notes is null and FilterString is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);
elseif(ID is not null and Grade_English is not null and Grade_Arabic is not null and OrderCode is not null and Points is not null and Percentage is not null and semesterID is not null and Notes is not null and FilterString is not null )
then
set @Actionquery=CONCAT('update ',@table_name,' set Grade_English= ''',Grade_English,''', Grade_Arabic= ''',Grade_Arabic,''', OrderCode= ',OrderCode,', Points= ',Points,', Percentage= ',Percentage,', semesterID= ',semesterID,', Notes= ''',Notes,''' where ID= ',ID);
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
