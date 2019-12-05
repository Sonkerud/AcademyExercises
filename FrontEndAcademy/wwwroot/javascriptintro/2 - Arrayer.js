//arr1()
//arr2()
//arr3()
//arr4()
//arr5()
//arr6()
//arr7()
arr8()



function arr1() {

    arr1 = ["Stockholm", "Göteborg", "New York"];

    console.log(arr1[0]);
    console.log(arr1[1]);
    console.log(arr1[2]);
    console.log(arr1[3]);
    console.log(arr1[1]);
    console.log(arr1[1]);
    console.log(`${arr1[1]}${arr1[0]}`);

}

function arr2() {

    arr2 = ["Stockholm", "Göteborg", "New York"]
    arr2.push("Krakow");
    arr2.push("Hudik");
    arr2.push("Borlänge");
    console.log(arr2[3]);
    console.log(arr2[5]);
}


function arr3() {
    arr3 = ["Stockholm", "Göteborg", "New York"]
    arr3.push("Krakow")
    arr3.push("Berlin")
    console.log(arr3.length);
    console.log(`Mina favoritstäder är ${arr3[1]} och ${arr3[3]}`);

}

function arr4() {

    arr4 = ["Stockholm", "Göteborg", "New York"]
    poppedcity = arr4.pop()
    console.log(poppedcity);
    console.log(arr4.length);
 

    /*
	    Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Använd "pop" för att plocka ut den sista staden och placera i en variabel "poppedCity"
	    Skriv ut längen av listan (2)
	    Skriv ut den poppade staden (New York)
	    Använd cities.length för att plocka ut det sista elementet i listan (Göteborg)
    */
}

function arr5() {
    numbers = [5, 66, 777, 12]
    console.log(numbers.length);
    console.log(numbers[2]);

}

function arr6() {
    numbers = [5, 66, 777, 12]
    numbers.sort()
    console.log(numbers);
    numbers.sort((a, b) => a - b);
    console.log(numbers);
  
}

function arr7() {
    numbers = [5, 66, 777, 12]
    numbers.sort()
    console.log(numbers);
    numbers.sort((a, b) => b - a);
    console.log(numbers);
}

function arr8() {
    numbers = [5, 66, 777, 12]
    numbers.reverse();
    console.log(numbers);
}