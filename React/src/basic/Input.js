import React from 'react'
import './style.css'
import RedHeader from './RedHeader'



class Input extends React.Component {
    
    state = {box1value: "Ingen bokstav",
             inputLetters: ""   
}

sendLetters = () => {
    return this.state.inputLetters;
}


onInputChange = (x) => {
    let box1letters = document.getElementById(`${x.target.id}`).value
    let countOfLetters = this.setNumberOfLetters(x.target.value.length)
    this.setState({box1value: countOfLetters}) 
    this.changeTextBoxes(x)
    this.printInputLetters(x)

}
printInputLetters=(x)=>{
    this.setState({inputLetters: x.target.value})
}


setNumberOfLetters=(x)=>{

    switch (x)
    {
        case 0: return "Ingen bokstav"
        case 1: return "En bokstav"
        case 2: return "Två bokstäver"
        default: return `${x} antal bokstäver` 
    }
}

changeTextBoxes = (x) => {

    let input = document.getElementById(x.target.id).value
    let reversed = input.split('').reverse().join('')   

    if (x.target.id === "box4") {

        document.getElementById("box1").value = reversed;
        document.getElementById("box2").value = reversed;
        document.getElementById("box3").value = reversed;
        document.getElementById("box5").value = reversed;

    }
    else 
    {
        for (let i = 1; i < 6; i++) {
            document.getElementById(`box${i}`).id === document.getElementById("box4").id
         ? document.getElementById(`box${i}`).value = reversed
         : document.getElementById(`box${i}`).value = input
     }

}}

render() {
return (<div>
    <input type="text" onKeyUp ={this.onInputChange} id="box3"></input>
    <input type="text" onKeyUp ={this.onInputChange} id="box2"></input>
    <input type="text" onKeyUp ={this.onInputChange} id="box1"></input>
    <input type="text" onKeyUp ={this.onInputChange} id="box4"></input>
    <input type="text" onKeyUp ={this.onInputChange} id="box5"></input>

<div><h3>Antal bokstäver: {this.state.box1value}</h3></div>
<div><RedHeader dataFromParent={this.state.inputLetters}/>
    </div>
<div><h2 id="redh2"> {this.state.inputLetters.toUpperCase()}</h2></div>


    </div>)
}    
}

export default Input