# DotNet Course Helper

This repository is created to help course students and others throughout their .NET journey. All code and solutions are shared publicly as part of #learningInPublic.

## 📄 Questions

- All questions are available in the [`Questions.pdf`](./Questions.pdf) file at the root of this repository.

## 💻 Solutions

- All code solutions are organized in the [`/src/`](./src/) directory.
- Each file in `/src/` corresponds to a specific question or topic.

## 🚀 How to Run a Solution

1. Open the project in Visual Studio Code or your preferred editor.
2. To run a specific solution, you need to set the entry point in `DotNet.csproj`:

   ```cs
   <StartupObject>DotNet.&lt;className&gt;</StartupObject>
   ```

   Replace `<className>` with the class containing the `Main` method you want to run (e.g., `Q4_StudentInfo`).
3. Build and run the project using:

   ```bash
   dotnet run
   ```

---

Happy coding and keep learning! 🎉
