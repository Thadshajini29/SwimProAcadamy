CREATE DATABASE IF NOT EXISTS swimpro_db;
USE swimpro_db;

-- Run this script on a new/empty swimpro_db database.
-- If you already ran the old script, create a new database or drop the old tables first.

CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(64) NOT NULL,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    role_name VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS permissions (
    id INT AUTO_INCREMENT PRIMARY KEY,
    permission_code VARCHAR(60) NOT NULL UNIQUE,
    description VARCHAR(200) NULL
);

CREATE TABLE IF NOT EXISTS user_roles (
    user_id INT NOT NULL,
    role_id INT NOT NULL,
    PRIMARY KEY (user_id, role_id),
    CONSTRAINT fk_user_roles_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
    CONSTRAINT fk_user_roles_role FOREIGN KEY (role_id) REFERENCES roles(id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS role_permissions (
    role_id INT NOT NULL,
    permission_id INT NOT NULL,
    PRIMARY KEY (role_id, permission_id),
    CONSTRAINT fk_role_permissions_role FOREIGN KEY (role_id) REFERENCES roles(id) ON DELETE CASCADE,
    CONSTRAINT fk_role_permissions_permission FOREIGN KEY (permission_id) REFERENCES permissions(id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS training_plans (
    id INT AUTO_INCREMENT PRIMARY KEY,
    plan_name VARCHAR(100) NOT NULL UNIQUE,
    sessions_per_week INT NOT NULL DEFAULT 1,
    weekly_fee DECIMAL(10,2) NOT NULL,
    monthly_fee DECIMAL(10,2) NOT NULL,
    competition_allowed TINYINT(1) NOT NULL DEFAULT 0,
    is_active TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS competition_categories (
    id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL UNIQUE,
    min_age INT NOT NULL,
    max_age INT NOT NULL,
    is_active TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS swimmers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NULL,
    name VARCHAR(100) NOT NULL,
    age INT NOT NULL,
    training_plan_id INT NOT NULL,
    competition_category_id INT NULL,
    competitions INT NOT NULL DEFAULT 0,
    coaching_hours DECIMAL(5,2) NOT NULL DEFAULT 0,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    CONSTRAINT fk_swimmers_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE SET NULL,
    CONSTRAINT fk_swimmers_training_plan FOREIGN KEY (training_plan_id) REFERENCES training_plans(id),
    CONSTRAINT fk_swimmers_competition_category FOREIGN KEY (competition_category_id) REFERENCES competition_categories(id)
);

CREATE TABLE IF NOT EXISTS fees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    swimmer_id INT NOT NULL,
    training_fee DECIMAL(10,2) NOT NULL,
    competition_fee DECIMAL(10,2) NOT NULL,
    coaching_fee DECIMAL(10,2) NOT NULL,
    total_fee DECIMAL(10,2) NOT NULL,
    fee_month DATE NOT NULL,
    created_by INT NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT uq_fee_month UNIQUE (swimmer_id, fee_month),
    CONSTRAINT fk_fees_swimmer FOREIGN KEY (swimmer_id) REFERENCES swimmers(id),
    CONSTRAINT fk_fees_created_by FOREIGN KEY (created_by) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS audit_logs (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NULL,
    action VARCHAR(30) NOT NULL,
    module VARCHAR(60) NOT NULL,
    description VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_audit_logs_user FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE SET NULL
);

INSERT IGNORE INTO roles (role_name) VALUES ('Admin'), ('Manager'), ('Staff'), ('Student');

INSERT IGNORE INTO permissions (permission_code, description) VALUES
('VIEW_SWIMMERS', 'View swimmer records'),
('ADD_SWIMMER', 'Add swimmers'),
('EDIT_SWIMMER', 'Update swimmers'),
('DELETE_SWIMMER', 'Delete swimmers'),
('MANAGE_PLANS', 'Manage training plans'),
('MANAGE_CATEGORIES', 'Manage competition categories'),
('CALCULATE_FEES', 'Calculate monthly fees'),
('SAVE_FEES', 'Save monthly fees'),
('VIEW_FEE_HISTORY', 'View fee history'),
('VIEW_ALL_FEES', 'View all swimmers fee history'),
('VIEW_REPORTS', 'View reports'),
('MANAGE_USERS', 'Manage users'),
('MANAGE_ROLES', 'Manage roles'),
('MANAGE_PERMISSIONS', 'Manage permissions'),
('VIEW_AUDIT_LOG', 'View audit log'),
('CHANGE_PASSWORD', 'Change own password');

-- Assign permissions to each role. INSERT IGNORE keeps this safe to re-run.
INSERT IGNORE INTO role_permissions (role_id, permission_id)
SELECT r.id, p.id
FROM roles r CROSS JOIN permissions p
WHERE r.role_name = 'Admin';

INSERT IGNORE INTO role_permissions (role_id, permission_id)
SELECT r.id, p.id
FROM roles r INNER JOIN permissions p ON p.permission_code IN
('VIEW_SWIMMERS', 'ADD_SWIMMER', 'EDIT_SWIMMER', 'DELETE_SWIMMER',
 'CALCULATE_FEES', 'VIEW_FEE_HISTORY', 'VIEW_ALL_FEES', 'VIEW_REPORTS', 'CHANGE_PASSWORD')
WHERE r.role_name = 'Manager';

INSERT IGNORE INTO role_permissions (role_id, permission_id)
SELECT r.id, p.id
FROM roles r INNER JOIN permissions p ON p.permission_code IN
('VIEW_SWIMMERS', 'ADD_SWIMMER', 'EDIT_SWIMMER', 'CALCULATE_FEES', 'VIEW_FEE_HISTORY', 'CHANGE_PASSWORD')
WHERE r.role_name = 'Staff';

INSERT IGNORE INTO role_permissions (role_id, permission_id)
SELECT r.id, p.id
FROM roles r INNER JOIN permissions p ON p.permission_code IN
('VIEW_FEE_HISTORY', 'CHANGE_PASSWORD')
WHERE r.role_name = 'Student';

INSERT IGNORE INTO training_plans (plan_name, sessions_per_week, weekly_fee, monthly_fee, competition_allowed, is_active) VALUES
('Beginner', 2, 200.00, 800.00, 0, 1),
('Intermediate', 3, 275.00, 1100.00, 1, 1),
('Advanced', 5, 325.00, 1300.00, 1, 1);

INSERT IGNORE INTO competition_categories (category_name, min_age, max_age, is_active) VALUES
('Junior', 8, 12, 1),
('Youth', 13, 17, 1),
('Adult', 18, 39, 1),
('Senior', 40, 120, 1);

-- SAMPLE DATA FOR TESTING. All sample passwords are Password123.
-- Do not use these accounts or password in a production system.
INSERT IGNORE INTO users (full_name, username, email, password, is_active) VALUES
('System Administrator', 'admin', 'admin@swimpro.test', SHA2('Password123', 256), 1),
('Maya Manager', 'manager', 'manager@swimpro.test', SHA2('Password123', 256), 1),
('Sam Staff', 'staff', 'staff@swimpro.test', SHA2('Password123', 256), 1),
('Nimal Student', 'student', 'student@swimpro.test', SHA2('Password123', 256), 1),
('Pending Applicant', 'pending', 'pending@swimpro.test', SHA2('Password123', 256), 0);

-- The pending account intentionally has no role and cannot log in.
INSERT IGNORE INTO user_roles (user_id, role_id)
SELECT u.id, r.id FROM users u CROSS JOIN roles r
WHERE (u.username = 'admin' AND r.role_name = 'Admin')
   OR (u.username = 'manager' AND r.role_name = 'Manager')
   OR (u.username = 'staff' AND r.role_name = 'Staff')
   OR (u.username = 'student' AND r.role_name = 'Student');

INSERT IGNORE INTO swimmers
    (user_id, name, age, training_plan_id, competition_category_id, competitions, coaching_hours, is_active)
SELECT u.id, 'Nimal Student', 14, tp.id, cc.id, 1, 2.00, 1
FROM users u
JOIN training_plans tp ON tp.plan_name = 'Intermediate'
JOIN competition_categories cc ON cc.category_name = 'Youth'
WHERE u.username = 'student'
  AND NOT EXISTS (SELECT 1 FROM swimmers s WHERE s.user_id = u.id);

INSERT IGNORE INTO swimmers
    (user_id, name, age, training_plan_id, competition_category_id, competitions, coaching_hours, is_active)
SELECT NULL, 'Kavindi Perera', 10, tp.id, cc.id, 0, 0.00, 1
FROM training_plans tp
JOIN competition_categories cc ON cc.category_name = 'Junior'
WHERE tp.plan_name = 'Beginner'
  AND NOT EXISTS (SELECT 1 FROM swimmers s WHERE s.name = 'Kavindi Perera');

INSERT IGNORE INTO fees
    (swimmer_id, training_fee, competition_fee, coaching_fee, total_fee, fee_month, created_by)
SELECT s.id, 1100.00, 300.00, 1000.00, 2400.00, '2026-10-01', u.id
FROM swimmers s
JOIN users u ON u.username = 'admin'
WHERE s.name = 'Nimal Student';
