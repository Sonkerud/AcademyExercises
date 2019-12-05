import React from 'react'


class Basic07 extends React.Component {

    state = {counter: 42}
changeTo100 = () => {
    this.setState({counter:100})
}

render() {
return (<div>
    <div>{this.state.counter}</div>
    <button onClick={this.changeTo100}> Set to 100 </button>
    </div>)
}    
}

export default Basic07
