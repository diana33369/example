CREATE TABLE Users
(
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Login TEXT NOT NULL,
    Password TEXT NOT NULL,
    Email TEXT NOT NULL,
    Admin INT DEFAULT 0
);
CREATE UNIQUE INDEX Users_Login_uindex ON Users (Login);
CREATE UNIQUE INDEX Users_Email_uindex ON Users (Email);
INSERT INTO Users (Login, Password, Email, Admin) VALUES ('admin', '87654321', 'admin@admin.admin', 1);
INSERT INTO Users (Login, Password, Email, Admin) VALUES ('test', '87654321', 'test@test.test', 0);