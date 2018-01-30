// Write your JavaScript code.
$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })
});
function scrollTopButton() {
    var offset = 220;
    var duration = 500;
    var button = $('<div class="am-scroll-top"></div>');
    button.appendTo("body");

    $(window).on('scroll', function () {
        if ($(this).scrollTop() > offset) {
            button.fadeIn(duration);
        } else {
            button.fadeOut(duration);
        }
    });

    button.on('touchstart mouseup', function (e) {
        $('html, body').animate({ scrollTop: 0 }, duration);
        e.preventDefault();
    });
    $('.carousel').carousel({
        interval: 2000
    });    
};
