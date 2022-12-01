// Shows validation message if necessary once focus is lost on a field.
$(".editor-field").on("focusout", "input", function () {
    var parent = $(this).closest(".editor-field");
    parent.find(".editor-validation").addClass("active");
});