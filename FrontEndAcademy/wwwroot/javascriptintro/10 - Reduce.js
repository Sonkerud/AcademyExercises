//reduce1()
//reduce2()
reduce3()

function reduce1() {
    const data = [5, 10, 15, 20, 25];
    //data.reduce((a,b) => a+=b )
    // Använd "reduce" för att summera alla tal i arrayen (till 75)
    console.log(data.reduce((a, b) => a += b));
}

function reduce2() {

    // Använd "reduce" för att platta till arrayen 
    // Alltså ge [1, 2, 3, 4, 5, 6, 7, 8, 9]

    const data = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    
    console.log(data.flat());

    arrays = data.reduce((a, b) => a.concat(b), []);

    console.log(arrays);
}

function reduce3() {

    let ages = [{ age: 22 }, { age: 43 }, { age: 8 }]

    const maxAge = (a,b) => a > b ? a : b

        //function maxAge({age}) {

        //}

    // Skapa metoden "maxAge" så följande ger siffran 43

    //ages.reduce(maxAge, 0);
    console.log(ages.reduce(maxAge, 0));
}

function reduce4() {
    let names = ['Alice', 'Bob', 'Tiff', 'Bruce', 'Alice', 'Bob', 'Bob'];

    // Skapa metoden "countNames" där detta:

    let y = countNames(names)

    // ...ska leda till att y blir 
    // {Alice: 2, Bob: 3, Tiff: 1, Bruce: 1}


}

function reduce5() {
    let names = ['Alice', 'Bob', 'Leif'];

    combine(names)

    // Skapa metoden "combine"
    // Används "reduce"
    // Ska returnera "ALICEBOBLEIF"
}

function reduce6() {
    let names = ['Alice', 'Bob', 'Leif'];

    reverse(names)

    // Skapa metoden "reverse" som vänder på en array
    // Används "reduce"
    // Ska returnera ['Leif', 'Bob', 'Alice' ]
}


function reduce7() {
    let names = ['Alice', 'Ababababa', 'Bob', 'Leif', 'Abcdefg'];

    // Skapa metoden "countLongWords" som räknar antalet ord som har 6 eller fler tecken
    // Använd "reduce"

    countLongWords(names)
}