.echo on
.headers on

--Name: company.sql
--Author: Oscar Brown
--Date: April 15, 2018

drop table if exists products;

CREATE TABLE Category Question 
  ( 
  Cat_Quest_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Category VARCHAR(30) NOT NULL DEFAULT '', 
  );

CREATE TABLE Question
    (
    Assess_Question_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Question VARCHAR(30) NOT NULL DEFAULT '',
    Cat_Question_ID VARCHAR(30) NOT NULL DEFAULT '',
    Is_Active VARCHAR(30) NOT NULL DEFAULT '',
    );

CREATE TABLE Question_Choice
    (
    Assess_Choice_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Assess_Question_ID VARCHAR(30) NOT NULL,
	Choice INT NOT NULL,
    );

CREATE TABLE Users
    (
    Assess_User_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Assess_Username VARCHAR(30) NOT NULL DEFAULT '',
	Assess_UserEmail VARCHAR(30) NOT NULL DEFAULT '',
	Assess_UserPassword VARCHAR(30) NOT NULL DEFAULT '',
    );

CREATE TABLE User_Result
  (
  User_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,    
  Best_Result   VARCHAR(50) NOT NULL DEFAULT '', 
  Best_Category   VARCHAR(50) NOT NULL DEFAULT '', 
  );
