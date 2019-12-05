
let rubrik = document.getElementById("rubrik")
function knappTryck() {
    alert("Hej");
}

function knappTryck1() {
    console.log("rader i consolen 1");
    console.log("rader i consolen 2");
}
function knappTryck2() {

    document.getElementById("rubrik").innerHTML = "Annan rubrik"
}

function knappTryck3() {

     document.getElementById("rubrik").style.color = "red"
}
function knappTryck4() {

    document.getElementById("rubrik").style.color = "blue"
}

//const toggle = () => rubrik.style.color === "red" ? rubrik.style.color = "green" : rubrik.style.color = "red"

function toggle() {
    if (rubrik.style.color == "red") {
        rubrik.style.color = "green"
    }
    else 
        rubrik.style.color = "red"
}

let knappy = document.getElementById("knapp5")
let togglebutton = document.getElementById("toggle")
knappy.onclick = knappTryck4
togglebutton.onclick = toggle





    
