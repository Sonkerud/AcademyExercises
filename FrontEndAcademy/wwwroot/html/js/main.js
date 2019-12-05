var x = 0;
var onHeaderTextClick = document.getElementById("onclickHeader")
var onHeaderColorClick = document.getElementById("onclickHeaderColor")

onHeaderColorClick.addEventListener("click", changeHeaderColor)

function changeHeaderColor() {

    let y = document.getElementById("minRubrik").style;
    y.color === "red"?
    y.color = "green":
    y.color = "red";
    
    y.backgroundColor = "yellow";

}

onHeaderTextClick.onclick = function changeHeaderText() {
    let name = document.getElementById("firstName").value
    let y = document.getElementById("minRubrik");

    y.innerHTML === "Hej Hej rubrik!" ?
    y.innerHTML = name:
    y.innerHTML = "Hej Hej rubrik!";

    x++;
    document.getElementById("counter").innerHTML = x;
}
