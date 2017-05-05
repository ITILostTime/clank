//get the beeps
$(function () {
    $.getJSON('/api/beep', function (beepsJsonPayload) {
        $(beepsJsonPayload).each(function (i, item) {
            $('#beepOutput').append('<li>' + item.Name + '</li>');
        });
    });
});
//Send the beeps
$('#saveBeep').click(function () {
    $.post("/api/beep",
        $("#sendBeepForm").serialize(),
        function (value) {
            $('#beepOutput').append('<li>' + value.Name + '</li>');
        },
        "json"
    );
});