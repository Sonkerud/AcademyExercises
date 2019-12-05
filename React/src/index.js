
import React from 'react';
import ReactDOM from 'react-dom';
import RedHeader from './basic/RedHeader'
import Basic01 from './basic/Basic01';
import Input from './basic/Input';
import Papa03 from './papa/Papa03';
import Papa04 from './papa/Papa04';


import './papa/Papa.css';
 



let el = <div><Papa03/><Papa03/><Papa04 name="Lisa"/><Papa04 name="Kalle"/></div>


ReactDOM.render(el, document.getElementById('root'));


