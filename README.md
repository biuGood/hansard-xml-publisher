# Hansard XML Publisher

A small ASP.NET Core MVC web application that reads Hansard-style transcript data from an XML file and displays it as a searchable publishing page.
<img width="3826" height="1889" alt="image" src="https://github.com/user-attachments/assets/56b5cad2-fd84-4df7-a969-8d0bc2c61a97" />
<img width="3835" height="1914" alt="image" src="https://github.com/user-attachments/assets/ff711066-0c67-4662-bab4-438b42783404" />



## Project Overview

This project simulates a simple publishing workflow for legislative transcript content. It reads structured XML data, converts it into C# models, and displays the results in a web interface using ASP.NET Core MVC.

The goal of this project is to demonstrate basic skills in:

- ASP.NET Core MVC
- C#
- XML parsing
- Model-View-Controller structure
- Web page rendering
- Basic front-end styling with CSS
- Git and GitHub project management

## Features

- Reads transcript data from a local XML file
- Parses sitting date, session title, speaker, role, and transcript content
- Displays transcript entries in a clean table layout
- Shows total number of transcript entries
- Includes a search input for filtering transcript content
- Uses a service layer to separate XML parsing logic from the controller

## Tech Stack

- C#
- ASP.NET Core MVC
- .NET SDK
- XML
- HTML
- CSS
- JavaScript
- Git / GitHub

## Project Structure

```text
HansardXmlPublisher
├── Controllers
│   └── HomeController.cs
├── Data
│   └── transcripts.xml
├── Models
│   ├── TranscriptEntry.cs
│   └── TranscriptViewModel.cs
├── Services
│   └── TranscriptXmlService.cs
├── Views
│   └── Home
│       └── Index.cshtml
├── wwwroot
│   └── css
│       └── site.css
└── Program.cs
