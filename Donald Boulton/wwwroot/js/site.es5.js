// Write your JavaScript code.
'use strict';

$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip();
    });
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
}
$(document).ready(function () {
    if ($.support.pjax) $(document).on("click", "a[data-pjax]", function (a) {
        var b = $(this).closest("[data-pjax-container]");$.pjax.click(a, { container: b });
    });$("html").animate({ scrollTop: 0 }, 1);$("body").animate({ scrollTop: 0 }, 1);function a(a) {
        console.log("success!");
    }
    var b = function b() {
        $(".invisible-recaptcha").each(function () {
            grecaptcha.render($(this).attr("id"), { sitekey: "6LeDCEAUAAAAAHli9WYua3IAAWa5rnslJasIIRGC", callback: function callback(a) {
                    $rs.validCaptcha = a;$s.$apply();
                } });
        });
    };
});$(".group1").colorbox({ rel: "group1" });$(".group2").colorbox({ rel: "group2", transition: "fade" });$(".group3").colorbox({ rel: "group3", transition: "none", width: "80%", height: "80%" });$(".group4").colorbox({ rel: "group4", slideshow: true });$(".ajax").colorbox();$(".youtube").colorbox({ iframe: true, innerWidth: 640, innerHeight: 390 });$(".vimeo").colorbox({ iframe: true, innerWidth: 500, innerHeight: 409 });$(".iframe").colorbox({ iframe: true, width: "80%", height: "80%" });$(".inline").colorbox({ inline: true, width: "80%" });$(".callbacks").colorbox({ onOpen: function onOpen() {
        alert("onOpen: colorbox is about to open");
    }, onLoad: function onLoad() {
        alert("onLoad: colorbox has started to load the targeted content");
    }, onComplete: function onComplete() {
        alert("onComplete: colorbox has displayed the loaded content");
    }, onCleanup: function onCleanup() {
        alert("onCleanup: colorbox has begun the close process");
    }, onClosed: function onClosed() {
        alert("onClosed: colorbox has completely closed");
    } });$(".non-retina").colorbox({ rel: "group5", transition: "none" });$(".retina").colorbox({ rel: "group5", transition: "none", retinaImage: true, retinaUrl: true });$("#click").click(function () {
    $("#click").css({ "background-color": "#f00", color: "#fff", cursor: "inherit" }).text("Open this window again and this message will still be here.");return false;
});var resizeTimer;function resizeColorBox() {
    if (resizeTimer) clearTimeout(resizeTimer);resizeTimer = setTimeout(function () {
        if (jQuery("#cboxOverlay").is(":visible")) jQuery.colorbox.resize({ width: "90%", height: "90%" });
    }, 300);
}
jQuery(window).resize(resizeColorBox);window.addEventListener("orientationchange", resizeColorBox, false);window.addEventListener("load", function () {
    window.cookieconsent.initialise({ palette: { popup: { background: "#3c404d", text: "#d6d6d6" }, button: { background: "#8bed4f" } }, theme: "classic", content: { href: "https://mansbooks.com" } });
});$(".dropdown-menu a.dropdown-toggle").on("click", function (a) {
    if (!$(this).next().hasClass("show")) $(this).parents(".dropdown-menu").first().find(".show").removeClass("show");var b = $(this).next(".dropdown-menu");b.toggleClass("show");$(this).parents("li.nav-item.dropdown.show").on("hidden.bs.dropdown", function (a) {
        $(".dropdown-submenu .show").removeClass("show");
    });return false;
});$('form').submit(function () {
    if ($(this).valid()) {
        $(this).find('button[type="submit"]').prop('disabled', true).attr('style', 'background:none!important;border:none!important').html('<i class="fas fa-spinner fa-spin"></i>');
    }
});

