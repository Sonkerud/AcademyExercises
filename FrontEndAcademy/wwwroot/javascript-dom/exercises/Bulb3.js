

let lampsArr = []

document.getElementById("number").onchange =  () => bulbs() ;



let cards = document.getElementById("cards")



function bulbs() {
 
    let number = document.getElementById("number").value
    if (number > 0 && number < 30) {
        clearScreen()
        buildAll(number)
        //buildButtons(number)
        //buildLamps(number)
    }
}

function clearScreen() {
    cards.innerHTML = "";
  
}


function buildButtons(number) {
    
        for (let i = 0; i < number; i++) {

            button = document.createElement('button');
            button.innerHTML = "Tryck"
            button.id = "buttonid" + i
            button.style = "width: 100px"
            button.onclick = () => { clickButton(i) }

            document.getElementById("cards").appendChild(button)  
        }
}
function buildLamps(number) {

        for (let i = 0; i < number; i++) {

            img = document.createElement('img')

            if (lampsArr[i] != null && lampsArr[i] == 1) {
                img.src = "img/bulbon.png";
                lampsArr[i] = 1

            } else {
                img.src = "img/bulboff.png";
                lampsArr[i] = 0;
            }
            img.style = "width:100px;"
            img.id = "imgid" + i
            cardBody = document.createElement("div")
            cardBody.style = "card-header"
            cardBody.id = "cardBody" + i
            document.getElementById("cards").appendChild(cardBody)
            document.getElementById("cardBody" + i).appendChild(img)
        }
}

function buildAll(number) {
    for (let i = 0; i < number; i++) {

        card = document.createElement("div")
        card.className = "card"
        card.id = "card" + i

        button = document.createElement('button');
        button.innerHTML = "Lampa " + (i+1)
        button.id = "buttonid" + i
        button.style = "width: 100px"
        button.className ="btn btn-primary"
        button.onclick = () => { clickButton(i) }
        let cardHead = document.createElement("div")
        cardHead.className = "card-header"
        cardHead.id = "cardHead" + i

        document.getElementById("cards").appendChild(card)
        document.getElementById("card"+i).appendChild(cardHead)     
        document.getElementById("cardHead" + i).appendChild(button)


        img = document.createElement('img')

        if (lampsArr[i] != null && lampsArr[i] == 1) {
            img.src = "img/bulbon.png";
            lampsArr[i] = 1

        } else {
            img.src = "img/bulboff.png";
            lampsArr[i] = 0;
        }
        img.style = "width:100px;"
        img.id = "imgid" + i
        cardBody = document.createElement("div")
   
        cardBody.className = "card-body"

        cardBody.id = "cardBody" + i
        document.getElementById("card"+i).appendChild(cardBody)
        document.getElementById("cardBody" + i).appendChild(img)
    }
}
function clickButton(i) {

    let img = document.getElementById(`imgid${i}`)
    if (img.src == "https://localhost:44387/javascript-dom/exercises/img/bulbon.png") {
        img.src = "img/bulboff.png"
        lampsArr[i] = 0
    } else if
        (img.src == "https://localhost:44387/javascript-dom/exercises/img/bulboff.png")
    {
        img.src = "img/bulbon.png"
        lampsArr[i] = 1
    }
}

