# Animal Shelter

#### Animal shelter shows animals currently in shelter

#### By [Anastasiia Riabets](https://github.com/anastasiia-ria)

## Technologies Used

- CSS
- HTML
- C#
- .NET 5.0
- ASP.Net
- Razor
- dotnet script REPL
- MySQL
- Workbench
- EF Core

## Description

Animal shelter shows animals currently in shelter using [Animal Shelter Api](https://github.com/anastasiia-ria/AnimalShelterApi.Solution). User has an option to filter animals by different parameters, such as species, sex, color, and/or breed.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anastasiia-ria/AnimalShelterClient.Solution.git
     ~/Desktop $ cd AnimalShelterClient.Solution
     ```
- Install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- Create appsettings.json file:
  ```
   ~/Desktop/AnimalShelterClient.Solution $ cd AnimalShelter
   ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ touch appsettings.json
   ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ echo '{
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=anastasiia_riabets;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  ```
  [PASSWORD] is your password
- Install packages and tools:
  ```
  ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ dotnet restore
  ```
- Update Database:
  ```
  ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ dotnet ef database update
  ```
- Build the project:
  ```
   ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ dotnet build
  ```
- Run the project
  ```
   ~/Desktop/AnimalShelterClient.Solution/AnimalShelter $ dotnet run
  ```
- Visit [http://localhost:5000](http://localhost:5000) to try this application

## Known Bugs

-

## License

[ISC](https://opensource.org/licenses/ISC)

Copyright (c) 04/01/2022 Anastasiia Riabets
