$("#rabbit").draggable();

$("#hole").droppable({
  drop: function () {
    $("#rabbit").hide()}
});
