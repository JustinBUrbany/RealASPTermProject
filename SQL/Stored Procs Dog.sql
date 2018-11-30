Create Table FinalDogs 
(
	ID int primary key identity(1, 1),
	DogType varchar(50),
	Name varchar(50),
	Age int,
	Sex varchar(10),
	ImagePath varchar(256),
	Timestamp datetime default(getdate())

)

Drop Table FinalDogs

Create Procedure Dog_GetList
AS
BEGIN
	Select *
	FROM FinalDogs
	ORDER BY Name
END

Create Procedure DOG_GetListType
(
	@Type varchar(50) 
)
AS
BEGIN
Select *
	FROM FinalDogs
	Where DogType = @Type
	Order By Name
END
Create Procedure Dog_GetListTypeSex
(
	@Type varchar(50),
	@Sex varchar(25)
)
AS
BEGIN
Select *
	FROM FinalDogs
	Where DogType = @Type AND Sex = @Sex
	Order By Name
END


Insert INto FinalDogs(DogType, Name, Age, Sex,ImagePath)
Values ('German Sheppard', 'Chuck', 5, 'Male', '/Images/GShep.jpeg')
Insert INto FinalDogs(DogType, Name, Age, Sex, ImagePath)
Values ('German Sheppard', 'Sharkie', 2, 'Female', '/Images/GShep.jpeg')
Insert INto FinalDogs(DogType, Name, Age, Sex, ImagePath)
Values ('Bull Dog', 'Bully', 8, 'Male', '/Images/GShep.jpeg')
Insert INto FinalDogs(DogType, Name, Age, Sex, ImagePath)
Values ('Bull Dog', 'Barbie', 6, 'Female', '/Images/GShep.jpeg')
Insert INto FinalDogs(DogType, Name, Age, Sex, ImagePath)
Values ('Labrador Retriever', 'treiver', 3, 'Male', '/Images/GShep.jpeg')
Insert INto FinalDogs(DogType, Name, Age, Sex, ImagePath)
Values ('Labrador Retriever', 'Sally', 1, 'Female', '/Images/GShep.jpeg')

select *
from FinalDogs