CREATE DATABASE db_penjualan_kue

USE db_penjualan_kue;

-- Membuat tabel kasir --
CREATE TABLE kasir
(
Id_kasir CHAR(5) PRIMARY KEY,
Nama_kasir VARCHAR(25) NOT NULL,
Alamat_kasir VARCHAR(50) NOT NULL,
No_telp VARCHAR(15)
)

-- Membuat tabel supplier --
CREATE TABLE supplier
(
Id_supplier CHAR(5) PRIMARY KEY,
Nama_supplier VARCHAR(25) NOT NULL,
Alamat_supplier VARCHAR(50) NOT NULL,
No_telp VARCHAR(15)
)

-- Membuat tabel pelanggan --
CREATE TABLE pelanggan
(
Id_pelanggan CHAR(5) PRIMARY KEY,
Nama_pelanggan VARCHAR(25) NOT NULL,
Alamat_pelanggan VARCHAR(50) NOT NULL,
No_telp VARCHAR(15)
)

-- Membuat tabel kue --
CREATE TABLE kue
(
Kd_kue CHAR(5) PRIMARY KEY,
Nama_kue VARCHAR(25) NOT NULL,
Harga_kue INT NOT NULL,
Jenis_kue VARCHAR(30) NOT NULL,
Stok_kue INT NOT NULL
)

-- Membuat tabel transaksi penyuplaian --
CREATE TABLE penyuplaian
(
Kd_suplai CHAR(5) PRIMARY KEY,
Tgl_suplai DATE NOT NULL,
Id_supplier CHAR(5) FOREIGN KEY REFERENCES
supplier(Id_supplier),
Id_kasir CHAR(5) FOREIGN KEY REFERENCES
kasir(Id_kasir)
)

-- Membuat tabel transaksi pembelian --
CREATE TABLE pembelian
(
Kd_beli CHAR(5) PRIMARY KEY,
Tgl_beli DATE NOT NULL,
Id_pelanggan CHAR(5) FOREIGN KEY REFERENCES
pelanggan(Id_pelanggan),
Id_kasir CHAR(5) FOREIGN KEY REFERENCES
kasir(Id_kasir)
)

-- Membuat tabel detail_penyuplaian --
CREATE TABLE detail_penyuplaian
(
Kd_suplai CHAR(5) FOREIGN KEY REFERENCES
penyuplaian(Kd_suplai),
Kd_kue CHAR(5) FOREIGN KEY REFERENCES
kue(Kd_kue),
Jml_suplai INT NOT NULL
)

-- Membuat tabel detail_pembelian --
CREATE TABLE detail_pembelian
(
Kd_beli CHAR(5) FOREIGN KEY REFERENCES
pembelian(Kd_beli),
Kd_kue CHAR(5) FOREIGN KEY REFERENCES
kue(Kd_kue),
Jml_beli INT NOT NULL
)

-- Memasukkan data supplier --
INSERT INTO supplier VALUES
('S0001','Andik','Way Halim','089672762170'),
('S0002','Putra','Pramuka','081232412567'),
('S0003','Law','Kemiling','082281525383'),
('S0004','Sandi','Pahoman','085711989435'),
('S0005','Tama','Rajabasa','0896452098989')

-- Memasukkan data kasir --
INSERT INTO kasir VALUES
('K0001','Riski','Gunung Terang','081272762172'),
('K0002','Ajik','Palapa','0857324125334'),
('K0003','Kusuma','Teluk','081281525383'),
('K0004','Panjik','PU','085711989477'),
('K0005','Setiawan','Kedaton','0896452098912')

-- Memasukkan data pelanggan --
INSERT INTO pelanggan VALUES
('P0001','Putri','Kedaton','089672762171'),
('P0002','Siti','Palapa','081232412563'),
('P0003','Rara','Teluk','082281525343'),
('P0004','Inka','PU','085711989499'),
('P0005','Ririn','Antasari','0896452098901'),
('P0006','Joko','Kedaton','0812452098982'),
('P0007','Otong','PU','0822452098923'),
('P0008','Dicky','Antasari','085745209891'),
('P0009','Rio','Gedong Aer','0812452098985'),
('P0010','Sherly','Teluk','0812452098555')

-- Memasukkan data kue dari MS.Excel --
BULK INSERT kue
FROM 'E:\Program_PBD_2018\datakue.csv'
WITH
(
FIRSTROW = 2,
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO

-- Membuat view penyuplaian --
CREATE VIEW view_penyuplaian AS
SELECT detail_penyuplaian.Kd_suplai, penyuplaian.Tgl_suplai, 
supplier.Id_supplier, supplier.Nama_supplier,
kasir.Id_kasir, kasir.Nama_kasir,
detail_penyuplaian.Kd_kue, kue.Nama_kue, kue.Jenis_kue,
kue.Harga_kue, detail_penyuplaian.jml_suplai
FROM detail_penyuplaian
JOIN penyuplaian
ON penyuplaian.Kd_suplai = detail_penyuplaian.Kd_suplai
JOIN kue
ON kue.Kd_kue = detail_penyuplaian.Kd_kue
JOIN supplier 
ON supplier.Id_supplier = penyuplaian.Id_supplier
JOIN kasir
ON kasir.Id_kasir = penyuplaian.Id_kasir

-- Memasukkan data penyuplaian --
INSERT INTO penyuplaian VALUES
('PE001','2018/08/08','S0001','K0001'),
('PE002','2018/08/15','S0002','K0002'),
('PE003','2018/08/22','S0003','K0003'),
('PE004','2018/08/29','S0004','K0004'),
('PE005','2018/08/05','S0005','K0005')

-- Memasukkan data detail penyuplaian --
INSERT INTO detail_penyuplaian VALUES
('PE001','KU001',5),
('PE002','KU002',10),
('PE003','KU003',15),
('PE003','KU004',8),
('PE003','KU005',2),
('PE004','KU006',6),
('PE004','KU007',5),
('PE004','KU008',7),
('PE005','KU009',8),
('PE005','KU010',10)

SELECT * FROM view_penyuplaian;

-- Membuat view detail penyuplaian --
CREATE VIEW view_detailpenyuplaian AS
SELECT detail_penyuplaian.Kd_suplai, detail_penyuplaian.Kd_kue,
kue.Nama_kue, kue.Harga_kue, detail_penyuplaian.jml_suplai
FROM kue INNER JOIN
detail_penyuplaian ON kue.Kd_kue = detail_penyuplaian.Kd_kue;

SELECT * FROM view_detailpenyuplaian;

-- Membuat view pembelian --
CREATE VIEW view_pembelian AS
SELECT detail_pembelian.Kd_beli, pembelian.Tgl_beli, 
pelanggan.Id_pelanggan, pelanggan.Nama_pelanggan,
kasir.Id_kasir, kasir.Nama_kasir,
detail_pembelian.Kd_kue, kue.Nama_kue, kue.Jenis_kue,
kue.Harga_kue, detail_pembelian.jml_beli, 
kue.Harga_kue * detail_pembelian.Jml_beli AS Total_bayar
FROM detail_pembelian
JOIN pembelian
ON pembelian.Kd_beli = detail_pembelian.Kd_beli
JOIN kue
ON kue.Kd_kue = detail_pembelian.Kd_kue
JOIN pelanggan 
ON pelanggan.Id_pelanggan = pembelian.Id_pelanggan
JOIN kasir
ON kasir.Id_kasir = pembelian.Id_kasir

-- Memasukkan data pembelian --
INSERT INTO pembelian VALUES
('PM001','2018/08/15','P0001','K0001'),
('PM002','2018/08/22','P0002','K0002'),
('PM003','2018/08/25','P0003','K0003'),
('PM004','2018/08/26','P0004','K0004'),
('PM005','2018/08/29','P0005','K0005')

-- Memasukkan data detail pembelian --
INSERT INTO detail_pembelian VALUES
('PM001','KU001',10),
('PM002','KU002',1),
('PM003','KU003',5),
('PM003','KU004',2),
('PM003','KU005',3),
('PM004','KU006',4),
('PM004','KU007',6),
('PM004','KU008',9),
('PM005','KU009',10),
('PM005','KU010',7)

SELECT * FROM view_pembelian;

-- Membuat view detail pembelian --_
CREATE VIEW view_detailpembelian AS
SELECT detail_pembelian.Kd_beli, detail_pembelian.Kd_kue,
kue.Nama_kue, kue.Harga_kue, detail_pembelian.Jml_beli
FROM kue INNER JOIN
detail_pembelian ON kue.Kd_kue = detail_pembelian.Kd_kue;

SELECT * FROM view_detailpembelian;

-- Membuat prosedur SP_View_Penyuplaian --
CREATE PROCEDURE SP_View_Penyuplaian AS
BEGIN
	SELECT * FROM view_penyuplaian;
END;

EXECUTE SP_View_Penyuplaian;

-- Membuat prosedur SP_View_Pembelian --
CREATE PROCEDURE SP_View_Pembelian AS
BEGIN
	SELECT * FROM view_pembelian;
END;

EXECUTE SP_View_Pembelian;

-- Membuat prosedur simpan_supplier --
CREATE PROCEDURE simpan_supplier
@Id_supplier CHAR(5),
@Nama_supplier VARCHAR(25),
@Alamat_supplier VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	INSERT INTO supplier VALUES
	(@Id_supplier, @Nama_supplier, @Alamat_supplier, 
	@No_telp);
END;

-- Membuat prosedur hapus_supplier --
CREATE PROCEDURE hapus_supplier
@Id_supplier CHAR(5)
AS
BEGIN
	DELETE FROM supplier WHERE Id_supplier = @Id_supplier;
END;

-- Membuat prosedur ubah_supplier --
CREATE PROCEDURE ubah_supplier
@Id_supplier CHAR(5),
@Nama_supplier VARCHAR(25),
@Alamat_supplier VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	UPDATE supplier SET Nama_supplier = @Nama_supplier,
	Alamat_supplier = @Alamat_supplier, No_telp = @No_telp
	WHERE Id_supplier = @Id_supplier;
END;

-- Membuat prosedur cari_supplier --
CREATE PROCEDURE cari_supplier
@Nama_supplier VARCHAR(25)
AS
BEGIN
	SELECT * FROM supplier
	WHERE Nama_supplier LIKE '%'+@Nama_supplier+'%';
END;

-- Membuat prosedur simpan_pelanggan --
CREATE PROCEDURE simpan_pelanggan
@Id_pelanggan CHAR(5),
@Nama_pelanggan VARCHAR(25),
@Alamat_pelanggan VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	INSERT INTO pelanggan VALUES
	(@Id_pelanggan, @Nama_pelanggan, @Alamat_pelanggan, 
	@No_telp);
END;

-- Membuat prosedur hapus_pelanggan --
CREATE PROCEDURE hapus_pelanggan
@Id_pelanggan CHAR(5)
AS
BEGIN
	DELETE FROM pelanggan WHERE Id_pelanggan = @Id_pelanggan;
END;

-- Membuat prosedur ubah_pelanggan --
CREATE PROCEDURE ubah_pelanggan
@Id_pelanggan CHAR(5),
@Nama_pelanggan VARCHAR(25),
@Alamat_pelanggan VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	UPDATE pelanggan SET Nama_pelanggan = @Nama_pelanggan,
	Alamat_pelanggan = @Alamat_pelanggan, No_telp = @No_telp
	WHERE Id_pelanggan = @Id_pelanggan;
END;

-- Membuat prosedur cari_pelanggan --
CREATE PROCEDURE cari_pelanggan
@Nama_pelanggan VARCHAR(25)
AS
BEGIN
	SELECT * FROM pelanggan
	WHERE Nama_pelanggan LIKE '%'+@Nama_pelanggan+'%';
END;

-- Membuat prosedur simpan_kasir --
CREATE PROCEDURE simpan_kasir
@Id_kasir CHAR(5),
@Nama_kasir VARCHAR(25),
@Alamat_kasir VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	INSERT INTO kasir VALUES
	(@Id_kasir, @Nama_kasir, @Alamat_kasir, @No_telp);
END;

-- Membuat prosedur hapus_kasir --
CREATE PROCEDURE hapus_kasir
@Id_kasir CHAR(5)
AS
BEGIN
	DELETE FROM kasir WHERE Id_kasir = @Id_kasir;
END;

-- Membuat prosedur ubah_kasir --
CREATE PROCEDURE ubah_kasir
@Id_kasir CHAR(5),
@Nama_kasir VARCHAR(25),
@Alamat_kasir VARCHAR(50),
@No_telp VARCHAR(15)
AS
BEGIN
	UPDATE kasir SET Nama_kasir = @Nama_kasir,
	Alamat_kasir = @Alamat_kasir, No_telp = @No_telp
	WHERE Id_kasir = @Id_kasir;
END;

-- Membuat prosedur cari_kasir --
CREATE PROCEDURE cari_kasir
@Nama_kasir VARCHAR(25)
AS
BEGIN
	SELECT * FROM kasir
	WHERE Nama_kasir LIKE '%'+@Nama_kasir+'%';
END;

-- Membuat prosedur simpan_kue --
CREATE PROCEDURE simpan_kue
@Kd_kue CHAR(5),
@Nama_kue VARCHAR(25),
@Harga_kue INT,
@Jenis_kue VARCHAR(15),
@Stok INT
AS
BEGIN
	INSERT INTO kue VALUES
	(@Kd_kue, @Nama_kue, @Harga_kue, @Jenis_kue, @Stok);
END;

-- Membuat prosedur hapus_kue --
CREATE PROCEDURE hapus_kue
@Kd_kue CHAR(5)
AS
BEGIN
	DELETE FROM kue WHERE Kd_kue = @Kd_kue;
END;

-- Membuat prosedur ubah_kue --
ALTER PROCEDURE ubah_kue
@Nama_kue VARCHAR(25),
@Harga_kue INT,
@Jenis_kue VARCHAR(15),
@Stok_kue INT,
@Kd_kue CHAR(5)
AS
BEGIN
	UPDATE kue SET Nama_kue = @Nama_kue,
	Harga_kue = @Harga_kue, Jenis_kue= @Jenis_kue,
	Stok_kue = @Stok_kue WHERE Kd_kue = @Kd_kue;
END;

-- Membuat prosedur cari_kue --
CREATE PROCEDURE cari_kue
@Nama_kue VARCHAR(25)
AS
BEGIN
	SELECT * FROM kue
	WHERE Nama_kue LIKE '%'+@Nama_kue+'%';
END;

-- Membuat prosedur simpan penyuplaian --
CREATE PROCEDURE simpan_penyuplaian
@Kd_suplai CHAR(5),
@Tgl_suplai DATE,
@Id_supplier CHAR(5),
@Id_kasir CHAR(5)
AS
BEGIN
	INSERT INTO penyuplaian VALUES
	(@Kd_suplai, @Tgl_suplai, @Id_supplier, @Id_kasir);
END;

-- Membuat prosedur simpan pembelian --
CREATE PROCEDURE simpan_pembelian
@Kd_beli CHAR(5),
@Tgl_beli DATE,
@Id_pelanggan CHAR(5),
@Id_kasir CHAR(5)
AS
BEGIN
	INSERT INTO pembelian VALUES
	(@Kd_beli, @Tgl_beli, @Id_pelanggan, @Id_kasir);
END;

-- Membuat prosedur simpan_detail_penyuplaian --
CREATE PROCEDURE simpan_detail_penyuplaian
@Kd_suplai CHAR(5),
@Kd_kue CHAR(5),
@Jml_suplai INT
AS
BEGIN
	INSERT INTO detail_penyuplaian VALUES
	(@Kd_suplai, @Kd_kue, @Jml_suplai);
END;

-- Membuat prosedur hapus_detail_penyuplaian --
CREATE PROCEDURE hapus_detail_penyuplaian
@Kd_suplai CHAR(5),
@Kd_kue CHAR(5)
AS
BEGIN
	DELETE FROM detail_penyuplaian WHERE
	Kd_suplai = @Kd_suplai AND Kd_kue = @Kd_kue;
END;

-- Membuat prosedur simpan_detail_pembelian --
CREATE PROCEDURE simpan_detail_pembelian
@Kd_beli CHAR(5),
@Kd_kue CHAR(5),
@Jml_beli INT
AS
BEGIN
	INSERT INTO detail_pembelian VALUES
	(@Kd_beli, @Kd_kue, @Jml_beli);
END;

-- Membuat prosedur hapus_detail_pembelian --
CREATE PROCEDURE hapus_detail_pembelian
@Kd_beli CHAR(5),
@Kd_kue CHAR(5)
AS
BEGIN
	DELETE FROM detail_pembelian WHERE
	Kd_beli = @Kd_beli AND Kd_kue = @Kd_kue;
END;

-- Membuat trigger untuk penambahan stok otomatis --
CREATE TRIGGER AfterInsert_DetailPenyuplaian
ON detail_penyuplaian
AFTER INSERT
AS 
BEGIN
	DECLARE 
			@Jumlah INT, @Kode CHAR(5)
	SELECT	@Jumlah = Jml_suplai,
			@Kode = Kd_kue FROM inserted

	UPDATE kue SET kue.Stok_kue =
	kue.Stok_kue + @Jumlah
	WHERE kue.Kd_kue = @Kode;
END;

-- Membuat trigger untuk pengurangan stok otomatis --
CREATE TRIGGER AfterInsert_DetailPembelian
ON detail_pembelian
AFTER INSERT
AS
BEGIN
	DECLARE
			@Jumlah INT, @Kode CHAR(5)
	SELECT	@Jumlah = Jml_beli,
			@Kode = Kd_kue FROM inserted

	UPDATE kue SET kue.Stok_kue =
	kue.Stok_kue - @Jumlah
	WHERE kue.Kd_kue = @Kode;
END;

-- Membuat trigger AfterDelete_DetailPembelian --
CREATE TRIGGER AfterDelete_DetailPembelian
ON detail_pembelian
AFTER DELETE
AS
BEGIN
	DECLARE
			@Jumlah INT, @Kode CHAR(5)
	SELECT	@Jumlah = Jml_beli,
			@Kode = Kd_kue FROM deleted

	UPDATE kue SET kue.Stok_kue =
	kue.Stok_kue + @Jumlah
	WHERE kue.Kd_kue = @Kode;
END;