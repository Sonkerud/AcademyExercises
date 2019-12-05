//fun1()
//fun2()
//fun3()
//fun4()
//extraFun1()
//extraFun2()
//extraFun3()
extraFun4()


function sayHi() {
    let s = "-";
   let b = s.padStart(8,"-")
    console.log(b);
    console.log(b+" VÄLKOMMEN");
    console.log(b);

}
function sayHiTo(name) {
    let s = "-";
    let b = s.padStart(8, "-")
    console.log(b);
    console.log(b + " " + name);
    console.log(b);

}
function fun1() {
    sayHi()
    //sayHi()

    /*
        Gör en metod "sayHi". Anropa den två gånger
    
        sayHi()
        sayHi()

    Detta ska skrivas ut:

    --------
    -------- VÄLKOMMEN 
    --------

    --------
    -------- VÄLKOMMEN 
    --------

    */

  
}

function fun2() {


    /*
    Liknande som sist men gör en metod sayHiTo() som tar ett namn som inparameter.

    Ex sayHiTo("Oscar") ska skriva ut:

    --------
    -------- VÄLKOMMEN OSCAR
    --------

    */

    sayHiTo('Oscar');
}

function fun3() {

    function myndig(name,age) {
         console.log(age < 18 ? name + " är inte myndig!" : name + " är myndig!")
    }
    /*
    Gör en metod "myndig" med två parameterar "name" och "age". Anropa den tre gånger
    
        myndig("Peter", 16);
        myndig("Lisa", 26);
        myndig("Ragnar", 15);

    Detta ska skrivas ut:

        Obs! Peter är inte myndig!
        Lisa är myndig
        Obs! Ragnar är inte myndig!
    */

    myndig("Peter", 16);
    myndig("Lisa", 26);
    myndig("Ragnar", 15);

}

function fun4() {
    function skrivUtMoms(price) {
        console.log(`Momsen för varan är ${price * 0.25}`);
    }
    /*
    Gör en metoden "skrivUtMoms" som tar "price" som inparameter.
    Om du t.ex anropas metoden såhär:

        skrivUtMoms(1000)

    ...så ska detta skrivas ut:

        Momsen för varan är 250kr

    */

    skrivUtMoms(1000);
    skrivUtMoms(400);
}

// -------- EXTRA UPPGIFTER -----------------------------------------


function extraFun1() {

    function recept(recipeName, ingredients) {
        console.log(`För att göra  ${recipeName} behövs:`);
        ingredients.forEach(x => console.log(`*${x.toUpperCase()}`))  

    }

    /*

    Gör en metod "recept" med en parameter "recipeName" och "ingredients". Anropa den:
    
        recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
        recept("Rotmos", ["Potatis", "Kålrot"]);

    Detta ska skrivas ut:

        FÖR ATT GÖRA ÄPPLEKAKA BEHÖVS:
        * ÄPPLE
        * MJÖL
        * KANEL

        FÖR ATT GÖRA ROTMOS BEHÖVS:
        * POTATIS
        * KÅLROT
    */

    recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
    recept("Rotmos", ["Potatis", "Kålrot"]);
}

function extraFun2() {

    function skrivUtMoms(vara,price) {
        if (vara === "tidning" || vara === "flyg") {
            console.log(`Momsen för en ${vara} är ${price * 0.06}`);
        } else if (vara === "restaurangbesök") {
            console.log(`Momsen för en ${vara} är ${price * 0.12}`);
        } else {
            console.log(`Momsen för en ${vara} är ${price * 0.25}`);

        }
    }
    /*

    I sverige finns tre momssatser: 25%, 12% och 6%. Se här:
    https://www.verksamt.se/starta/skatter-och-avgifter/moms/olika-momssatser

    Skriv en metod "skrivUtMoms" som beräknar moms på en vara utifrån vilken typ av vara det är

    Dessa anrop:

        skrivUtMoms("tidning", 1000);
        skrivUtMoms("restaurangbesök", 1000);
        skrivUtMoms("flyg", 1000);
        skrivUtMoms("falafel", 1000);
        skrivUtMoms("hipsteröl", 1000);

    Ska ge svaren:

        Momsen för en/ett tidning som kostar 1000kr är 60kr
        Momsen för en/ett restaurangbesök som kostar 1000kr är 120kr
        Momsen för en/ett flyg som kostar 1000kr är 60kr
        Momsen för en/ett falafel som kostar 1000kr är 250kr
        Momsen för en/ett hipsteröl som kostar 1000kr är 250kr

    */

    skrivUtMoms("tidning", 1000);
    skrivUtMoms("restaurangbesök", 1000);
    skrivUtMoms("flyg", 1000);
    skrivUtMoms("falafel", 1000);
    skrivUtMoms("hipsteröl", 1000);

}

function extraFun3() {


    function skrivUtMoms(vara, price) {
        if (vara === "tidning" || vara === "flyg") {
            console.log(`Momsen för  ${enEtt(vara)} ${vara} är ${price * 0.06}`);
        } else if (vara === "restaurangbesök") {
            console.log(`Momsen för  ${enEtt(vara)} ${vara} är ${price * 0.12}`);
        } else {
            console.log(`Momsen för ${enEtt(vara)} ${vara} är ${price * 0.25}`);

        }
    }

    function enEtt(ord) {
        if (ord === "restaurangbesök" || ord === "flyg") {
            return "ett"
        } else {
            return "en"
        }
       
    }

    /*

        Modifiera "skrivUtMoms" så funktionen tar hänsyn till om ordet innan ska vara "en" eller "ett":

            Momsen för en tidning som kostar 1000kr är 60kr
            Momsen för ett restaurangbesök som kostar 1000kr är 120kr
            Momsen för ett flyg som kostar 1000kr är 60kr
            Momsen för en falafel som kostar 1000kr är 250kr
            Momsen för en hipsteröl som kostar 1000kr är 250kr

        Tips: skriv en ny metod:

            function enEtt(word) {
            }

        ...som utifrån ord returnerar "en" eller "ett" (eller "en/ett" om ordet inte finns i ordlistan) 

    */

    skrivUtMoms("tidning", 1000);
    skrivUtMoms("restaurangbesök", 1000);
    skrivUtMoms("flyg", 1000);
    skrivUtMoms("falafel", 1000);
    skrivUtMoms("hipsteröl", 1000);

}

function extraFun4() {
    /*
     Skriv om enEtt-funktionen ovan men använd "Set". Alltså 

        let xxx = new Set()
    
    Vad kan poängen vara att använda Set?

     */

    new Set([it])
    let en = new set("tidning","apa")
    let ett = new set("restaurangbesök")

    function enEtt(word) {
        return en.has(word) ? "en" : "ett" 
    }

    console.log(enEtt("tidning"));
    console.log(enEtt("restaurangbesök"));
    console.log(enEtt("apa"));

}