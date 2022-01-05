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
Total_bayar INT NOT NULL,
Id_kasir CHAR(5) FOREIGN KEY REFERENCES
kasir(Id_kasir),
Id_pelanggan CHAR(5) FOREIGN KEY REFERENCES
pelanggan(Id_pelanggan)
)

-- Membuat tabel detail_penyuplaian --
CREATE TABLE detail_penyuplaian
(
Jml_suplai INT NOT NULL,
Kd_kue CHAR(5) FOREIGN KEY REFERENCES
kue(Kd_kue),
Kd_suplai CHAR(5) FOREIGN KEY REFERENCES
penyuplaian(Kd_suplai)
)

-- Membuat tabel detail_pembelian --
CREATE TABLE detail_pembelian
(
Jml_beli INT NOT NULL,
Kd_kue CHAR(5) FOREIGN KEY REFERENCES
kue(Kd_kue),
Kd_beli CHAR(5) FOREIGN KEY REFERENCES
pembelian(Kd_beli)
)

-- Membuat view penyuplaian --
CREATE View_Penyuplaian AS
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

-- Membuat view pembelian --
CREATE View_Pembelian AS
SELECT detail_pembelian.Kd_beli, pembelian.Tgl_beli,
pelanggan.Id_pelanggan, pelanggan.Nama_pelanggan,
kasir.Id_kasir, kasir.Nama_kasir,
detail_pembelian.Kd_kue, kue.Nama_kue, kue.Jenis_kue,
kue.Harga_kue, detail_pembelian.Jml_beli
FROM detail_pembelian
JOIN pembelian
ON pembelian.Kd_beli = detail_pembelian.Kd_beli
JOIN kue
ON kue.Kd_kue = detail_pembelian.Kd_kue
JOIN pelanggan
ON pelanggan.Id_pelanggan = pembelian.Id_pelanggan
JOIN kasir
ON kasir.Id_kasir = pembelian.Id_kasir

-- Membuat view detail_penyuplaian --
CREATE View_Penyuplaian AS
SELECT detail_penyuplaian.Kd_suplai, detail_penyuplaian.Kd_kue,
kue.Nama_kue, kue.Harga_kue, detail_penyuplaian.Jml_suplai,
kue.Harga_kue * detail_penyuplaian.Jml_suplai AS JUMLAH_BAYAR



-- Membuat procedure SP_View_



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
@Id_supplier CHAR(5),
AS
BEGIN
	DELETE FROM supplier WHERE Id_supplier = @Id_supplier;
END;

-- Membuat prosedur ubah_supplier --
CREATE PROCEDURE simpan_supplier
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
CREATE PROCEDURE simpan_supplier
@Nama_supplier VARCHAR(25),
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
CREATE PROCEDURE simpan_pelanggan
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
@Nama_pelanggan VARCHAR(25),
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
CREATE PROCEDURE ubah_kasir
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
CREATE PROCEDURE ubah_kue
@Kd_kue CHAR(5),
@Nama_kue VARCHAR(25),
@Harga_kue INT,
@Jenis_kue VARCHAR(15),
@Stok_kue INT
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

-- Membuat prosedur simpan_detail_penyuplaian --
CREATE PROCEDURE simpan_detail_penyuplaian
@jml_suplai INT,
@Kd_kue CHAR(5),
@Kd_suplai CHAR(5)
AS
BEGIN
	INSERT INTO kasir VALUES
	(@jml_suplai, @Kd_kue, @Kd_suplai);
END;

-- Membuat prosedur hapus_detail_penyuplaian --
CREATE PROCEDURE hapus_detail_penyuplaian
@Kd_kue CHAR(5),
@Kd_suplai CHAR(5)
AS
BEGIN
	DELETE FROM detail_penyuplaian WHERE
	Kd_kue = @Kd_kue AND Kd_suplai = @Kd_suplai;
END;

-- Membuat prosedur simpan_detail_pembelian --
CREATE PROCEDURE simpan_detail_pembelian
@jml_beli INT,
@Kd_kue CHAR(5),
@Kd_beli CHAR(5)
AS
BEGIN
	INSERT INTO detail_pembelian VALUES
	(@jml_beli, @Kd_kue, @Kd_beli);
END;

-- Membuat prosedur hapus_detail_pembelian --
CREATE PROCEDURE hapus_detail_pembelian
@Kd_kue CHAR(5),
@Kd_beli CHAR(5)
AS
BEGIN
	DELETE FROM detail_pembelian WHERE
	Kd_kue = @Kd_kue AND Kd_beli = @Kd_beli;
END;

-- Membuat trigger AfterInsert_DetailPenyuplaian --
CREATE TRIGGER AfterInsert_DetailPenyuplaian
ON detail_penyuplaian
AFTER INSERT
AS
BEGIN
	DECLARE 
			@jumlah INT, @kode CHAR(5)
	SELECT	@jumlah = Jml_suplai,
			@kode = Kd_kue FROM INSERTED

	UPDATE kue SET kue.Stok_kue = 
	kue.Stok_kue + @jumlah
	WHERE kue.Kd_kue = @kode;
END;

-- Membuat trigger AfterDelete_DetailPenyuplaian --
CREATE TRIGGER AfterDelete_DetailPenyuplaian
ON detail_penyuplaian
AFTER DELETE
AS
BEGIN
	DECLARE 
			@jumlah INT, @kode CHAR(5)
	SELECT	@jumlah = Jml_suplai,
			@kode = Kd_kue FROM INSERTED

	UPDATE kue SET kue.Stok_kue = 
	kue.Stok_kue - @jumlah
	WHERE kue.Kd_kue = @kode;
END;

-- Membuat trigger AfterInsert_DetailPembelian --
CREATE TRIGGER AfterInsert_DetailPembelian
ON detail_pembelian
AFTER INSERT
AS
BEGIN
	DECLARE 
			@jml_beli INT, @kd_beli CHAR(5)
	SELECT	@jml_beli = Jml_beli,
			@kd_beli = Kd_kue FROM INSERTED

	UPDATE kue SET kue.Stok_kue = 
	kue.Stok_kue - @jml_beli
	WHERE kue.Kd_kue = @kd_beli;
END;

-- Membuat trigger AfterDelete_DetailPembelian --
CREATE TRIGGER AfterDelete_DetailPembelian
ON detail_pembelian
AFTER DELETE
AS
BEGIN
	DECLARE 
			@jml_beli INT, @kd_beli CHAR(5)
	SELECT	@jml_beli = Jml_beli,
			@kd_beli = Kd_kue FROM INSERTED

	UPDATE kue SET kue.Stok_kue = 
	kue.Stok_kue + @jml_beli
	WHERE kue.Kd_kue = @kd_beli;
END;