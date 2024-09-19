CREATE TABLE IRBook( 
    id INT NOT NULL IDENTITY (1,1) primary key,
    std_enroll VARCHAR (50) NOT NULL DEFAULT (''),
    std_name VARCHAR(150) NOT NULL DEFAULT (''),
    std_dep VARCHAR(150) NOT NULL DEFAULT (''),
    std_sem VARCHAR(10) NOT NULL DEFAULT (''),
    std_contact BIGINT NOT NULL DEFAULT (''),
    std_email VARCHAR(150) NOT NULL DEFAULT (''),
    book_name VARCHAR(150) NOT NULL DEFAULT (''),
    book_issue_date VARCHAR(150) NOT NULL DEFAULT (''),
    book_return_date VARCHAR(150) NOT NULL DEFAULT ('')
    );

