var modal = document.getElementById('loginScn');
var btn = document.getElementById('cncl');

btn.onclick = function (event) {
        modal.style.display = 'none'
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = 'none';
    }
}