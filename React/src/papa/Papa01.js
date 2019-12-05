
import React from 'react';

class ChildA extends React.Component {
    render(){
        return(
            <div>
                <h3>ChildA</h3>
            </div>
        )
    }
}

class ChildB extends React.Component{
    render(){
        return (
            <div>
            <h3>ChildB</h3>
            </div>
        )
    }
}

class Papa01 extends React.Component{
    render(){
        return(
            <div className="Papa">
                <h1>Papa</h1>
                <ChildA />
                <ChildB />
            </div>
        )
    }
}

export default Papa01