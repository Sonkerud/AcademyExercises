let bulb = document.getElementById("bulb")
let bulbimg1 = document.getElementById("bulbimg1")
let bulbimg2 = document.getElementById("bulbimg2")
let bulbimg3 = document.getElementById("bulbimg3")
let bulbimg4 = document.getElementById("bulbimg4")
let bulbimg5 = document.getElementById("bulbimg5")
let current  = document.getElementById("current")
let i = 1


bulb.onclick = function () {

    switch (i) {
        case 1: bulbimg5.src = "img/bulboff.png"
                bulbimg1.src = "img/bulbon.png"
            current.innerHTML = "Current bulb 1"
            i++
            break;
        case 2: bulbimg1.src = "img/bulboff.png"
                bulbimg2.src = "img/bulbon.png"
            current.innerHTML = "Current bulb 2"
            i++
            break;
        case 3: bulbimg2.src = "img/bulboff.png"
                bulbimg3.src = "img/bulbon.png"
            current.innerHTML = "Current bulb 3"
            i++
            break;
        case 4: bulbimg3.src = "img/bulboff.png"
                bulbimg4.src = "img/bulbon.png"
                current.innerHTML = "Current bulb 4"
            i++
            break;
        case 5: bulbimg4.src = "img/bulboff.png"
                bulbimg5.src = "img/bulbon.png"
                current.innerHTML = "Current bulb 5"
            i = 0;
            break;
    }
}