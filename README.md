Requirements:

We need an API to handle 2 main types of requests
o A Request that lists all available cars
o A Request that books a car, and updates the list of available cars to remove the booked car
from the list
Cars are booked for 1 day a time. Once a car has been booked, and 24-hours has elapsed, the car
should then be available again for someone else to book.

Run Instructions:

1. Install ASP.NET CORE 2.2 on your local machine if you don't have it
2. Download the source code to your computer
3. Open solution with Visual Studio then build and run.
4. Do the following if you don't have Visual Studio installed
5. Open PowerShell/Terminal then go to the file location
6. Run "dotnet restore" where Bookcar_demo.sln locates
7. Run "dotnet run" where Bookcar_demo.csproj locates

Web API:
1. List all cars: http://localhost:xxxx/api/cars
2. List available cars: http://localhost:xxxx/api/cars/available
3. Book a car: send POST requests to http://localhost:xxxx/api/bookings with JSON { userId: 1, CarRego: "xxxxxx" }

TODO List:
1. Token-based Authentication & Role-based Authorisation
2. Unit Tests
3. Move ConnectionString to Environment Variable
4. Setup AutoMapper
5. User creation by Admin
6. Add Cars, Models, Makes by Admin
7. Cancel bookings by User
8. Extend borrowing request by User then approval by Admin
9. Full implementation of DTO
10. More Web API end points
