-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Inang: 127.0.0.1
-- Waktu pembuatan: 16 Sep 2013 pada 08.33
-- Versi Server: 5.5.27
-- Versi PHP: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Basis data: `toko`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblbarang`
--

CREATE TABLE IF NOT EXISTS `tblbarang` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(35) NOT NULL,
  `Merk` varchar(15) NOT NULL,
  `Satuan` varchar(15) NOT NULL,
  `Hrg_Beli` int(11) NOT NULL,
  `Hrg_Jual` int(11) NOT NULL,
  `Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblbarang`
--

INSERT INTO `tblbarang` (`ID`, `Nama`, `Merk`, `Satuan`, `Hrg_Beli`, `Hrg_Jual`, `Stock`) VALUES
('001', 'TES BARANG', 'MRK-001', 'STN-001', 100, 150, 138),
('002', 'TES BARANG KEDUA', 'MRK-001', 'STN-001', 200, 250, 100);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblmerk`
--

CREATE TABLE IF NOT EXISTS `tblmerk` (
  `ID` varchar(10) NOT NULL,
  `Merk` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblmerk`
--

INSERT INTO `tblmerk` (`ID`, `Merk`) VALUES
('MRK-001', 'TES MERK');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblsatuan`
--

CREATE TABLE IF NOT EXISTS `tblsatuan` (
  `ID` varchar(10) NOT NULL,
  `Satuan` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblsatuan`
--

INSERT INTO `tblsatuan` (`ID`, `Satuan`) VALUES
('STN-001', 'TES SATUAN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksi_beli`
--

CREATE TABLE IF NOT EXISTS `tbltransaksi_beli` (
  `No_Faktur` varchar(15) NOT NULL,
  `Tanggal` date NOT NULL,
  `Pemasok` varchar(35) NOT NULL,
  `Total` int(11) NOT NULL,
  PRIMARY KEY (`No_Faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksi_beli`
--

INSERT INTO `tbltransaksi_beli` (`No_Faktur`, `Tanggal`, `Pemasok`, `Total`) VALUES
('2013-09-08-001', '2013-09-08', 'SUPPLIER TES', 40),
('2013-09-11-002', '2013-09-11', 'Asiong', 15);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksi_beli_rinci`
--

CREATE TABLE IF NOT EXISTS `tbltransaksi_beli_rinci` (
  `No_Faktur` varchar(15) NOT NULL,
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(35) NOT NULL,
  `Harga_Beli` int(11) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Sub_Total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksi_beli_rinci`
--

INSERT INTO `tbltransaksi_beli_rinci` (`No_Faktur`, `ID`, `Nama`, `Harga_Beli`, `Jumlah`, `Sub_Total`) VALUES
('2013-09-08-001', '001', 'TES BARANG', 100, 100, 10000),
('2013-09-08-001', '002', 'TES BARANG KEDUA', 200, 150, 30000),
('2013-09-11-002', '001', 'TES BARANG', 100, 50, 5000),
('2013-09-11-002', '002', 'TES BARANG KEDUA', 200, 50, 10000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksi_jual`
--

CREATE TABLE IF NOT EXISTS `tbltransaksi_jual` (
  `No_Faktur` varchar(15) NOT NULL,
  `Tanggal` date NOT NULL,
  `Pembeli` varchar(35) NOT NULL,
  `Total` int(11) NOT NULL,
  PRIMARY KEY (`No_Faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksi_jual`
--

INSERT INTO `tbltransaksi_jual` (`No_Faktur`, `Tanggal`, `Pembeli`, `Total`) VALUES
('2013-09-08-001', '2013-09-08', 'PELANGGAN TES', 13);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksi_jual_rinci`
--

CREATE TABLE IF NOT EXISTS `tbltransaksi_jual_rinci` (
  `No_Faktur` varchar(15) NOT NULL,
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(35) NOT NULL,
  `Harga_Jual` int(11) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Sub_Total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksi_jual_rinci`
--

INSERT INTO `tbltransaksi_jual_rinci` (`No_Faktur`, `ID`, `Nama`, `Harga_Jual`, `Jumlah`, `Sub_Total`) VALUES
('2013-09-08-001', '002', 'TES BARANG KEDUA', 250, 50, 12500),
('2013-09-11-002', '001', 'TES BARANG', 150, 12, 1800),
('2013-09-11-002', '002', 'TES BARANG KEDUA', 250, 50, 12500);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
