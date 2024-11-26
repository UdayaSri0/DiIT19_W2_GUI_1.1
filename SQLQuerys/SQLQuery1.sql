create database DiIT19SMS;

use DiIT19SMS;

create table Students(
StudentID INT IDENTITY(1,1) PRIMARY KEY,
StudentName VARCHAR(120) NOT NULL,
StudentAge INT NOT NULL,
ContactNo VARCHAR(15) NOT NULL);

INSERT INTO Students (StudentName, StudentAge, ContactNo)
VALUES ('Sumudu Susinidu', 20, '0771234567'),
       ('Mada Pawan', 22, '0772345678');



CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL
);

-- Insert sample user
INSERT INTO Users (Email, Password)
VALUES ('udayasri@email.com', 'Password@123');