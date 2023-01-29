document.getElementById("submit").addEventListener("submit", submission);

var name = document.getElementById("userName");

var timeoutEvent = new Event("timeout");

name.addEventListener("timeout", function () {
    if (name.value === "")
        alert("You Haven't Entered Any Data!");
})

function submission(e) {
    var confirmation = confirm("Do you want to submit?")
    if (!confirmation) {
        e.preventDefault()
    }
}

setTimeout(function () {
    document.getElementById("userName").dispatchEvent(timeoutEvent)
}, 10000);