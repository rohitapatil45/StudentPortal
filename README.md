# StudentPortal
Session 3 Assignment: Basic Student Portal in ASP.Net MVC
Assignment: Student Portal (Mini MVC App)

Build a small ASP.NET Core MVC app called StudentPortal with one StudentController.

 

Controller + ViewBag/ViewData
Create an Index action that passes a welcome message and today's date to the View using ViewBag, and a student count using ViewData. Display both in the View.
Action Methods + Parameters
Create a Details(int id) action reachable at /Student/Details/3. Just display the id on the page (no database needed — hardcode a few names in an array/list and show the one matching the id).
Form with GET/POST
Create a Create action pair:
[HttpGet] Create() — shows a form with Name, Age, Course fields
[HttpPost] Create(string name, int age, string course) — on submit, just show a confirmation page like "Student {name} added!" using ViewBag
Action Selector
Add a [Route("students/all")] custom route on an AllStudents action that lists the hardcoded students
