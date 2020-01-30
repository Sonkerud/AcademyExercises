dud.start(() => {

    /*
     Create a method "addOrSubtract" that takes three parameters:
     - a string
     - a number
     - a number

     If the first parameter is "plus" then return the numbers added.
     If the first parameter is "minus" then return the numbers subtracted.
     If the first parameter is something else then just return null
     */

    dud.run({ multipleParameters: true },
        [
            {
                input: [
                    "plus", 4, 5
                ],
                expected: 9
            },
            {
                input: [
                    "plus", 102, 405
                ],
                expected: 507
            },
            {
                input: [
                    "minus", 10, 3
                ],
                expected: 7
            },
            {
                input: [
                    "minus", 2, 10
                ],
                expected: -8
            },
            // If first parameter is something else than "minus" or "plus" 
            // then just return null 
            {
                input: [
                    "zzzzzzzz", 2, 10
                ],
                expected: null
            },
            {
                input: [
                    "wwwwwww", 5, 3
                ],
                expected: null
            },
        ],
        addOrSubtract,

    );

    /*
     Create a function "elementAndNext" that takes two arguments:
    
     - an array
     - an index
    
     The function should return the element at the index
     and the element after (if it exist).
    
     */

    dud.run({ multipleParameters: true },
        [
            {
                input: [
                    ["a", "b", "c", "d", "e", "f"], 3
                ],
                expected: ["d", "e"]
            },
            {
                input: [
                    ["a", "b", "c", "d", "e", "f"], 0
                ],
                expected: ["a", "b"]
            },
            {
                input: [
                    ["a", "b", "c", "d", "e", "f"], 4
                ],
                expected: ["e", "f"]
            },
            {
                input: [
                    ["a", "b", "c", "d", "e", "f"], 5
                ],
                expected: ["f"]  // index 5 don't have any element after so we just return ["f"]
            },
            {
                input: [
                    ["X", "Y", "Z"], 0
                ],
                expected: ["X", "Y"]
            },
            {
                input: [
                    ["X", "Y", "Z"], 1
                ],
                expected: ["Y", "Z"]
            },
            {
                input: [
                    ["X", "Y", "Z"], 2
                ],
                expected: ["Z"]
            },
        ],
        elementAndNext,

    );

    dud.render()

})
