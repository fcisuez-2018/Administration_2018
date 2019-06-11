DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_level`(in ID int,
 in LevelTxt nvarchar(200), in LevelNumber int, in LevelCreditHours int,
 in LevelTxt_Arabic nvarchar(200), in FilterString nvarchar(2000) )
BEGIN
SET @table_name ='level';
Set @Actionquery = '';
if (ID is null and LevelTxt is not null and LevelNumber is not null and LevelCreditHours is not null and LevelTxt_Arabic is  not null and FilterString is not null )
then
set @Actionquery=CONCAT('insert into ',@table_name,' (LevelTxt,LevelNumber,LevelCreditHours,LevelTxt_Arabic)
 values(''',LevelTxt,''',',LevelNumber,',',LevelCreditHours,',''',LevelTxt_Arabic,''')');
elseif(ID is not null and LevelTxt is null and LevelNumber is null and LevelCreditHours is null and LevelTxt_Arabic is null and FilterString is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',ID);
elseif(ID is not null and LevelTxt is not null and LevelNumber is not null and LevelCreditHours is not null and LevelTxt_Arabic is not null and FilterString is not null )
then
set @Actionquery=CONCAT('update ',@table_name,' set LevelTxt= ''',LevelTxt,''', LevelNumber= ',LevelNumber,', LevelCreditHours= ',LevelCreditHours,', LevelTxt_Arabic= ''',LevelTxt_Arabic,''' where ID= ',ID);
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
