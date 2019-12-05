
box1 = document.getElementById("box1")
box2 = document.getElementById("box2")
box3 = document.getElementById("box3")
box4 = document.getElementById("box4")
box5 = document.getElementById("box5")

box1.onkeyup = () => boxUpdater(box1)
box2.onkeyup = () => boxUpdater(box2)
box3.onkeyup = () => boxUpdater(box3)
box4.onkeyup = () => boxUpdater(box4)
box5.onkeyup = () => boxUpdater(box5)

let boxArr = [box1,box2,box3,box4,box5]

function boxUpdater(box) {

    if (box.id === box4.id) {
        box1.value = reverseString(box.value)
        box2.value = reverseString(box.value)
        box3.value = reverseString(box.value)
        box5.value = reverseString(box.value)
    }
    else {
           for (let i = 0; i < boxArr.length; i++) {
              boxArr[i].id === box4.id
            ? boxArr[i].value = reverseString(box.value)
            : boxArr[i].value = box.value
        }
    }
}
    
function reverseString(str) {
    return str.split("").reverse().join("");
}
