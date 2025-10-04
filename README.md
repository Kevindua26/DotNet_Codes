# DotNet Codes

Small collection of short C# exercises and demos created as learning material.

## 📄 Questions

All the question text is in `Questions.pdf` at the repository root.

## 💻 Solutions

- All code is under `src/`. Each file follows the convention `Q<Number>_<ShortName>.cs` and contains a small demo program.
- Note: many files include a `Main` method. To run a specific exercise you can set the startup object in the project file or use the launcher (see below).

## ⚙️ Prerequisites

- [.NET SDK 9.0+](https://dotnet.microsoft.com/en-us/download)
- Visual Studio, Visual Studio Code, JetBrains Rider, or any C# capable editor

## 🛠️ Quick start

1. Clone the repository and enter the folder:

```bash
git clone https://github.com/Kevindua26/DotNet_Codes.git
cd DotNet_Codes
```

2. Restore and build:

```bash
dotnet restore
dotnet build
```

## 🚀 Running a specific demo

Because this repository contains many small programs (each with its own `Main`), the easiest options are:

1. Temporarily set the project startup object in `DotNet.csproj` (recommended when testing a single file):

```xml
<PropertyGroup>
  <!-- Example: run Q21_Constructors -->
  <StartupObject>DotNet.Q21_Constructors</StartupObject>
</PropertyGroup>
```

Then run:

```bash
dotnet run
```

2. Add a small launcher program (one `Main`) that lists available demos and invokes the selected one. I can add this launcher if you'd like — it avoids editing the csproj every time.

3. Create separate projects for GUI exercises (Q32, Q33) if you want to run the WinForms examples; those files are placeholders in this console project.

## Notes about WinForms exercises

- Q32 and Q33 are Windows Forms exercises and currently contain placeholders/descriptions — they require a WinForms project (Windows-only) to run as UI apps.

## Short list of recently added demos (Q21–Q42)

- Q21_Constructors — demonstrates different constructor types
- Q22_MethodOverloadOverride — method overloading and overriding
- Q23_OperatorOverloading — operator overloading (Complex)
- Q24_AbstractClass — abstract classes and methods
- Q25_InterfaceImplementation — implements IComparable for sorting
- Q26_Threading — basic Thread usage
- Q27_DelegatesEvents — delegates and events example
- Q28_Inheritance — hierarchical and multilevel inheritance
- Q29_Destructor — finalizer (destructor) demo
- Q30_InterfaceArray — arrays of interface types
- Q31_PropertiesIndexers — properties and indexers example
- Q32_WinFormsPlaceholder — WinForms student registration (placeholder)
- Q33_WinFormsDatabasePlaceholder — WinForms + DB (placeholder)
- Q34_DivideByZeroExceptionDemo — divide-by-zero handling
- Q35_IndexOutOfRangeDemo — IndexOutOfRangeException handling
- Q36_PaymentSystem — interface/abstract/concrete payment example
- Q37_VehicleTruck — inheritance with stats and destructors
- Q38_FactorialRecursion — recursive factorial
- Q39_SortNames — case-insensitive name sorting
- Q40_CustomException — custom InvalidAgeException
- Q41_SimpleBanking — simple bank account class
- Q42_FileHandling — create/write/read a text file

## Recommended next steps

- If you want to run demos without editing the csproj repeatedly, I can add a `Launcher.cs` with a single `Main` that enumerates and runs chosen examples.
- If you'd like full WinForms samples for Q32/Q33 I can scaffold a separate WinForms project and wire one simple form.

---

If you'd like I can update this README file in-place (I can also add the launcher). Which of the two do you prefer: add a launcher now, or only update README text?
