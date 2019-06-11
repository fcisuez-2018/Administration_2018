DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Course`( in `ID` int,
 in `Code` varchar(255), in `ArabicName` varchar(255),
 in `Course` varchar(255), in `Credits` int(11),
 in `Prerequisits` varchar(255), in `CourseTypeID` int(11),
 in `Teaching Hours Lecture` int(11),
 in `Teching Hours Tutorial` varchar(255),
 in `TeachingHours Practical` int(11),
 in `Midterm` decimal(8,2) ,
 in `Year Work Grades O` decimal(8,2),
 in `Year Work Grades PE` decimal(8,2),
 in `YearWorkGrades G` decimal(8,2) ,
 in `FinalExam` decimal(8,2) ,
 in `TimeofExam` int(11),
 in `LeveLID` int(11) , in `DepartmentID` int(11) ,
 in `OrderCode` int(11) ,
 in `StatusID` int(11) ,
 in `CurriculumID` int(11),
 in `FilterString` nvarchar(2000) )
BEGIN 
SET @table_name ='course';
Set @Actionquery = '';

if (`ID` is null  and `Code` is not null and `ArabicName` is not null and `Course` is not null and `Credits` is not null and
`prerequisits` is not null  and `CourseTypeID` is not null and `Teaching Hours Lecture` is not null and `Teching Hours Tutorial` is not null 
and `TeachingHours Practical` is not null and `Midterm` is not null and `Year Work Grades O` is not null and `Year Work Grades PE` is not null 
and `YearWorkGrades G` is not null and `FinalExam` is not null and `TimeofExam` is not null  and `LevelID` is not null and `DepartmentID` is not null 
and `OrderCode` is not null  and `StatusID` is not null and `CurriculumID` is not null and `FilterString` is not null )
then
set @Actionquery=CONCAT('insert into ',@table_name,' (`Code`, `ArabicName`, `Course`, `Credits`,
 `prerequisits`, `CourseTypeID`, `Teaching Hours Lecture`, `Teching Hours Tutorial`,
 `TeachingHours Practical`, `Midterm`, `Year Work Grades O`, `Year Work Grades PE`, 
 `YearWorkGrades G`, `FinalExam`, `TimeofExam`, `LevelID`, `DepartmentID`, `OrderCode`, `StatusID`, `CurriculumID` )

 Values(''',`Code`,''',''',`ArabicName`,''',''',`Course`,''',',`Credits`,',''',`prerequisits`,''',',`CourseTypeID`,','
 ,`Teaching Hours Lecture`,',''',`Teching Hours Tutorial`,''',',`TeachingHours Practical`,','
 ,`Midterm`,',',`Year Work Grades O`,',',`Year Work Grades PE`,',',`YearWorkGrades G`,','
 ,`FinalExam`,',',`TimeofExam`,',',`LevelID`,',',`DepartmentID`,',',`OrderCode`,',',`StatusID`,',',`CurriculumID`,')');

elseif(`ID` is not null  and `Code` is null and `ArabicName` is null and `Course` is null and `Credits` is null 
and `prerequisits` is null  and `CourseTypeID` is null and `Teaching Hours Lecture` is null and `Teching Hours Tutorial` is null 
and `TeachingHours Practical`  is null and `Midterm` is null and `Year Work Grades O` is null and `Year Work Grades PE` is null 
and `YearWorkGrades G` is null and `FinalExam` is null and `TimeofExam` is null  and `LevelID` is null and `DepartmentID` is null 
and `OrderCode` is null  and `StatusID` is null and `CurriculumID`
is null and `FilterString` is not null )
then
set @Actionquery=CONCAT('delete FROM ',@table_name,' where ID= ',`ID`);

elseif(`ID` is not null and `Code` is not null and `ArabicName` is not null and `Course` is not null and `Credits` is not null and
`prerequisits` is not null  and `CourseTypeID` is not null and `Teaching Hours Lecture` is not null and `Teching Hours Tutorial` is not null 
and `TeachingHours Practical` is not null and `Midterm` is not null and `Year Work Grades O` is not null and `Year Work Grades PE` is not null 
and `YearWorkGrades G` is not null and `FinalExam` is not null and `TimeofExam` is not null  and `LevelID` is not null and `DepartmentID` is not null 
and `OrderCode` is not null  and `StatusID` is not null and `CurriculumID` is not null and `FilterString` is not null )
then
 Set @Actionquery=CONCAT('update ',@table_name,' set Code= ''',`Code`,''', ArabicName= ''',`ArabicName`,
 ''', Course= ''',`Course`,''', Credits= ',`Credits`,', prerequisits= ''',`prerequisits`,''', CourseTypeID= ',`CourseTypeID`,
 ', Teching Hours Lecture= ',`Teaching Hours Lecture`,', Teching Hours Tutorial= ''',`Teching Hours Tutorial`,
 ''', TeachingHours Practical= ',`TeachingHours Practical`,', Midterm= ',`Midterm`,', Year Work Grades O= ',`Year Work Grades O`,
 ', Year Work Grades PE= ',`Year Work Grades PE`,', YearWorkGrades G= ',`YearWorkGrades G`,
 ', FinalExam= ',`FinalExam`,', TimeofExam= ',`TimeofExam`,', LevelID= ',`LevelID`,', DepartmentID= ',`DepartmentID`,
 ', OrderCode= ',`OrderCode`,', StatusID= ',`StatusID`,', CurriculumID= ',`CurriculumID`,' where ID= ',`ID`);

end if;

PREPARE stmt FROM @Actionquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
SET @selectquery=CONCAT('SELECT * FROM ',@table_name,' where 1=1');
Set @selectquery = replace(@selectquery,'1=1', `FilterString`);
PREPARE stmt FROM @selectquery;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;
