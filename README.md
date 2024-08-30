# TaskManagementRepository
20240830:
Solution consist of 4 projects:
  - Commons (a library for shared functionalities)
  - WinForms (desktop UI)
  - API Service (my REST API for task management) //TODO
  - Unit Testing (tests) //TODO
For now app displays list of users to the left and 4 tabs with task views to the bottom right. Selecting users and tabs automatically triggers task view update. Clicking on a specific task lets us either modify or delete it. There is also a button in top right corner to create new task. The manager view for employee monthly statistics is simplified so the counter works for each month regardless from a year. That's actually something to correct as technically a user should have some kind of droplist with a year to select. App starts with config.json file that provides dataset containing 3 managers, 10 employees and 40 tasks assigned or shared among all users.
