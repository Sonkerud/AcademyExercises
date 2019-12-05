// Alla dessa är extrauppgifter

dud.start(() => {

    /*

    Create a method "createPerson" that returns a person as a object. Some of the properties should be calculated. See below

    */

    dud.runfun("createPerson", (f) => {

        let person = f("Johan", "Rheborg", ['Percy Nilegård', 'Farbror Barbro', 'Kenny Starfighter'])

        dud.assert("Johan", person.firstName)
        dud.assert("Rheborg", person.lastName)

        dud.assert(['Percy Nilegård', 'Farbror Barbro', 'Kenny Starfighter'], person.characters)
        dud.assert("Johan Rheborg", person.fullName())
        dud.assert(3, person.numberOfRoles())

        person.firstName = "A"
        person.lastName = "B"
        person.characters = ['X', 'Y']

        dud.assert("A", person.firstName)
        dud.assert("B", person.lastName)
        dud.assert(['X', 'Y'], person.characters)
        dud.assert("A B", person.fullName())
        dud.assert(2, person.numberOfRoles())

    },
        createPerson,
    );

    /*

    Same as above, but use "getter". 

    Notice that "fullName" and "numberOfRoles" is called different than above.

    */

    dud.runfun("createPersonGetter", (f) => {

        let person = f("Johan", "Rheborg", ['Percy Nilegård', 'Farbror Barbro', 'Kenny Starfighter'])

        dud.assert("Johan", person.firstName)
        dud.assert("Rheborg", person.lastName)

        dud.assert(['Percy Nilegård', 'Farbror Barbro', 'Kenny Starfighter'], person.characters)
        dud.assert("Johan Rheborg", person.fullName)
        dud.assert(3, person.numberOfRoles)

        person.firstName = "A"
        person.lastName = "B"
        person.characters = ['X', 'Y']

        dud.assert("A", person.firstName)
        dud.assert("B", person.lastName)
        dud.assert(['X', 'Y'], person.characters)
        dud.assert("A B", person.fullName)
        dud.assert(2, person.numberOfRoles)

    },
        createPersonGetter,
    );


    /* 
     
     Add 10 minutes to the time passed in to the method. Return a formatted as seen below 
     
     */

    dud.run({ multipleParameters: true },
        [
            // Add ten minutes to "2019-05-31 23:55"
            {
                input: [
                    2019,
                    5,
                    31,
                    23,
                    55
                ],
                expected: "2019-06-01 00:05"
            },
            // Add ten minutes to "2019-05-31 20:00"
            {
                input: [
                    2019,
                    5,
                    31,
                    20,
                    0
                ],
                expected: "2019-05-31 20:10"
            },
            // Add ten minutes to "2019-05-31 19:58"
            {
                input: [
                    2019,
                    5,
                    31,
                    19,
                    58
                ],
                expected: "2019-05-31 20:08"
            },
            // Add ten minutes to "2019-01-01 00:01"
            {
                input: [
                    2019,
                    1,
                    1,
                    0,
                    1
                ],
                expected: "2019-01-01 00:11"
            },
            // Add ten minutes to "2018-12-31 23:57"
            {
                input: [
                    2018,
                    12,
                    31,
                    23,
                    57
                ],
                expected: "2019-01-01 00:07"
            }
        ],
        addTenMinutes
    );

    /* 
     
    Add numbers from outside to in.  
    
    Extra: create two solution where one is using "recursion" (without any loop)

    */

    dud.run({},
        [

            {
                input: [5, 8, 2, 11],
                expected: [16, 10]       // 5+11, 8+2
            },

            {
                input: [1, 2, 3, 4, 5],
                expected: [6, 6, 3]       // 1+5, 2+4, 3
            },


            {
                input: [5, 8, 2],
                expected: [7, 8]
            },

            {
                input: [5, 8],
                expected: [13]
            },

            {
                input: [5],
                expected: [5]
            },
            {
                input: [],
                expected: []
            }
        ],
        addFromEdges,
        //addFromEdges_recursive,

    );

    /* 
    
    Get the elements nearby a position so the following tests will pass

    Return null if the function is called in wrong way

    */

    dud.run({ multipleParameters: true },
        [
            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    4
                ],
                expected: ['c', 'd', 'e']
            },

            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    5
                ],
                expected: ['d', 'e']
            },

            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    1
                ],
                expected: ['a', 'b']
            },

            {
                input: [
                    ['a', 'b'],
                    1
                ],
                expected: ['a', 'b']
            },

            {
                input: [
                    ['a', 'b'],
                    2
                ],
                expected: ['a', 'b']
            },

            {
                input: [
                    ['a'],
                    1
                ],
                expected: ['a']
            },

            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    6
                ],
                expected: null
            },

            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    0
                ],
                expected: null
            },

            {
                input: [
                    ['a', 'b', 'c', 'd', 'e'],
                    -3
                ],
                expected: null
            }
        ],

        nearbyElement,
    );

    dud.render()

})
