# ODataSandboxApi

## Start

Start the API with the following command, this also creates and seeds a SQL Server database.

```bash
dotnet run
```

## Normal Api

- https://localhost:7103/students

## OData Api

- https://localhost:7103/orest/students
- https://localhost:7103/orest/students?orderBy=FirstMidName&count=true
- https://localhost:7103/orest/students?expand=Enrollments(expand=Course($select=title))
- https://localhost:7103/orest/students?$compute=concat(concat(LastName, ' '),FirstMidName) as name&select=name
- https://localhost:7103/orest/students?$expand=Enrollments($expand=Course(select=title);select=Grade;filter=grade eq 'A')
- https://localhost:7103/orest/students?$expand=Enrollments&$count=true&$top=2&skip=1

## Docs

- https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/
- https://www.odata.org/documentation/
