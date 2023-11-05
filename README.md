## penting untuk memulai

Project ini adalah Simple CRUD API menggunakan postgreSQL dan swagger(Bisa Pula Postman)
Menggunakan Framework  ASP.NET Core 7 (Terbaru) dan Text Editor Visual Studio Code

Berikut ini Hasil Implementasinya : 
## Tampilan awal saat di run 
![Semantic description of image](img/1.png)<br>*Tampilan awal saat di run menggunakan command 'dotnet run' dan menammpilkan loggingnya*
## localhost : < port>/swagger/index.html
![Semantic description of image](img/2.png)<br>*Saat di jalankan "localhost:< port>/Swagger/index.html*
## database dan request GET api/Customers 
![Semantic description of image](img/3.png)<br>*Tampilan database Customers yang sesuai dengan Request GET/api/Customers*
## mengirim data via POST api/Customers dengan postman
![Semantic description of image](img/4.png)<br>*Mengisi data dengan POST method dan hasilnya akan tersimpan ke database*
## fetching data from jsonplaceholder.com/todos
![Semantic description of image](img/5.png)<br>*hasil dari hit request GET pada endpoint api/Todos*
## request GET by id 
![Semantic description of image](img/7.png)<br>*request endpoint Todo by id*




Saat pertama kali menggunakan pastikan untuk menambahkan package sebagai berikut di CustomerAPI.csproj:
<br>
 `<ItemGroup>`
  <br>
    `<PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="7.0.3" />`
  <br>
    `<PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.4" />`
  <br>
    `<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="7.0.4">`
  <br>
    `<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />`
  <br>
    `<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="7.0.3" />`
  <br>
    `<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL.Design" Version="1.1.0" />`
  <br>
    `<PackageReference Include="Serilog.AspNetCore" Version="6.1.0" />`
  <br>
    `<PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />`
  <br>
  `</ItemGroup>`
