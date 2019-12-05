import React from 'react'
import './style.css'
import Input from './Input'

class RedHeader extends React.Component {
    

    render(){
        return (
            
        <div><h2 id="redh2">{this.props.dataFromParent}</h2></div> 
            )
    }
}



export default RedHeader