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
6. Run "dotnet restore"
7. Run "dotnet run"
