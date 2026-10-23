-- Run this once in MySQL Workbench after Database/swimpro_db.sql.
-- It creates the assignment test account only when username Admin does not exist.
-- Login: Admin
-- Password: Password123

USE swimpro_db;

INSERT INTO users (full_name, username, email, password, is_active)
SELECT 'System Administrator', 'Admin', 'admin@swimpro.local', SHA2('Password123', 256), 1
WHERE NOT EXISTS (
    SELECT 1 FROM users WHERE username = 'Admin'
);

INSERT IGNORE INTO user_roles (user_id, role_id)
SELECT u.id, r.id
FROM users u
INNER JOIN roles r ON r.role_name = 'Admin'
WHERE u.username = 'Admin';

-- Verify the account before opening the application.
SELECT u.id, u.username, u.email, u.is_active, r.role_name
FROM users u
LEFT JOIN user_roles ur ON ur.user_id = u.id
LEFT JOIN roles r ON r.id = ur.role_id
WHERE u.username = 'Admin';
