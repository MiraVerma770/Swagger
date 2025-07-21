# SwaggerDemo

This is a minimal .NET 8 Web API project with Swagger integration using Swashbuckle.

## Features

- .NET 8 Web API
- Swagger UI for interactive documentation
- Sample CRUD endpoints
- Minimal setup, easy to run

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio or VS Code

### Run the API

```bash
dotnet restore
dotnet run
```

Then open in browser: `https://localhost:5001`

## Sample Endpoints

| Method | Route          | Description        |
|--------|----------------|--------------------|
| GET    | /api/hello     | Get greeting       |
| POST   | /api/hello     | Create message     |
| PUT    | /api/hello     | Update message     |
| DELETE | /api/hello/{id}| Delete message     |

## License

MIT
