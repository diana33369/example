CREATE TABLE Logs
(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Authorization TEXT NOT NULL,
    Username TEXT NOT NULL,
    User_id INT NOT NULL,
    CONSTRAINT Logs_Users__fk FOREIGN KEY (Username) REFERENCES Users (Login),
    CONSTRAINT Logs_Users__fk FOREIGN KEY (User_id) REFERENCES Users (Id)
);
INSERT INTO Logs (Authorization, Username, User_id) VALUES ('14.02.1998', 'test', 2);