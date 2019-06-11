DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Student`( in `ID` int(11),
 in `StudentName` varchar(255), in `StudentEductionalNumber` int(11), in `DOB` datetime,
 in `NationalityID` int(11), in `Phone` varchar(255), in `GenderID` int(11),
 in `جهة اصدار البطاقة` varchar(255), in `جهة الميلاد` varchar(255), in `الديانة` varchar(255),
 in `المؤهل الدراسي وتاريخة` varchar(255), in `العنوان` varchar(255), in `Email` varchar(255),
 in `حالة القيد` varchar(255), in `ActivityID` int(11), in `MilitaryStatusID` int(11),
 in `AdvisorID` int(11), in `SocialNumber` varchar(255), in `MajorDepartmentID` int(11),
 in `MinorDepartmentID` int(11), in `StatusID` int(11), in `MilitaryEducationID` int(11),
 in `CurriculumID` int(11), in `FilterString` nvarchar(2000) )
BEGIN
SET @table_name ='Student';
Set @Actionquery = '';

if (`ID` is null and `StudentName` is not null and `StudentEductionalNumber` is not null and
 `DOB`  is not null and `NationalityID` is not null and `Phone` is not null and  `GenderID` is not null and 
 `جهة اصدار البطاقة` is not null and `جهة الميلاد` is not null and `الديانة` is not null and `المؤهل الدراسي وتاريخة` is not null and `العنوان` is not null and 
 `Email` is not null and `حالة القيد` is not null and `ActivityID` is not null and  `MilitaryStatusID` is not null and  `AdvisorID` is not null and  
 `SocialNumber` is not null and `MajorDepartmentID` is not null and  `MinorDepartmentID` is not null and `StatusID` is not null and 
 `MilitaryEducationID` is not null and `CurriculumID` is not null and `FilterString` is not null )
then
Set @Actionquery=CONCAT('insert into ',@table_name,' ( `StudentName`, 
 `StudentEductionalNumber`, `DOB`, `NationalityID`, `Phone`, `GenderID`,`جهة اصدار البطاقة`, `جهة الميلاد`, `الديانة`, `المؤهل الدراسي وتاريخة`, `العنوان`,
 `Email`, `حالة القيد`, `ActivityID`, `MilitaryStatusID`, `AdvisorID`, `SocialNumber`, `MajorDepartmentID`,
 `MinorDepartmentID`, `StatusID`, `MilitaryEducationID`, `CurriculumID` )
 values(''',`StudentName`,''',',`StudentEductionalNumber`,',',`DOB`,',',`NationalityID`,',''',`Phone`,''',',`GenderID`,',',`Email`,
 ',',`ActivityID`,',',`MilitaryStatusID`,',',`AdvisorID`,',',`SocialNumber`,',',`MajorDepartmentID`,',',`MinorDepartmentID`,',',`StatusID`,
 ',',`MilitaryEducationID`,',',`CurriculumID`,')');

elseif(`ID` is not null and `StudentName` is null and `StudentEductionalNumber` is null and
 `DOB`  is null and `NationalityID` is null and `Phone` is null and  `GenderID` is null and 
 `جهة اصدار البطاقة` is null and `جهة الميلاد` is null and `الديانة` is null and `المؤهل الدراسي وتاريخة` is null and `العنوان` is null and 
 `Email` is null and `حالة القيد` is null and `ActivityID` is null and  `MilitaryStatusID` is null and  `AdvisorID` is null and  
 `SocialNumber` is null and `MajorDepartmentID` is null and  `MinorDepartmentID` is null and `StatusID` is null and 
 `MilitaryEducationID` is null and `CurriculumID` is null and `FilterString` is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',`ID`);

elseif(`ID` is not null and `StudentName` is not null and `StudentEductionalNumber` is not null and
 `DOB`  is not null and `NationalityID` is not null and `Phone` is not null and  `GenderID` is not null and 
 `جهة اصدار البطاقة` is not null and `جهة الميلاد` is not null and `الديانة` is not null and `المؤهل الدراسي وتاريخة` is not null and `العنوان` is not null and 
 `Email` is not null and `حالة القيد` is not null and `ActivityID` is not null and  `MilitaryStatusID` is not null and  `AdvisorID` is not null and  
 `SocialNumber` is not null and `MajorDepartmentID` is not null and  `MinorDepartmentID` is not null and `StatusID` is not null and 
 `MilitaryEducationID` is not null and `CurriculumID` is not null and `FilterString` is not null )
then
Set @Actionquery=CONCAT('update ',@table_name,' set StudentName= ''',`StudentName`,''', StudentEductionalNumber= ',`StudentEductionalNumber`,
', DOB= ',`DOB`,', NationalityID= ',`NationalityID`,', Phone= ''',`Phone`,''', GenderID= ',`GenderID`,', Email= ',`Email`,
', ActivityID= ',`ActivityID`,', MilitaryStatusID= ',`MilitaryStatusID`,', AdvisorID= ',`AdvisorID`,', SocialNumber= ',`SocialNumber`,
', MajorDepartmentID= ',`MajorDepartmentID`,', MinorDepartmentID= ',`MinorDepartmentID`,', StatusID= ',`StatusID`,
', MilitaryEducationID= ',`MilitaryEducationID`,', CurriculumID= ',`CurriculumID`,' where ID= ',`ID`);

end if;

PREPARE stmt FROM @Actionquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
SET @selectquery=CONCAT('SELECT * FROM ',@table_name,' where 1=1');
Set @selectquery = replace(@selectquery,'1=1', `FilterString`);
PREPARE stmt
FROM @selectquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;
