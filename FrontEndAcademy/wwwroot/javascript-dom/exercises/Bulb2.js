let bulb = document.getElementById("bulb")
let switchen = true;
let switchen1 = true;
let switchen2 = true;

bulb.onclick = function () {


    if (switchen) {
        bulbimg.src = "img/bulboff.png"
        switchen = false;
    } else {
        bulbimg.src = "img/bulbon.png"
        switchen = true;
    }
}


bulb1.onclick = function () {


    if (switchen1) {
        bulbimg1.src = "img/bulboff.png"
        switchen1 = false;
    } else {
        bulbimg1.src = "img/bulbon.png"
        switchen1 = true;
    }
}

bulb2.onclick = function () {


    if (switchen2) {
        bulbimg2.src = "img/bulboff.png"
        switchen2 = false;
    } else {
        bulbimg2.src = "img/bulbon.png"
        switchen2 = true;
    }
}
