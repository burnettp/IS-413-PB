function addTotal() {
    // Grabs the values from the HTML form
    var assignments = parseInt($("#assignments").val());
    var groupProject = parseInt($("#groupProject").val());
    var quizzes = parseInt($("#quizzes").val());
    var exams = parseInt($("#exams").val());
    var intex = parseInt($("#intex").val());

    // Adds up HTML form values and initializes gradeLetter
    var gradePercent = (assignments + groupProject + quizzes + exams + intex);
    var gradeLetter = ''

    // Dynamically change the letter grade based on gradePercent
    if (gradePercent >= 94) {
        gradeLetter = "A"
    } else if (gradePercent >= 90) {
        gradeLetter = "A-"
    } else if (gradePercent >= 87) {
        gradeLetter = "B+"
    } else if (gradePercent >= 84) {
        gradeLetter = "B"
    } else if (gradePercent >= 80) {
        gradeLetter = "B-"
    } else if (gradePercent >= 77) {
        gradeLetter = "C+"
    } else if (gradePercent >= 74) {
        gradeLetter = "C"
    } else if (gradePercent >= 70) {
        gradeLetter = "C-"
    } else if (gradePercent >= 67) {
        gradeLetter = "D+"
    } else if (gradePercent >= 64) {
        gradeLetter = "D"
    } else if (gradePercent >= 60) {
        gradeLetter = "D-"
    } else {
        gradeLetter = "E"
    }

    // Alerts the final message
    alert("The student finished with a " + gradePercent + "% in the class which is a(n) " + gradeLetter + ".");;
}