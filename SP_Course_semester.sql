DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Course_semester`(in ID int ,
 in semesterID int ,
 in courseID int ,
 in doctorID int ,
 in FilterString nvarchar(2000)  )
BEGIN
SET @table_name ='Course_semester';
Set @Actionquery = '';
if (ID is null and semesterID is not null and courseID is not null and doctorID is not null  )
then
set @Actionquery=CONCAT('insert into ',@table_name,' (semesterID ,courseID ,doctorID) values(',semesterID,',',courseID,',',doctorID,')');
elseif(ID is not null and semesterID is null and courseID is  null and doctorID is null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);
elseif(ID is not null and semesterID is not null and courseID is not null and doctorID is not null )
then
set @Actionquery=CONCAT('update ',@table_name,' set SemesterID= ',semesterID,', courseID= ',courseID,', doctorID= ',doctorID,' where ID= ',ID);
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
