
import React from 'react';

class Child extends React.Component{
    

    klick = (x) => {
        x.target.style.backgroundColor = "blue"
    }
    render(){
        return(
            <div className="child">
                {/* klassen child skriver ut värdet den fått tilldelat i pappaklassen */}
    <span>{this.props.name}</span>
    <button onClick={this.klick}>Click</button>
   
            </div>
        )
    }
}

class Papa03 extends React.Component{

    klick=(x)=>{
        x.target.style = "background-color: blue;"
    }

    render(){
        return(
            <div className="Papa">
                <h1>Papa</h1>
                <button onClick={this.klick}>papas</button>
                <Child name="ChildA" /> 
                {/* Klassen child tilldelas propen name med ett värde. Två childklasser får olika värden på sin name-prop */}
                <Child name="ChildB" />
            </div>
        )
    }
}

export default Papa03