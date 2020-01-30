dud.start(() => {

    /*

        Create a function that returns the length of the first mouse in a string
        If no mice is found the return null

        The smallest mouse looks like this:
        
              ~~(_^·>
    
        A mouse can by longer by adding more underlines, like this:

              ~~(___________________________^·>

        If any part of the mouse is missing then it's no mouse.

        If two (or more) mice is found, just return the length of the first


     */
    dud.run({},
        [
            {
                input:"~~(_^·>",
                expected: 7
            },
            {
                input: "~~(__^·>",
                expected: 8
            },
            {
                input: "~~(___^·>",
                expected: 9
            },
            {
                input: "aaa~~(___^·>bbbbbbbbbb",
                expected: 9
            }
            ,
            {
                input: "qwerty~~(___^·>asdfgghj",
                expected: 9
            },
            // here there are two mice but just return the length of the first mouse
            {
                input: "xxx~~(___^·>yyyyyy~~(_^·>zzzzzzz",
                expected: 9
            },
            // the following are examples of non-mice. so just return null
            {
                input: "~~(^·>",
                expected: null
            },
            {
                input: "~(___^·>",
                expected: null
            },
            {
                input: "~~(___·>",
                expected: null
            },
            {
                input: "~~(___^·",
                expected: null
            },
            {
                input: "~~((___^·>",
                expected: null
            },
            {
                input: "~~(___^··>",
                expected: null
            },
            {
                input: "~~(___^^·>",
                expected: null
            },
            
        ],
        lengthOfFirstMouse,

    );

    dud.render()

})
