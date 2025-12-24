# Library Management System
Aplikasi ini dirancang untuk membantu pengelolaan perpustakaan secara terkomputerisasi, baik dari sisi admin maupun user. 
Sistem ini memudahkan proses pengelolaan data buku, data pengguna, transaksi peminjaman dan pengembalian buku, serta pembuatan 
laporan perpustakaan secara otomatis dan terstruktur.

Dengan adanya sistem ini, proses peminjaman dan pengembalian buku menjadi lebih cepat, data tersimpan dengan aman di dalam database, 
serta meminimalkan kesalahan pencatatan yang sering terjadi pada sistem manual.

##  Fitur
1. Autentikasi Pengguna
•	Login menggunakan username dan password
•	Registrasi akun khusus untuk user
•	Pembagian hak akses berdasarkan role (admin dan user)
2. Fitur Admin
•	CRUD Data Buku (tambah, edit, hapus, dan pencarian)
•	Manajemen Data User
•	Monitoring Transaksi Peminjaman
•	Pengelolaan Laporan:
o	Laporan peminjaman
o	Laporan buku
o	Laporan denda
•	Manajemen Profil Admin
•	Logout
3. Fitur User
•	Melihat daftar buku
•	Melakukan peminjaman buku
•	Melihat riwayat peminjaman pribadi
•	Melakukan pengembalian buku
•	Manajemen profil user (termasuk foto)
•	Logout
4. Sistem Otomatis
•	Stok buku berkurang saat peminjaman
•	Stok buku bertambah saat pengembalian
•	Perhitungan denda otomatis jika terlambat
•	Pencatatan aktivitas peminjaman ke log system

## Tech Stack
•	Bahasa Pemrograman : C#
•	Database : MySQL
•	Framework / UI : Windows Forms, Guna.UI
•	Database Connector : MySQL Connector
•	Arsitektur : CRUD + Trigger Database



