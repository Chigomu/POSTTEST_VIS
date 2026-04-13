CREATE DATABASE IF NOT EXISTS db_bluearchive;

USE db_bluearchive;

CREATE TABLE IF NOT EXISTS murid (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama_depan VARCHAR(50),
    nama_belakang VARCHAR(50),
    umur INT,
    sekolah VARCHAR(50),
    tahun_ajaran VARCHAR(50),
    jenis_kelamin VARCHAR(20),
    tanggal_lahir VARCHAR(20),
    hobi VARCHAR(255)
);

INSERT INTO murid (nama_depan, nama_belakang, umur, sekolah, tahun_ajaran, jenis_kelamin, tanggal_lahir, hobi) VALUES
('Shiroko', 'Sunaookami', 15, 'Abydos', 'Tahun Kedua', 'Perempuan', '16 Mei', 'Bersepeda, Jogging'),
('Hoshino', 'Takanashi', 17, 'Abydos', 'Tahun Ketiga', 'Perempuan', '02 Januari', 'Tidur siang, Mengumpulkan benda laut'),
('Serika', 'Kuromi', 15, 'Abydos', 'Tahun Pertama', 'Perempuan', '25 Juni', 'Menabung, Kerja paruh waktu'),
('Aru', 'Rikuhachima', 16, 'Gehenna', 'Tahun Kedua', 'Perempuan', '12 Maret', 'Mempelajari manajemen'),
('Hina', 'Sorasaki', 17, 'Gehenna', 'Tahun Ketiga', 'Perempuan', '19 Februari', 'Tidur, Bersantai'),
('Mutsuki', 'Asagi', 16, 'Gehenna', 'Tahun Kedua', 'Perempuan', '29 Juli', 'Mengumpulkan bom, Prank'),
('Hifumi', 'Ajitani', 15, 'Trinity', 'Tahun Kedua', 'Perempuan', '27 November', 'Belanja merchandise Peroro'),
('Neru', 'Mikamo', 17, 'Millennium', 'Tahun Ketiga', 'Perempuan', '17 Agustus', 'Bermain game action, Kemenangan'),
('Tsubaki', 'Kasuga', 16, 'Hyakkiyako', 'Tahun Kedua', 'Perempuan', '03 Februari', 'Tidur siang dimanapun');