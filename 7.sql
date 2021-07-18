CREATE TABLE Teachers (
  ID int PRIMARY KEY,
  FirstName varchar(255),
  LastName varchar(255),
  Sex varchar(255),
  Subject varchar(255)
);

INSERT INTO Teachers ( ID, FirstName, LastName, Sex, Subject)
VALUES ( 1, 'Pythagoras', 'Pythagoras', 'Male', 'Math');

INSERT INTO Teachers ( ID, FirstName, LastName, Sex, Subject)
VALUES ( 2, 'Herodotus', 'Herodotus', 'Male', 'History');

INSERT INTO Teachers ( ID, FirstName, LastName, Sex, Subject)
VALUES ( 3, 'Isaac', 'Newton', 'Male', 'Physic');

INSERT INTO Teachers ( ID, FirstName, LastName, Sex, Subject)
VALUES ( 4, 'Dimitri', 'Mendeleev', 'Male', 'Chemistry');

CREATE TABLE Pupils (
  ID int PRIMARY KEY,
  FirstName varchar(255),
  LastName varchar(255),
  Sex varchar(255),
  Class int
);

INSERT INTO Pupils ( ID, FirstName, LastName, Sex, Class)
VALUES ( 1, 'giorgi', 'giorgi', 'Male', 10 );

INSERT INTO Pupils ( ID, FirstName, LastName, Sex, Class)
VALUES ( 2, 'mariami', 'mariami', 'Female', 9 );

INSERT INTO Pupils ( ID, FirstName, LastName, Sex, Class)
VALUES ( 3, 'elene', 'elene', 'Female', 11 );

INSERT INTO Pupils ( ID, FirstName, LastName, Sex, Class)
VALUES ( 4, 'lasha', 'lasha', 'Male', 3 );

INSERT INTO Pupils ( ID, FirstName, LastName, Sex, Class)
VALUES ( 5, 'shoti', 'shoti', 'Male', 3 );

CREATE TABLE TeacherPupil (
  ID int PRIMARY KEY,
  TeacherId int,
  PupilId int,
  FOREIGN KEY (TeacherId) REFERENCES Teachers(ID),
  FOREIGN KEY (PupilId) REFERENCES Pupils(ID)
);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 1, 2, 1);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 2, 3, 1);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 3, 4, 1);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 4, 1, 2);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 5, 2, 3);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 6, 3, 4);

INSERT INTO TeacherPupil ( ID, TeacherId, PupilId)
VALUES ( 7, 4, 5);

SELECT Teachers.FirstName, Teachers.LastName FROM Teachers 
INNER JOIN TeacherPupil ON Teachers.ID = TeacherPupil.TeacherId 
INNER JOIN  Pupils ON Pupils.ID = TeacherPupil.PupilId 
WHERE Pupils.FirstName = "giorgi";