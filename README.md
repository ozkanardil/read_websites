YouTube Channel Video Fetcher
Overview
The YouTube Channel Video Fetcher is a .NET Core console application designed to retrieve and display video data from a specified YouTube channel. By leveraging the YouTube RSS feed, this application lists the most recent videos based on a user-defined time frame.

Features
Fetch Recent Videos: Retrieve and list videos from a specified YouTube channel published within a certain number of days.
Modular Design: The application is structured with a shared class library for common services, promoting code reusability and maintainability.
Simple and Efficient: The console application is straightforward to use, requiring only the YouTube channel's RSS feed URL and the number of days to filter videos.
Project Structure
Console Application: The main entry point of the application, responsible for initiating the video fetching process and displaying the results.
Shared Library: Contains the ReadYouTube class, which encapsulates the logic for reading and processing the YouTube RSS feed.
Usage
Upon execution, the application connects to the specified YouTube channel's RSS feed, fetches the video data, and displays the titles, links, and publish dates of the recent videos on the console.

Purpose
This project demonstrates how to build a modular .NET Core application with a focus on clean architecture and reusable components. It serves as an educational tool for developers looking to understand and implement similar functionalities in their projects.

Feel free to explore the code and adapt it to your needs. Contributions and feedback are welcome!
