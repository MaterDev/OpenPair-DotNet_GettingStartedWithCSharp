# OpenPair: .Net - Getting Started with C\#

![cover](cover.png)

This repository includes a simple console application highlighting C# core features, unique language characteristics, and the use of a common dependency through the NuGet Package Manager.

> **👾 This repo is the code for: [OpenPair: .Net #01 - Getting Started with C# (Introduction)](https://www.youtube.com/watch?v=fV0fkyRcPdk&list=PL2NvA4OAtDRQuJKzP8w18WeTDoMBnTgkn&index=1)**

## Prerequisites

Before you begin, ensure you have the following installed on your macOS:

- [Visual Studio Code (VS Code)](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)

## Installation

1. **Clone the Repository**:

   ```bash
   git clone git@github.com:MaterDev/OpenPair-DotNet_GettingStartedWithCSharp.git
   cd OpenPair-DotNet_GettingStartedWithCSharp
   ```
2. **Restore Dependencies**:
   Run `dotnet restore` to install necessary packages.

## Project Structure

- `Program.cs`: Contains the main program and demonstrates basic C# features like data types, control structures, methods, classes, LINQ, and lambda expressions.
- `output/`: Contains the built executable for macOS.
- `.vscode/tasks.json`: Defines a build task for creating a macOS executable.

## Features

- Basic syntax and data types in C#.
- Control flow examples (if-else, for loop).
- Array and collection handling.
- Method definition and usage.
- Introduction to object-oriented programming with a simple `Person` class.
- Usage of LINQ for data querying.
- Lambda expressions for concise function definitions.
- Demonstrating JSON serialization using `Newtonsoft.Json` package.

## Building the Project

To build the project and create a macOS executable:

1. **Open VS Code's Command Palette** (`Cmd + Shift + P`).
2. **Run Task**: Type `Run Task` and select `Tasks: Run Task`.
3. **Choose `build-release` Task**: This will compile the project and place the executable in the `output` folder.

Alternatively, you can run the build command directly in the terminal:

```bash
dotnet publish -c Release -o ./output --self-contained -r osx-x64
```

## License

Distributed under the GNU License. See [`LICENSE`](./LICENSE) for more information.
