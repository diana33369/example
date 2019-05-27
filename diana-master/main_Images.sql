CREATE TABLE Images
(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Author TEXT NOT NULL,
    Create_date TEXT NOT NULL,
    Format TEXT NOT NULL,
    Author_id INT NOT NULL,
    CONSTRAINT Images_Users__fk FOREIGN KEY (Author) REFERENCES Users (Login),
    CONSTRAINT Images_Users__fk FOREIGN KEY (Author_id) REFERENCES Users (Id)
);
INSERT INTO Images (Name, Author, Create_date, Format, Author_id) VALUES ('TEST_NAME', 'test', '14.02.1998', 'PNG', 2);
INSERT INTO Images (Name, Author, Create_date, Format, Author_id) VALUES ('TEST_NAME', 'test', '14.02.1998', 'PNG', 123);