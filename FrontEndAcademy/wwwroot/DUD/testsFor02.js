dud.start(() => {

    /* 
     
     Pick every second element from the list. 
     
     Extra: create one more solution that uses ".filter"

    */

    dud.run({},
        [
            {
                input: [1, 2, 3, 4],
                expected: [2, 4]
            },

            {
                input: ['A', 'B', 'C', 'D'],
                expected: ['B', 'D']
            },

            {
                input: ['A', 'B'],
                expected: ['B']
            },

            {
                input: [],
                expected: []
            },

            {
                input: null,
                expected: null
            }
        ],
        pickEverySecond,
        pickEverySecond_withFilter,

    );

    /*

    Tell the type of the parameter (string, number etc). Return a string as seen below

    Extra: create three solutions:
    - one with "if"
    - one with "switch"
    - one without "if", "switch" or "conditional if"

    */


    let anUndefinedValue

    dud.run({},
        [
            {
                input: 30,
                expected: "A number 30. Add 70 and you will get 100."
            },
            {
                input: 90,
                expected: "A number 90. Add 10 and you will get 100."
            },
            {
                input: 110,
                expected: "A number 110. It is greater or equal to 100."
            },
            {
                input: true,
                expected: "It is true"
            },
            {
                input: false,
                expected: "It is false"
            },
            {
                input: "Musse",
                expected: "Just a string"
            },
            {
                input: anUndefinedValue,
                expected: "Not defined"
            }
        ],
        tellType,
        tellType_switch,
        tellType_withoutIfOrSwitch
    );

    /*
    
    Create a shoppinglist from the inputed values as you see below.
    
    Extra: create two more solutions:
        one with "map" 
        one "oneliner"
    
    */

    dud.run({},
        [
            {
                input: ["Screw", "Hammer", "Wrench"],
                expected: "TO BUY: * SCREW * HAMMER * WRENCH"
            },

            {
                input: ["Screw", "Hammer"],
                expected: "TO BUY: * SCREW * HAMMER"
            },

            {
                input: ["Screw"],
                expected: "TO BUY: * SCREW"
            },

            {
                input: [],
                expected: "NOTHING TO BUY"
            }
        ],
        shoppinglist,
        shoppinglist_map,
        shoppinglist_oneline
    );

    /*
    
    Create a sequence with a startvalue and some settings. See the examples
    
    Extra: create two solutions, one with "for" and one with "while"
    
    */

    dud.run({ multipleParameters: true },
        [
            /* Start with 10. Increase 2 each time. End when you have 5 element.*/
            {
                input: [
                    10,
                    2,
                    5
                ],
                expected: [
                    10,
                    12,
                    14,
                    16,
                    18
                ]
            },
            /* Start with 98. Increase 1 each time. End when you have 7 element.*/
            {
                input: [
                    98,
                    1,
                    7
                ],
                expected: [98, 99, 100, 101, 102, 103, 104]
            },
            /* I don't want any elements.*/
            {
                input: [
                    98,
                    1,
                    0
                ],
                expected: []
            }
        ],
        createSequence,
        createSequence_while
    );


    /*
        Check if all numbers in the list ends with zero

        Extra: create two solutions, one should use ".every"

    */

    dud.run({},
        [
            {
                input: [
                    10,
                    50,
                    30
                ],
                expected: true
            },
            {
                input: [
                    50,
                    30
                ],
                expected: true
            },
            {
                input: [
                    30
                ],
                expected: true
            },
            {
                input: [
                    12,
                    50,
                    30
                ],
                expected: false
            },
            {
                input: [
                    10,
                    51,
                    30
                ],
                expected: false
            },
            {
                input: [
                    0
                ],
                expected: true
            },
            {
                input: [
                ],
                expected: null
            },
            {
                input: null,
                expected: null
            },
        ],
        allNumbersEndWithZero,
        allNumbersEndWithZero_every,

    );

    dud.render()

})
