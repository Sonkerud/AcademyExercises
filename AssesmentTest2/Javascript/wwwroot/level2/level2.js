function lengthOfFirstMouse(str) {

    if (matchMouse(str)) {
        var result = lengthOfMouse(str)
        return result[0].length
    }

    else {

        return null;
    }

}
function matchMouse(str) {
   
    var patt = new RegExp(/~~\(_+\^·>+/g);
    var boolen = patt.test(str)
    return boolen;  
}
function lengthOfMouse(str) {
    var patt = /~~\(_+\^·>+/g;
    var result = str.match(patt);
    return result
}