$(document).ready(function () {
    //$("#profile > div:first-child").css("padding", "6.5% 4% 3%")
    $("#profile > div:first-child > div:first-child > p").fadeIn(500);
    $("#profile > div:first-child > div:first-child > img").fadeIn(500);
    $("#profileInfo > div:first-child > p").css({ "transition": "1s", "color": "white" });
    $("#profileInfo > div:nth-child(2) > p").css({ "transition": "2s", "color": "white" });
    $("#profileInfo > div:nth-child(3) > p").css({ "transition": "3s", "color": "white" });
    $("#profileInfo > div:nth-child(4) > p").css({ "transition": "4s", "color": "white" });
    $("#profileInfo > div:nth-child(5) > p").css({ "transition": "5s", "color": "white" });
    $("#profileInfo > div:nth-child(6) > p").css({ "transition": "6s", "color": "white" });

    $("#bio").fadeIn(1000);
    $("#education").fadeIn(2000);
    $("#workExperience").fadeIn(3000);
    $("#contact").fadeIn(4000);

    $("#skills > div:first-child > div > div").css({ "transition": "1.5s", "height": "10px", "width": "80%" });
    $("#skills > div:nth-child(2) > div > div").css({ "transition": "1.5s", "height": "10px", "width": "80%" });
    $("#skills > div:nth-child(3) > div > div").css({ "transition": "1.5s", "height": "10px", "width": "60%" });
    $("#skills > div:nth-child(4) > div > div").css({ "transition": "1.5s", "height": "10px", "width": "40%" });
    $("#skills > div:nth-child(5) > div > div").css({ "transition": "1.5s", "height": "10px", "width": "40%" });
    $("#skills > div:nth-child(6) > div > div").css({ "transition": "1.5s", "height": "10px", "width": "50%" });
});

