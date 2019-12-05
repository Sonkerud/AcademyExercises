function starify(str) {
    let x = []
  
    for (let i = 0; i < str.length; i++) {
        let c = str[i]
        x[i] = "*" + c + "*"
    }
    return x
}


    function starify_forIn(str) {
        let x = []
        for (const c in str) {
            x.push("*" + str[c] + "*")
        }
        console.log(x);
        return x
}

    function starify_forOf(str) {
    let x = []
    for (const e of str) {
        x.push("*" + e + "*")
    }
    return x
    }

function starify_map(str) {
   // let x = []
    let arr = [...str]
    return arr.map(x => `*${x}*`)
}

function addOneToEachNumber(x) {
    let y = []

    if (x === null) {
        return null
    }
    else if (x === []) {
        return []
    }
    else
    {
        for (let i = 0; i < x.length; i++) {
            y[i] = x[i] +1
        }
    }
    return y
}


//const addOneToEachNumber = x => x === null ? null : x.forEach(x => x +1) 

function addOneToEachNumber_map(x) {
    if (x === null) {
      return null
    }
    else {
        let arr = [...x]

       return arr.map(x => x + 1)
    }
}

function putTheLastElementFirst(arr) {
    if (arr.length != 0)
    {
        arr.unshift(arr.pop())
        return arr
    }
    else
    {
        return arr
    }
}

function putTheLastElementFirst_pop(arr) {
    if (arr.length != 0) {
         arr.unshift(arr.pop())
        return arr
    }
    else {
        return arr
    }
}

function supersum(x, y) {

    let nr = 0
    for (let i = 2; i < arguments.length; i++) {
        nr += arguments[i]
    }
    if (arguments.length <= 2) {
        return `${x}${y}`
    } else {
        return `${x}${nr}${y}`
    }
}

function supersum_spread(x, y, ...arr) {
    
    let nr = 0;
    for (const e of arr) {
        nr += e
    }
    if (arguments.length <= 2) {
        return `${x}${y}`
    }
    return `${x}${nr}${y}`
}

function supersum_spread_reduce(x, y, ...arr) {
    if (arguments.length <= 2) {
        return `${x}${y}`
    }
        return `${x}${arr.reduce((a, b) => a + b,0)}${y}`
}


function someUpperCase(wordList, upperList) {
    let output = []
    if (wordList == null || upperList == null) {
        return null
    }
    else if (wordList.length == 0 || upperList.length == 0) {
        return null
    }
    else if (wordList.some(x => x == null) || upperList.some(x => x == null)) {
        return null
    }
    else if (wordList.length !== upperList.length) {
        return null
    }
    else {
        for (let i = 0; i < wordList.length; i++) {
            if (upperList[i]) {
                output[i] = wordList[i].toUpperCase()
            } else {
                output[i] = wordList[i].toLowerCase()
            }
        }
    }
    return output
}


function someUpperCase_forIn(wordList, upperList) {
    let output = []
    if (wordList == null || upperList == null) {
        return null
    }
    else if (wordList.length == 0 || upperList.length == 0) {
        return null
    }
    else if (wordList.some(x => x == null) || upperList.some(x => x == null)) {
        return null
    }
    else if (wordList.length !== upperList.length) {
        return null
    } else {

    }
}

function someUpperCase_map(wordList, upperList) {

    let output = []
    if (wordList == null || upperList == null || wordList.length !== upperList.length)
    {
        return null
    }
    else {
        output = wordList.map((v, i) => 
            upperList[i] ? 
            v.toUpperCase()
            : v.toLowerCase())
    }
 
    return output
}

function someUpperCase_map2(wordList, upperList) {
}