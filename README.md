# Otel Basic Otomasyon

A simple hotel management application written in C# Windows Forms, backed by SQL Server. After logging in, staff can register customers, open a stay record for one of 14 rooms, see room occupancy, check customers out (by deleting the record), and save messages for customers. The UI and the code are entirely in Turkish.

## Features

- **Staff login** (`Form6`, the application's startup form): The username and password are checked against the `personeller` table.
- **Main menu** (`Form3`): Navigation to the Müşteri Kayıt (Customer Registration), Mesajlar (Messages), Müşteri Çıkış (Customer Check-out) and Oda Kontrol (Room Status) screens.
- **Customer registration** (`Form1`, class name `mkayıt`): Collects national ID (TC kimlik no), first name, last name, address, phone (masked input), date of birth and gender. The TC and phone fields accept digits only, and the first and last name fields accept letters only. First and last names are converted to uppercase.
- **Room registration** (`odakayıt`): Check-in and check-out date/time, a meals-included option and the room number (1–14) are selected. Occupied rooms are shown in red. On save, the app checks that the TC is not already registered and that the room is free; the customer is then written to the `müsteriler` table and the stay to the `odakayıt` table.
- **Price calculation**: Number of days × 1000. If meals are included, the result is multiplied by 1.25.
- **Room status** (`Form5`): The occupancy of all 14 rooms is shown by color (occupied rooms in red).
- **Customer check-out** (`Form4`): All room records are listed in a grid, can be filtered by TC, and check-out is done by deleting the selected row's record.
- **Messages** (`Form2`): A message is saved for a TC that exists in the system; all messages are shown in a list.

## Technology

- C#, Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server (`System.Data.SqlClient`, Windows authentication)
- Visual Studio 2022 solution file (`burakproje.sln`, VS 17)

## Project structure

```
burakproje.sln
burakproje/
├── Program.cs                 # Entry point, starts with Form6
├── App.config                 # Connection string and runtime setting
├── Form6.cs                   # Staff login
├── Form3.cs                   # Main menu
├── Form1.cs                   # Customer details (mkayıt)
├── odakayıt.cs                # Room / stay registration
├── Form5.cs                   # Room status
├── Form4.cs                   # Customer check-out
├── Form2.cs                   # Messages
├── odakontrol.cs              # Empty form (unused)
├── projeotelDataSet.xsd       # Typed DataSet (müsteriler table only)
├── Properties/
└── Resources/left-arrow-28-48.png   # Back button icon
```

## Requirements

- Windows
- Visual Studio (with the .NET desktop development workload) and .NET Framework 4.7.2
- SQL Server (Express or LocalDB also work) and a database named `projeotel`

## Database

The repository has no database creation script. These are the tables and columns used in the code:

| Table | Columns |
|---|---|
| `personeller` | `kullaniciadi`, `password` |
| `müsteriler` | `mtc`, `mad`, `msoyad`, `mcinsiyet`, `mDogumTarihi`, `mtel`, `madres` |
| `odakayıt` | `mtc`, `GTarih`, `CTarih`, `Yemek`, `odano`, `ucret` |
| `mesajlar` | `id`, `mtc`, `Mesaj` |

Column types can't be determined with certainty from the code. A few notes:

- `DateTime` values are written to `GTarih` and `CTarih`.
- `"0"` or `"1"` is written to `Yemek`, and `"Erkek"` or `"Kadın"` (male / female) to `mcinsiyet`.
- `Form4` reads the TC from the grid's 5th column (`Cells[4]`), so the column order in the `odakayıt` table matters.
- `mesajlar.id` should be an auto-increment field.

To be able to log in, at least one user has to be added to the `personeller` table manually.

## Setup and running

1. Create the `projeotel` database and the tables above in SQL Server.
2. Update the connection string for your server (see below).
3. Open `burakproje.sln` in Visual Studio and run it with F5.

## Configuration

The connection string is defined only in `burakproje/App.config`, under the name `burakproje.Properties.Settings.projeotelConnectionString`. The default value is `Data Source=DESKTOP-3GIB9O5;Initial Catalog=projeotel;Integrated Security=True;Encrypt=False`; changing this value to match your server is all that's needed.

`Form2.cs`, `Form4.cs`, `Form5.cs`, `Form6.cs` and `odakayıt.cs` read the connection string from this entry via `ConfigurationManager.ConnectionStrings[...]` (the project references `System.Configuration`). In the compiled application the same setting lives in `burakproje.exe.config`.

## Notes and limitations

- Passwords are stored and compared as plain text in the database (the queries are parameterized, but passwords are not hashed).
- The room occupancy check doesn't look at date ranges; if the `odakayıt` table has any record with that room number, the room counts as occupied. A second record with the same TC can't be opened either.
- In the price calculation, the day difference is converted to an integer with `Convert.ToInt32`. If the time between check-in and check-out is not a whole number of days, an error may occur.
- The number of rooms (14) and the daily rate (1000) are hard-coded.
- The repository has no license file; no license is specified.
