function addOrSubtract(command, a, b) {
    if (command !== "plus" && command !== "minus") {
        return null
    } else {
       return command === "plus" ? a+b : a-b
    }
}

function elementAndNext(arr, index) {
    if (arr.length - 1 === index) {
        return [arr[arr.length - 1]]
    } else  {
        return [arr[index], arr[index+1]]
    }
}


