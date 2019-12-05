//obj1()
//obj2()
//obj3()


let paintings = [
    {
        name: "Mona Lisa",
        artist: "Leo",
        year: "1530"
    },
    {
        name: "Madonna on the Rocks",
        artist: "Michi",
        year: "1540"
    },
    {
        name: "Charlie",
        artist: "P.Sonerud",
        year: "2002"
    }]
//obj3()
obj4()

function obj1() {
    let person = {
        firstName: 'Johan',
        lastName: "Rheborg",
        birthYear: 1960
    }

  
    console.log(person.firstName);
    console.log(`${person.firstName} ${person.lastName}`);


    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */

}

function obj2() {

    let person = {
        firstName: 'Johan',
        lastName: "Rheborg",
        birthYear: 1960,
        roles: ["Percy", "Barbro"],
        Adress: {
            street: "Gatvägen 1",
            city: "Hudiksvall"           
        }
    }
    console.log(`${person.firstName} är född år ${person.birthYear}`);
    console.log(`${person.firstName} bor på ${person.adress.street}`);


    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer till objektet "person" (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)

       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */
}


function obj3() {
    

    //console.log(paintings.length);
    //console.log(`${paintings[2].artist} målade ${paintings[2].name} år ${paintings[2].year}`);
    console.log("_".padEnd(50,"_"));
    for (const element of paintings) {
        var x = `|${element.artist} målade ${element.name} år ${element.year}`;
        console.log(x.padEnd(50,'|'));
    }
    console.log("_".padEnd(50, "_"));

    for (const element of paintings) {
        console.table(element)
    }
    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns 3st målningar i arrayen"
       Skriv ut info om den tredje målningen: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */

}

function obj4() {
    
    
    let skriet = {
        name: "Skriet",
        artist: "Edward Munch",
        year: 1893
    }
    paintings.push(skriet)


    console.log(paintings.indexOf());
    let x = paintings.findIndex(x => x.year === 1893);
    console.log(x);
    console.log(paintings[x]);

   
    paintings.pop()
    paintings.pop()
    paintings.pop()

   // console.log(paintings.length);

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i "paintings" mha "push".
       Skriv ut dess år mha variablen "paintings" (alltså 1893) 
       Använd "pop" flera gånger för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */
}
