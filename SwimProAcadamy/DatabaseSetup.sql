-- Run this script once in MySQL Workbench before running the application.
CREATE DATABASE IF NOT EXISTS swimpro_db;
USE swimpro_db;

CREATE TABLE IF NOT EXISTS Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(64) NOT NULL
);
