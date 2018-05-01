$(document).ready(function () {

    function displayTime() {
        var currentTime = new Date();
        var hours = currentTime.getHours();
        var minutes = currentTime.getMinutes();
        var seconds = currentTime.getSeconds();
        var datenumber = currentTime.getMonth();
        var daynumber = currentTime.getDate();
        var day = currentTime.getDay();
        var nameofDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
        var nameofMonth = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        // This gets a "handle" to the clock div in our HTML
        var clockDiv = document.getElementById('clock');
        if (seconds < 10) {
            // Add the "0" digit to the front
            // EXAMPLE: so 9 becomes "09"
            seconds = "0" + seconds;
        }
        if (minutes < 10) {
            // Add the "0" digit to the front
            // EXAMPLE: so 9 becomes "09"
            minutes = "0" + minutes;
        }
        if (hours < 10) {
            // Add the "0" digit to the front
            // EXAMPLE: so 9 becomes "09"
            hours = "0" + hours;
        }
        // Then we set the text inside the clock div 
        // to the hours, minutes, and seconds of the current time
        if (daynumber === 1 || daynumber === 31 || daynumber === 21) {
            clockDiv.innerText = nameofMonth[datenumber] + " " + daynumber + "st" + ", " + nameofDays[day] + " - " + hours + ":" + minutes + ":" + seconds;
        }
        else if (daynumber === 2 || daynumber === 22) {
            clockDiv.innerText = nameofMonth[datenumber] + " " + daynumber + "nd" + ", " + nameofDays[day] + " - " + hours + ":" + minutes + ":" + seconds;
        }
        else if (daynumber === 3 || daynumber === 23) {
            clockDiv.innerText = nameofMonth[datenumber] + " " + daynumber + "rd" + ", " + nameofDays[day] + " - " + hours + ":" + minutes + ":" + seconds;
        }
        else {
            clockDiv.innerText = nameofMonth[datenumber] + " " + daynumber + "th" + ", " + nameofDays[day] + " - " + hours + ":" + minutes + ":" + seconds;
        }
    }
    // This runs the displayTime function the first time
    displayTime();
    setInterval(displayTime, 1000);
});
