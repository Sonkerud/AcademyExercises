import React from 'react';

class Papa04 extends React.Component {

state = {lightup:false,
            counter: 100
}
setCounter= (x) => {
    this.setState({counter: x})
}

addTen = (x) => {
    
    this.setState({counter: (this.state.counter + x )})
}

toggleHeader = () => {
    this.setState((x) => {
        return {lightup: !x.lightup}
    })
}

    render(){
        return(
            <div style={{border:"solid 5px", margin:"10px", borderColor: this.state.lightup ? "green": "red"}}>
                <h3>{this.props.name}</h3>
        <h3>{this.state.lightup ? "Ja": "Nej"}</h3>
        
        <h3 style={{color:"blue"}}> BLÅ TEXT</h3>
        <h3 style={{color:this.state.lightup ? "green" : "red"}}> TEXT</h3>

        <p>Räknare: {this.state.counter}</p>
        {this.state.counter > 600 &&
        <div style={{borde:"solid 1px", padding:"20px"}}> Visas bara om räknaren är över 600</div>
        }

        <button onClick ={this.toggleHeader}>Toggle Header</button>
        <button onClick ={() => this.setCounter(555)}>Sätt räknare till 555</button>
        <button onClick ={() => this.addTen(30)}>Addera 10</button>
        <button onClick ={() => {this.addTen(30); this.toggleHeader()}}>Addera 10 och toggla</button>

        
        </div>
            
        )
    }
}

export default Papa04
