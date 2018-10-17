create table Student (
	Id integer not null primary key autoincrement,
	FirstName text not null,
	LastName text not null,
	SlackHandle text not null,
	CohortId integer not null,
	foreign key(CohortId) references Cohort(Id)
);

create table Instructor (
	Id integer not null primary key autoincrement,
	FirstName text not null,
	LastName text not null,
	SlackHandle text not null,
	CohortId integer not null,
	foreign key(CohortId) references Cohort(Id)
);

create table Exercise (
	Id integer not null primary key autoincrement,
	Name text not null,
	Language text not null
);

create table Cohort (
	Id integer not null primary key autoincrement,
	Name text not null
);

insert into Cohort (Name) values ("Cohort 26");
insert into Cohort (Name) values ("Cohort 27");
insert into Cohort (Name) values ("Cohort 28");

insert into Exercise (Name, Language) values ("FizzBuzz", "JavaScript");
insert into Exercise (Name, Language) values ("Nutshell", "React");
insert into Exercise (Name, Language) values ("Bangazon", "C#");
insert into Exercise (Name, Language) values ("Weather", "JavaScript");
insert into Exercise (Name, Language) values ("Overly Excited", "JavaScript");
insert into Exercise (Name, Language) values ("Classes", "C#");
insert into Exercise (Name, Language) values ("Front-End Capstone", "React");
insert into Exercise (Name, Language) values ("Daily Journal", "jQuery");
insert into Exercise (Name, Language) values ("Dictionaries", "C#");
insert into Exercise (Name, Language) values ("Lists", "C#");


insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Steve", "Brownlee", "Steve", 1);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Meg", "Ducharme", "Meg", 2);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Brenda", "Long", "Brenda", 3);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Andy", "Collins", "Andy Collins", 1);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Jenna", "Solis", "Jenna Solis", 2);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Jisie", "David", "Jisie David", 3);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Joe", "Shepherd", "Joe Shepherd", 1);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Kimmy", "Bird", "Kimmy Bird", 2);
insert into Instructor (FirstName, LastName, SlackHandle, CohortId) values ("Teresa", "Vasquez", "Teresa Vasquez", 3);

insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Nick", "Black", "Nick Black", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Kelly", "Cook", "Kelly Cook", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Streator", "Ward", "Streator Ward", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Alejandro", "Font", "alejandro font", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Daniel", "Figueroa", "Daniel Figueroa", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("David", "Taylor", "David Taylor", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Dejan", "Stjepanovic", "Dejan Stjepanovic", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Gretchan", "Ward", "Gretchenmward", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Helen", "Chalmers", "Helen Chalmers", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Jeremiah", "Pritchard", "Jeremiah Pritchard", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Jonathan", "Edwards", "Jonathan Edwards", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Kayla", "Reid", "Kayla Reid", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Klaus", "Hardt", "Klaus Hardt", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Madi", "Peper", "Madi Peper", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Mark", "Hale", "Mark Hale", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Matthew", "Hall", "Mateusvanhalen", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Michael", "McClenton", "Michael CmClenton", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Mike", "Parrish", "Mike Parrish", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Priyanka", "Garg", "Priyanka Garg", 3);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Ricky", "Bruner", "Ricky Bruner", 1);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Taylor", "Gulley", "Taylor Gulley", 2);
insert into Student (FirstName, LastName, SlackHandle, CohortId) values ("Aaron", "Keen", "Aaron Keen", 3);
