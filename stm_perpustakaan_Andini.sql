CREATE DATABASE stm_perpustakaan;
USE stm_perpustakaan;

CREATE TABLE users (
id_user INT AUTO_INCREMENT PRIMARY KEY,
username VARCHAR(50) NOT NULL UNIQUE,
PASSWORD VARCHAR(255) NOT NULL,
email VARCHAR (100),
ROLE ENUM('admin','user')NOT NULL DEFAULT'user',
created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO users (username, PASSWORD, email, ROLE)
VALUES ('admin','admin123','admin@mail.com','admin');

ALTER TABLE users
ADD full_name VARCHAR(100) AFTER username;

CREATE TABLE books (
    id_book INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(150) NOT NULL,
    author VARCHAR(100) NOT NULL,
    category VARCHAR(100),
    stock INT NOT NULL,
    photo VARCHAR(255) NULL
);


CREATE TABLE borrowings (
    id_borrow INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    id_book INT NOT NULL,
    borrow_date DATE NOT NULL,
    due_date DATE NOT NULL,
    return_date DATE,
    STATUS ENUM('dipinjam','dikembalikan') DEFAULT 'dipinjam',
    fine INT DEFAULT 0,

    FOREIGN KEY (id_user) REFERENCES users(id_user)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    FOREIGN KEY (id_book) REFERENCES books(id_book)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


-- register user

INSERT INTO users (username, PASSWORD, email)
VALUES ('user2', '123456', 'user2@mail.com');

-- login 

SELECT id_user, username, ROLE
FROM users
WHERE username = 'admin' AND PASSWORD = 'admin123';

-- peminjaman
DELIMITER $$

CREATE TRIGGER trg_kurangi_stok
AFTER INSERT ON borrowings
FOR EACH ROW
BEGIN
    UPDATE books
    SET stock = stock - NEW.qty
    WHERE id_book = NEW.id_book;
END$$
DELIMITER ;

-- cek stok
DELIMITER $$

CREATE TRIGGER trg_cek_stok
BEFORE INSERT ON borrowings
FOR EACH ROW
BEGIN
    DECLARE stok INT;

    SELECT stock INTO stok
    FROM books
    WHERE id_book = NEW.id_book;

    IF stok < new.qty THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Stok buku habis';
    END IF;
END$$

DELIMITER ;

-- tambah stok
DELIMITER $$

CREATE TRIGGER trg_tambah_stok
AFTER UPDATE ON borrowings
FOR EACH ROW
BEGIN
    IF OLD.status = 'dipinjam' AND NEW.status = 'dikembalikan' THEN
        UPDATE books
        SET stock = stock + OLD.qty
        WHERE id_book = NEW.id_book;
    END IF;
END$$

DELIMITER ;

-- hitung denda

DELIMITER $$

CREATE TRIGGER trg_hitung_denda
BEFORE UPDATE ON borrowings
FOR EACH ROW
BEGIN
    IF NEW.return_date IS NOT NULL AND NEW.return_date > OLD.due_date THEN
        SET NEW.fine = DATEDIFF(NEW.return_date, OLD.due_date) * 1000;
    ELSE
        SET NEW.fine = 0;
    END IF;
END$$

DELIMITER ;

-- category

CREATE TABLE categories (
    id_category INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL UNIQUE
);

-- 
ALTER TABLE books
ADD id_category INT,
ADD CONSTRAINT fk_books_category
FOREIGN KEY (id_category)
REFERENCES categories(id_category)
ON DELETE SET NULL
ON UPDATE CASCADE;

-- 
CREATE TABLE activity_logs (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT,
    activity VARCHAR(255),
    log_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (id_user) REFERENCES users(id_user)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE INDEX idx_borrowings_user ON borrowings(id_user);
CREATE INDEX idx_borrowings_book ON borrowings(id_book);
CREATE INDEX idx_borrowings_status ON borrowings(STATUS);

CREATE VIEW v_peminjaman_admin AS
SELECT 
    b.id_borrow,
    u.username,
    u.full_name,
    bk.title,
    b.borrow_date,
    b.due_date,
    b.return_date,
    b.status,
    b.fine
FROM borrowings b
JOIN users u ON b.id_user = u.id_user
JOIN books bk ON b.id_book = bk.id_book;


CREATE VIEW v_laporan_peminjaman AS
SELECT 
    title,
    COUNT(*) AS total_dipinjam
FROM borrowings b
JOIN books bk ON b.id_book = bk.id_book
GROUP BY title;

CREATE VIEW v_laporan_denda AS
SELECT 
    u.username,
    SUM(b.fine) AS total_denda
FROM borrowings b
JOIN users u ON b.id_user = u.id_user
GROUP BY u.username;

SELECT * FROM v_peminjaman_admin;

SELECT * 
FROM v_peminjaman_admin
WHERE STATUS = 'dipinjam';


SELECT *
FROM v_peminjaman_admin
WHERE username LIKE '%andi%'
   OR title LIKE '%database%';


-- Tambah buku dulu
INSERT INTO books (title, author, stock)
VALUES ('Database Basics', 'Andini', 10),
       ('C# Programming', 'Andini', 5);

-- Pastikan user2 ada
SELECT * FROM users;

-- Tambah peminjaman untuk user2
INSERT INTO borrowings (id_user, id_book, borrow_date, due_date)
VALUES (2, 1, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 7 DAY)),
       (2, 5, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 7 DAY));

-- Tambah peminjaman untuk user lain (contoh)
INSERT INTO borrowings (id_user, id_book, borrow_date, due_date)
VALUES (4, 1, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 7 DAY));

SELECT * FROM books;
SELECT * FROM users;

SELECT 
    u.username,
    a.activity,
    a.log_time
FROM activity_logs a
JOIN users u ON a.id_user = u.id_user
ORDER BY a.log_time DESC;


DELIMITER $$

CREATE TRIGGER trg_log_peminjaman
AFTER INSERT ON borrowings
FOR EACH ROW
BEGIN
    INSERT INTO activity_logs (id_user, activity)
    VALUES (
        NEW.id_user,
        CONCAT('Meminjam buku dengan ID ', NEW.id_book)
    );
END$$

DELIMITER ;

ALTER TABLE borrowings
ADD qty INT NOT NULL DEFAULT 1 AFTER id_book;


SHOW TRIGGERS FROM stm_perpustakaan;
SELECT id_book, title, author, stock
FROM books;

ALTER TABLE users
ADD photo VARCHAR(255) NULL AFTER full_name;


