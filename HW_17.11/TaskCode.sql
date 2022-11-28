--1
select * from Persons p
join Addresses a on p.AddressId = a.Id
where a.City like 'Lake%'

--2
select Country from Addresses a
group by Country

--3
select p.Name from Persons p
join PersonsStudySubjects pss on p.Id = pss.StudentId
where p.Name like 'D%'

--4
select p.Name from Persons p
join StudySubjects ss on ss.ProfessorId = p.Id
where p.Name like '%c%'
group by p.Name

--5
select p.Name from Persons p
join PersonsStudySubjects pss on p.Id = pss.StudentId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
where p.Age>30 and u.Name = 'Carter - Gusikowski' and ss.ProfessorId != p.Id
group by p.Name

--6
select * from Persons p
left join PersonsStudySubjects pss on pss.StudentId = p.Id
where pss.StudentId is null

--7
select * from Persons p
left join StudySubjects ss on ss.ProfessorId = p.Id
where ss.ProfessorId is null

--8
select * from Persons p
join Addresses a on a.Id=p.AddressId
join PersonsStudySubjects pss on p.Id = pss.StudentId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
where u.Name = 'Bailey Group' and a.City like 'Lake%' and p.Id != ss.ProfessorId

--9
select u.Name,Count(p.Id) as [number of students] from Persons p
join PersonsStudySubjects pss on p.Id = pss.StudentId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
where p.Age>30
group by u.Name

--10
select u.Name,avg(p.Age) as [average age of people] from Persons p
join PersonsStudySubjects pss on p.Id = pss.StudentId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
group by u.Name

--11
select u.Name, a.City,Count(p.Name) as [number of students] from Persons p
join PersonsStudySubjects pss on pss.StudentId = p.Id
join Addresses a on a.Id = p.AddressId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
where p.Id != ss.ProfessorId
group by a.City, u.Name

--12
select p.Name from Persons p
join PersonsStudySubjects pss on p.Id = pss.StudentId
join StudySubjects ss on ss.Id = pss.SubjectId
join Universities u on u.Id = ss.UniversityId
where p.AddressId = u.AddressId and p.Id != ss.ProfessorId
group by p.Name

--13
select a.City, avg(p.Age) as [average age of students] from Persons p
join PersonsStudySubjects pss on pss.StudentId = p.Id
join Addresses a on a.Id = p.AddressId
group by City