dud.start(() => {


    dud.run({ multipleParameters:true},
        [
            {
                input: [
                    3,4
                ],
                expected: 7
            },
            {
                input: [
                    100,200
                ],
                expected: 300
            },
        ],
        addNumbers,

    );

    dud.render()

})
