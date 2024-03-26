Select T.Name ,T.ID, Count(c.Name)
from Trainees T join CrsResults crs
on crs.TraineeID = T.ID 
join Course C 
on C.ID = crs.CourseID
group by T.Name,T.ID

SELECT [c1].[ID], [c1].[CrsHours], [c1].[Degree], [c1].[DepartmentID], [c1].[MinDegree], [c1].[Name]
FROM [Trainees] AS [t]
INNER JOIN (
    SELECT [c].[CourseID], [t1].[ID] AS [ID0]
    FROM [CrsResults] AS [c]
    INNER JOIN [Trainees] AS [t1] ON [c].[TraineeID] = [t1].[ID]
) AS [t0] ON [t].[ID] = [t0].[ID0]
INNER JOIN [Course] AS [c0] ON [t0].[CourseID] = [c0].[ID]
INNER JOIN [Course] AS [c1] ON [c0].[ID] = [c1].[ID]


SELECT
    t.ID AS TraineeID,
    COUNT(crs.CourseID) AS NumberOfCourses
FROM
    Trainees t
LEFT JOIN
    CrsResults crs ON t.ID = crs.TraineeID
GROUP BY
    t.ID;


SELECT
    t.ID AS TraineeID,
    c.Name
FROM
    Trainees t
LEFT JOIN
    CrsResults crs ON t.ID = crs.TraineeID
LEFT JOIN
    Course c ON crs.CourseID = c.ID
GROUP BY
    t.ID, c.Name
ORDER BY
    t.ID;


	SELECT TOP(1) [t].[Name] AS [TraineeName], [c0].[Name] AS [CourseName], [t].[Degree] AS [TraineeDegree], [c0].[MinDegree] AS [CourseMinDegree]
FROM [CrsResults] AS [c]
INNER JOIN [Trainees] AS [t] ON [c].[TraineeID] = [t].[ID]
INNER JOIN [Course] AS [c0] ON [c].[CourseID] = [c0].[ID]


SELECT CrsResult.TraineeID, CrsResult.CourseID
FROM CrsResults AS CrsResult
JOIN Trainees AS Trainee ON CrsResult.TraineeID = Trainee.ID
JOIN Course AS Course ON CrsResult.CourseID = Course.ID
WHERE CrsResult.degree < Course.MinDegree;


SELECT CrsResult.TraineeID, CrsResult.CourseID, CrsResult.degree , Trainee.Degree,Course.MinDegree
FROM CrsResults AS CrsResult
JOIN Trainees AS Trainee ON CrsResult.TraineeID = Trainee.ID
JOIN Course AS Course ON CrsResult.CourseID = Course.ID
WHERE CrsResult.degree < Course.MinDegree
AND CrsResult.TraineeID = 67
AND CrsResult.CourseID = 18

--///////////// Faild
select  T.Name, T.ID,C.Name , C.ID , C.MinDegree 
from Trainees As T 
join CrsResults as CR 
on CR.TraineeID = T.ID
join Course As C 
on C.ID = Cr.CourseID
where C.MinDegree > CR.degree
order by T.ID

alter table Trainees
drop column Degree


--///////////// Success -> 
select  T.Name, T.ID,C.Name , C.ID , C.MinDegree 
from Trainees As T 
join CrsResults as CR 
on CR.TraineeID = T.ID
join Course As C 
on C.ID = Cr.CourseID
where C.MinDegree < CR.degree
order by T.ID


select  T.Name, T.ID, C.ID,  C.Name  ,C.MinDegree , CR.degree
from Trainees As T 
join CrsResults as CR 
on CR.TraineeID = T.ID
join Course As C 
on C.ID =  Cr.CourseID
where T.ID = 80



select T.Name,C.Name ,cr.degree
from Trainees T
join CrsResults cr
on cr.TraineeID = T.ID
join Course C
on c.ID = cr.CourseID
where T.ID= 50
