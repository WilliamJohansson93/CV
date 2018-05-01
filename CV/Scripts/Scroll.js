$("#AboutMe").click(function () {
    $('html, body').animate({
        scrollTop: $("#skills > div:last-child").offset().top
    }, 1000);
});
$("#Education").click(function () {
    $('html, body').animate({
        scrollTop: $("#bio > div > p").offset().top
    }, 1000);
});
$("#WorkExperience").click(function () {
    $('html, body').animate({
        scrollTop: $("#education > div:last-child").offset().top
    }, 1000);
});
$("#ContactForm").click(function () {
    $('html, body').animate({
        scrollTop: $("#workExperience > div:last-child").offset().top
    }, 1000);
});
$("#Home").click(function () {
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 1000);
});