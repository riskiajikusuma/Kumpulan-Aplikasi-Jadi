USE db_penjualan_kue;

-- Membual tabel login --
CREATE TABLE tbl_login (ussername VARCHAR(25) PRIMARY KEY,
password VARCHAR(25) NOT NULL);

-- Membuat tabel log login --
CREATE TABLE log_tbl_login (ussername VARCHAR(25) NOT NULL,
usser_status VARCHAR(10) NOT NULL,
date_status DATETIME DEFAULT GETDATE());

-- Membuat trigger insert login --
CREATE TRIGGER insert_login
ON tbl_login
AFTER INSERT
AS
BEGIN
	DECLARE @usser VARCHAR(25)
	SELECT @usser = ussername FROM inserted
	INSERT INTO log_tbl_login (ussername, usser_status)
	VALUES (@usser, 'REGISTERED');
END;

-- Simpan usser ke tbl_login --
INSERT INTO tbl_login VALUES ('panjik','123');

-- Cek data di tabel log_tbl_login --
SELECT * FROM log_tbl_login;
