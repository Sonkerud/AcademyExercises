function red() {
    document.getElementById("boximg").src ="exercises/img/box1.png"
}

function green() {
    document.getElementById("boximg").src = "exercises/img/box2.png"
}

function blue() {
    document.getElementById("boximg").src = "exercises/img/box3.png"
}

function change() {
    console.log(document.getElementById("boximg1").src);
    if (document.getElementById("boximg1").src === "https://localhost:44387/javascript-dom/exercises/img/box1.png") {
        document.getElementById("boximg1").src = "https://localhost:44387/javascript-dom/exercises/img/box2.png"

    } else if (document.getElementById("boximg1").src === "https://localhost:44387/javascript-dom/exercises/img/box2.png") {
        document.getElementById("boximg1").src = "https://localhost:44387/javascript-dom/exercises/img/box3.png"
    } else if (document.getElementById("boximg1").src === "https://localhost:44387/javascript-dom/exercises/img/box3.png") {
        document.getElementById("boximg1").src = "https://localhost:44387/javascript-dom/exercises/img/box1.png"
    }
}

let c = 1;
function darker() {
    c += 0.1
    document.getElementById("box").style.backgroundColor = `rgba(255, 0, 0,${c})`;

}

function lighter() {
    c -= 0.1
    document.getElementById("box").style.backgroundColor = `rgba(255, 0, 0,${c})`;

}