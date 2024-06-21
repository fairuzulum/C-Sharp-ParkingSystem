# Sistem Parkir

## Pendahuluan
Sistem parkir ini dirancang untuk mengelola alokasi slot parkir untuk mobil dan motor di sebuah tempat parkir. Sistem ini memungkinkan pengguna untuk membuat tempat parkir, memarkir kendaraan, mengeluarkan kendaraan, dan mendapatkan laporan status tempat parkir. Program ini diimplementasikan menggunakan bahasa pemrograman C# dan dijalankan di konsol.

## Struktur Kode
Kode ini terdiri dari tiga bagian utama:
1. **Kelas `Vehicle`**: Merepresentasikan setiap slot parkir.
2. **Kelas `ParkingSystem`**: Mengelola logika parkir, keluar, dan laporan.
3. **Kelas `Program`**: Menjalankan aplikasi dan menerima input dari pengguna.

### Kelas `Vehicle`
Kelas ini merepresentasikan setiap slot parkir dan memiliki properti berikut:
- `SlotNumber`: Nomor slot parkir.
- `PoliceNumber`: Nomor polisi kendaraan yang diparkir.
- `Color`: Warna kendaraan.
- `VehicleType`: Jenis kendaraan (mobil atau motor).

### Kelas `ParkingSystem`
Kelas ini mengelola logika parkir, keluar, dan laporan dengan properti dan metode berikut:

#### Properti
- `_parkingSlot`: Daftar (list) dari objek `Vehicle`.
- `_capacity`: Kapasitas total tempat parkir.
- `_created`: Indikator apakah tempat parkir telah dibuat.

#### Metode
- **`CreateParkingPlace(int count)`**: Membuat tempat parkir dengan jumlah slot yang ditentukan.
- **`VehicleParking(string policeNumber, string color, string vehicleType)`**: Memarkir kendaraan ke slot yang tersedia.
- **`ParkingQuit(int slotNumber)`**: Mengeluarkan kendaraan dari slot yang ditentukan.
- **`StatusReport()`**: Menampilkan status tempat parkir.
- **`VehicleType(string vehicleType)`**: Menampilkan jumlah kendaraan berdasarkan jenis.
- **`EvenAndOdd(bool check)`**: Menampilkan nomor kendaraan dengan plat ganjil atau genap.
- **`VehicleColor(string color)`**: Menampilkan nomor kendaraan berdasarkan warna.
- **`SlotVehicleColor(string color)`**: Menampilkan slot kendaraan berdasarkan warna.
- **`SlotForPoliceNumber(string policeNumber)`**: Menampilkan slot untuk nomor polisi tertentu.

