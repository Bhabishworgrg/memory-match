# System Requirements

You'll need:
- One of the following operating systems:
  - [Windows](#Windows) (10 or later)
  - [Linux](#Linux) (any modern distribution)
- An adequately powerful computer:
    - At least 4 GB of RAM
    - At least 2 GB of free disk space
    - At least a dual-core CPU
    - Integrated GPU should be sufficient for basic gameplay

# Dependencies

## Windows
You'll need to install the following dependencies:
- [Git](https://git-scm.com/download/win)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Godot 4.3 (.NET Version)](https://godotengine.org/download/archive/4.3-stable/)

## Linux
### Arch
You'll need to install the following dependencies:
- Git
```bash
sudo pacman -S git
```
- .NET 8.0 SDK
```bash
sudo pacman -S dotnet-sdk-8.0
```
- [Godot 4.3 (.NET Version)](https://godotengine.org/download/archive/4.3-stable/)

### Debian
You'll need to install the following dependencies:
- Git
```bash
sudo apt install git
```
- .NET 8.0 SDK
```bash
sudo apt install dotnet-sdk-8.0
```
- [Godot 4.3 (.NET Version)](https://godotengine.org/download/archive/4.3-stable/)

### Fedora
You'll need to install the following dependencies:
- Git
```bash
sudo dnf install git
```
- .NET 8.0 SDK
```bash
sudo dnf install dotnet-sdk-8.0
```
- [Godot 4.3 (.NET Version)](https://godotengine.org/download/archive/4.3-stable/)

# Getting the Code

To get the latest version of the code, run:
```bash
git clone https://github.com/Bhabishworgrg/memory-match.git
```

# Building the Project

Open the pulled repository as a project in Godot.

Create a C# solution:
```
Project -> Tools -> C# -> Create C# Solution
```

Install export templates:
```
Editor -> Manage Export Templates... -> Download and Install
```

Open export manager:
```
Project -> Export...
```

Choose the template based on your system architecture and export the project.
