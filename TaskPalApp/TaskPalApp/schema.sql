-- Create table for users
CREATE TABLE IF NOT EXISTS users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL,
    Email TEXT,
    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP
);

-- Create table for tasks
CREATE TABLE IF NOT EXISTS tasks (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Title TEXT NOT NULL,
    Description TEXT,
    DueDate TEXT,
    IsCompleted INTEGER DEFAULT 0,
    Priority INTEGER CHECK(Priority IN (0, 1, 2)), -- 0: Low, 1: Medium, 2: High
    ProjectId INTEGER,
    UserId INTEGER,
    FOREIGN KEY (ProjectId) REFERENCES projects(Id),
    FOREIGN KEY (UserId) REFERENCES users(Id)
);

-- Create table for projects
CREATE TABLE IF NOT EXISTS projects (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Title TEXT NOT NULL,
    Description TEXT,
    DueDate TEXT,
    IsUrgent INTEGER DEFAULT 0,
    UserId INTEGER,
    FOREIGN KEY (UserId) REFERENCES users(Id)
);

-- Create table for user roles
CREATE TABLE IF NOT EXISTS user_roles (
    UserId INTEGER,
    Role TEXT,
    FOREIGN KEY (UserId) REFERENCES users(Id)
);

-- Create table for comments on tasks
CREATE TABLE IF NOT EXISTS comments (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Content TEXT,
    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP,
    TaskId INTEGER,
    UserId INTEGER,
    FOREIGN KEY (TaskId) REFERENCES tasks(Id),
    FOREIGN KEY (UserId) REFERENCES users(Id)
);
