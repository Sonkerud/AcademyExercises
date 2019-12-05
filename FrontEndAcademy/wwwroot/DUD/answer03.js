
function createPerson(f, l, c) {
    
    return {
        firstName: f,
        lastName: l,
        characters: c,
        fullName() { return `${this.firstName} ${this.lastName}` },
        numberOfRoles() { return this.characters.length}
        
    }
}

function createPersonGetter(f, l, c) {
    return {
        firstName: f,
        lastName: l,
        characters: c,
        get fullName() {
            return this.firstName + ' ' + this.lastName
        },

        //set fullName(name) {
        //    var words = name.toString().split(' ');
        //    this.firstName = words[0] || '';
        //    this.lastName = words[1] || '';
        //},

        get numberOfRoles() {
            return this.characters.length
        }
    }
}


function addTenMinutes(year, month, day, hour, minutes) {
    let newMonth = 0;
    let newMinutes = 0;

   
    if (minutes < 50) {
        newMinutes = minutes + 10
        return `${year}-${newMonth}-${day} ${hour}:${newMinutes}`
    } 
    if (month < 10) {
       newMonth = 0 + month
    }
    
    let output = `${year}-${newMonth}-${day} ${hour}:${newMinutes}`

    return output
}

function addFromEdges(list) {
    let newArr = []
    if (list.length === 0 || list.length === 1) {
        return list
    }
    else if (list.length % 2 === 0) {
        for (let i = 0; i < list.length / 2; i++) {
            newArr.push(list[i] + list[list.length - 1 - i])
        }
        return newArr
    }
    else {
        for (let i = 0; i < (list.length-1) /2 ; i++) {
            newArr.push(list[i] + list[list.length - 1 - i])
        }
            newArr.push(list[(list.length-1)/2])
        return newArr
    }
}

function addFromEdges_recursive(list) {
}

function nearbyElement(list, index) {
    let newArr = []

    if (index < 1 || index === null || index > list.length) {
        return null
    }
    else if (list.length < 4) {
       return list
    }
    else if (index === 1 && list.length > 1) {
        newArr.push(list[0])
        newArr.push(list[1])
        return newArr
    }
     else if (index === list.length) {
        newArr.push(list[index - 2])
        newArr.push(list[index - 1])
        return newArr
     }
     else if (list[index - 2] !== null && list[index] !== null) {
       newArr.push(list[index-2])
       newArr.push(list[index-1])
       newArr.push(list[index])
       return newArr
     }
}





