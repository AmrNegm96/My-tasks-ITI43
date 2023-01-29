document.getElementById('txt1').addEventListener("keydown", showAlert);

function showAlert(btn) {
    if (btn.ctrlKey) 
    {
        alert("Ctrl Key");
    } 
    else if (btn.altKey) 
    {
        alert("Alt Key");
    } 
    else if (btn.shiftKey) 
    {
        alert("Shift Key");
    } 
    else
    {
        alert("ASCII Code is : " + btn.keyCode);
    }
        
}