﻿CREATE TABLE Student (
    StuID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    StuName VARCHAR(150) NOT NULL DEFAULT (''),
    StuEnrol VARCHAR(150) NOT NULL DEFAULT (''),
    StuDep VARCHAR(150) NOT NULL DEFAULT (''),
    StuSem VARCHAR(150) NOT NULL DEFAULT (''),
    StuContact BIGINT NOT NULL DEFAULT (0),
    StuEmail VARCHAR(150) NOT NULL DEFAULT ('')
);