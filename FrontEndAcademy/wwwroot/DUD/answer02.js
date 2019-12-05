function pickEverySecond(list) {
    let newList = []
    if (list == null) {
        return null
    }
    else
    {
        for (const e in list)
        {
            if (e % 2 == 1)
            {
                newList.push(list[e])
            }
        }
    }
 return newList   
}

//function pickEverySecond_withFilter(list) {
//    if (list == null)
//    {
//        return null
//    }
//    else
//    {
//        return list.filter((x,i) => i % 2 == 1)
//    }
//}


const pickEverySecond_withFilter = (list) => list == null ? null : list.filter((x, i) => i % 2 == 1)
      
  

// The same but shorter
function pickEverySecond_withFilter2(list) {

}   

// The same but with one line
function pickEverySecond_withFilter3(list) {

}   

function tellType(x) {
    if (typeof(x) == "undefined") { return "Not defined" }
    else if (typeof (x) == "number") {
        if (x < 100) {
            return `A number ${x}. Add ${100 - x} and you will get 100.`
        } else {
            return `A number ${x}. It is greater or equal to 100.`
        }
    }
    else if (typeof (x) == "boolean") {
        if (x)
        {
            return "It is true"
        }
        else
        {
             return "It is false"
        }
    }
    else if (typeof (x) == "string") {
        return "Just a string"
    }
}

function tellType_switch(x) {

    switch (typeof(x)) {
        case "number": return x < 100 ? `A number ${x}. Add ${100 - x} and you will get 100.` : `A number ${x}. It is greater or equal to 100.`
            break;
        case "string": return "Just a string"
            break;
        case "boolean": return x ? "It is true" : "It is false"
            break;
        case "undefined": return "Not defined"
            break;
    }
}

function tellType_withoutIfOrSwitch(x) {

    return typeof(x) == "string" ? "Just a string"
          : typeof (x) == "undefined" ? "Not defined" 
          
        : typeof (x) == "number" && x < 100 ? `A number ${x}. Add ${100 - x} and you will get 100.` 
        : typeof (x) == "number" && x >= 100 ? `A number ${x}. It is greater or equal to 100.`
        : typeof (x) == "boolean" && x == true ? "It is true" 
        : typeof (x) == "boolean" && x == false ? "It is false":""
}

function shoppinglist(arr) {
    let str = "TO BUY: ";
    if (arr.length == 0) {
        return "NOTHING TO BUY"
    }
    else 
    {
        for (const e of arr) {
            str = str + `* ${e.toUpperCase()} `
        }
    }
    let str1 =str.slice(0,str.length-1)
    return str1
}

function shoppinglist_map(arr) {
    let str = "TO BUY:"
    if (arr.length == 0)
    {
        return "NOTHING TO BUY"
    }
    else
    {
        arr.map(x =>
        {
            str += ` * ${x.toUpperCase()}`
        })
    }
    return str
}

const shoppinglist_oneline = (arr) => 
     arr.length == 0 ? "NOTHING TO BUY"
        : `TO BUY: ${arr.map(x => "* " + x.toUpperCase()).join(' ')}`

function createSequence(start, inc, numelements) {
    let newArr = []
    for (let i = start; i < start + numelements*inc; i+=inc) {
        newArr.push(i)
    }
    return newArr
}

function createSequence_while(start, inc, numelements) {
    let newArr = []
    let i = start
    while (start < i + numelements*inc) {
        newArr.push(start)
        start += inc
    }
    return newArr
}

function allNumbersEndWithZero(arr) {
    if (arr == null || arr.length == 0) {
        return null
    }
    return arr.every(x => x.toString().endsWith("0"))
}

const allNumbersEndWithZero_every = (arr) =>
     (arr == null || arr.length == 0) ? null : arr.every(x => x.toString().endsWith("0"))
