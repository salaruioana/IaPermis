# IaPermis

**IaPermis** is a desktop application designed to simulate the Romanian Category B driving theory exam. It provides an interactive environment for practicing driving theory quizzes in a format similar to the official exam.

## Features

- User registration and authentication
- Random generation of 26-question quizzes
- 30-second timer for each question
- Road-sign and traffic-situation images
- Automatic score and mistake calculation
- Automatic pass/fail evaluation
- User statistics and quiz history
- Local Help system
- Local data storage using XML and text files

## Technologies

- **C#**
- **.NET 8**
- **Windows Forms**
- **XML / local file storage**
- **Strategy Design Pattern**

## Architecture

The application follows a modular structure that separates the graphical user interface, application logic, and data storage mechanisms.

Questions are loaded from XML files, while user-related data and quiz statistics are stored locally. The application runs entirely on Windows and does not require a permanent Internet connection.

## My Contributions

As part of the development team, my main responsibilities were:

- Designed and implemented the graphical user interface using C# Windows Forms
- Integrated background and question-specific visual resources
- Implemented dynamic loading of images associated with driving theory questions
- Designed and integrated the local Help system (`IaPermisHelp.chm`)
- Wrote user-oriented documentation explaining the application's features and workflow

## Academic Project

Developed as a university team project at the Faculty of Automatic Control and Computer Engineering, TUIASI.
