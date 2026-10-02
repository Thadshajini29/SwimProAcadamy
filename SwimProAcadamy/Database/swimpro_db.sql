CREATE DATABASE IF NOT EXISTS swimpro_db;
USE swimpro_db;

CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(64) NOT NULL
);

CREATE TABLE IF NOT EXISTS swimmers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    age INT NOT NULL,
    training_plan VARCHAR(20) NOT NULL,
    competition_category VARCHAR(20) NOT NULL,
    competitions INT NOT NULL DEFAULT 0,
    coaching_hours DECIMAL(5,2) NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS fees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    swimmer_id INT NOT NULL,
    training_fee DECIMAL(10,2) NOT NULL,
    competition_fee DECIMAL(10,2) NOT NULL,
    coaching_fee DECIMAL(10,2) NOT NULL,
    total_fee DECIMAL(10,2) NOT NULL,
    created_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_fees_swimmer FOREIGN KEY (swimmer_id) REFERENCES swimmers(id)
);
