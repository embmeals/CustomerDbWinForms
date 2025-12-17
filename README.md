# Customer Database WinForms Application

A Windows Forms application for managing customer data with a clean, user-friendly interface.

## Features

- **Customer Management**: Add, edit, and delete customer records
- **Data Validation**: Ensures data integrity with input validation
- **User-Friendly Interface**: Intuitive Windows Forms UI
- **Database Integration**: Efficient data storage and retrieval

## Requirements

- .NET Framework (version specified in project file)
- Windows OS
- Visual Studio or JetBrains Rider for development

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/embmeals/CustomerDbWinForms.git
   ```

2. Open the solution in Visual Studio or JetBrains Rider

3. Build and run the project

## Usage

1. Launch the application
2. Use the main form to manage customer records
3. Add new customers using the provided form fields
4. Edit existing customer information
5. Delete customer records as needed

## Project Structure

```
CustomerDbWinForms/
├── Customer.cs              # Customer entity model
├── CustomerService.cs       # Business logic for customer operations
├── Form1.cs                 # Main application form
├── Form1.Designer.cs        # Auto-generated form designer code
├── Program.cs               # Application entry point
├── CustomerDbWinForms.csproj # Project configuration
└── README.md                # This file
```

## Development

### Building the Project

Using Visual Studio:
```bash
dotnet build CustomerDbWinForms.csproj
```

Using JetBrains Rider:
- Open the project
- Use the Build menu or press Ctrl+F9

### Running the Application

```bash
dotnet run
```

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contact

Project Link: [https://github.com/embmeals/CustomerDbWinForms](https://github.com/embmeals/CustomerDbWinForms)

## Technologies Used

- C# (.NET Framework)
- Windows Forms
- Git for version control