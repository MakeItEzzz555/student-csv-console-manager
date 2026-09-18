# Student CSV Console Manager

C# console coursework that adds student records and displays persisted CSV-style entries.

## Overview

Console menu adds student details and displays stored student records.

## Features

Menu validation, CSV-like file persistence.

## Tech Stack

C# / .NET Framework 4.7.2

## Preview

Command: `ConsoleApp2.exe`

A fresh local run adds and displays a synthetic record (menu choices `1`, `2`, then `3`).

```text
--- Student Management System ---
1. Add a new student
2. Display all students
3. Exit
Enter your choice:
Enter Student ID: Enter Student Name: Enter Course Name: Enter Fee Paid: Student details saved successfully!

--- Student Management System ---
1. Add a new student
2. Display all students
3. Exit
Enter your choice:
--- List of Students ---
ID: DEMO001
Name: Alex Example
Course: Introduction to Programming
Fee Paid: 100
------------------------

--- Student Management System ---
1. Add a new student
2. Display all students
3. Exit
Enter your choice: Exiting the program...
```

## Getting Started

Open `ConsoleApp2.sln` in Visual Studio with .NET Framework 4.7.2 development support. Build and start ConsoleApp2. Menu options add records, display records and exit. Records are written to `students.in` in the working directory. Original runtime/student files are excluded; a fresh run creates storage.

## Validation

Lightweight local checks: .NET Framework 4.7.2 compilation. Compilation and syntax checks do not verify application behavior. Source is preserved; interactive application behavior was not executed during archival.

## Notes

Original implementation is preserved. Build outputs, dependencies, machine-specific IDE state, backups, submission documents and private runtime data are excluded. No license has been inferred for the original work.
