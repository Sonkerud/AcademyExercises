
import React from 'react';

class Child extends React.Component{
    
    render(){
        return(
            <div>
                {/* klassen child skriver ut värdet den fått tilldelat i pappaklassen */}
    <h3>{this.props.name}</h3>
   

            </div>
        )
}
}

class Papa02 extends React.Component{
    render(){
        return(
            <div className="Papa">
                <h1>Papa</h1>
                <Child name="ChildA" /> 
                {/* Klassen child tilldelas propen name med ett värde. Två childklasser får olika värden på sin name-prop */}
                <Child name="ChildB" />
            </div>
        )
    }
}

export default Papa02