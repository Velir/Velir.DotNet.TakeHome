// Shows validation message if necessary once focus is lost on a field.
// Only hits on focusout as we only want to show the error message once a user has moved on to the next field.
// If a field has an invalid value, the submit button is forcibly disabled.
$(".editor-field").on("focusout", "input, textarea", function () {    
    if ($(this).hasClass("input-validation-error")) {
        var parent = $(this).closest(".editor-field");
        parent.find(".editor-validation").addClass("active");
        var form = $(this).closest("form");
        ///form.find("input[type=\"submit\"]").prop("disabled", true);
        $(this).parent().removeClass("checkmark");
    }
    else {
        $(this).parent().addClass("checkmark");
    }
});

// Checks for valid fields before submitting, and lists any invalid fields on the page.
// If no invalid fields are found, submittion routes normally.
$("form").on("submit", function (e) {
    if ($(this).find(".input-validation-error").length > 0) {
        e.preventDefault();
        $(".form-error").addClass("active");
        // Clear the currently displayed invalid fields
        $(".form-error").find("ul").empty();
        var invalidFields = "";
        // Compile a list of all invalid fields and list their labels.
        $(this).find(".input-validation-error").each(function () {
            var field = $(this).attr("name");
            var label = $(this).closest("fieldset").find("*[for=\"" + field + "\"]").html();
            invalidFields += "<li>" + label + "</li>";
            $(".form-error ul").html(invalidFields);
        });
    }
});