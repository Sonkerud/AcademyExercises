dud.start(() => {


    dud.run({ multipleParameters: true },
        [
            {
                input: [
                    3, 4
                ],
                expected: 12
            },
            {
                input: [
                    4, 8
                ],
                expected: 32
            },
        ],
        multiply,

    );

    dud.render()

})
