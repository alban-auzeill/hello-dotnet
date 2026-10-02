# hello-dotnet

A minimal "Hello World" C# console application with one xUnit test, intended as a sample project for SonarQube Cloud analysis.

## Project structure

```
HelloDotnet.sln
src/HelloWorld/              Console application (Greeter + Program entry point)
tests/HelloWorld.Tests/      xUnit test project
.github/workflows/build.yml  GitHub Actions workflow (build + test)
```

## Prerequisites (macOS)

1. Install [Homebrew](https://brew.sh) if it is not already installed:

   ```bash
   /bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
   ```

2. Install the .NET 10 SDK:

   ```bash
   brew install --cask dotnet-sdk
   ```

3. Check the installation:

   ```bash
   dotnet --list-sdks
   ```

   The output must list a `10.0.x` SDK.

## Build, run and test

From the repository root:

```bash
# Restore NuGet packages and compile the solution
dotnet build

# Run the application (prints "Hello, World!")
dotnet run --project src/HelloWorld

# Run the application with a name argument (prints "Hello, Alice!")
dotnet run --project src/HelloWorld -- Alice

# Run the unit tests
dotnet test
```

## Continuous integration

The [Build workflow](.github/workflows/build.yml) runs on every push to `main` and on every pull request. It restores, builds and tests the solution with the .NET 10 SDK.
