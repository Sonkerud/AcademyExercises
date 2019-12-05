//loop1()
//loop2()
//loop3()
//loop4()
//loop5()
//loop6()
loop7()

function loop1() {

    for (var i = 0; i < 19; i++) {
        console.log(i);
    }
}

function loop2() {
    for (var i = 0; i < 10; i++) {
        console.log(i);
    }
    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */
}

function loop3() {

    for (var i = 4; i < 9; i++) {
        console.log(`Siffran ${i} är tjusig`);
    }

    for (var i = 0; i < length; i++) {

    }
    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */

    /* Extra: använd en forloop för att skriva ut:
        "1:a"
        "2:a"
        "3:e"
        "4:e"
        "5:e"
        ...
        "99:e"
    */
}

function loop4() {
    i = 4;
    while (i <= 9) {
        console.log(i);
        i++
    }
}

function loop5() {

    importantYears = [1492, 1789, 1859, 1929]

    for (const element of importantYears) {
        console.log(`Året är ${element}`);
    }

    colors = ["blå", "röd", "grön", "gul", "lila"]

    for (const element of colors) {
        console.log(element);
    }
    
}

function loop6() {

    importantYears = [1492, 1789, 1859, 1929]
    let nr = 1;
    for (const element of importantYears) {

        console.log(`${nr}) ${element}`);
        nr++;
    }

    importantYears.forEach(element => console.log(element));

}

function loop7() {
    importantYears = [1492, 1789, 1859, 1929,88,93,2]

    for (const element of importantYears) {
        if (element < 1800) {
            console.log(element);
        }
        else if (element > 1800)
        {
            break;
        }
    }
    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */
}