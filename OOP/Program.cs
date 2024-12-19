using OOP.School;

#region RegularStudentTesting

// Create student
Student aziz = new Student("Abdulaziz", "Marafi", "Computer Science", 23, 3.76);

// Display student summary
aziz.studentSummary();

DateOnly  gradDate = new DateOnly(2018, 10, 25);

// create graduated student
GraduatedStudent bread = new GraduatedStudent("Abdulaziz", "Marafi", "Computer Science", 23, 3.76, "First Class", gradDate);

bread.studentSummary();

#endregion