let dud = (function () {

    let result = []

    let viewFailedTestInConsole = false

    function start(fun) {
        try {
            document.getElementById("dud-result").innerHTML = "";
            fun()
        } catch (ex) {
            document.getElementById("dud-result").innerHTML = "<div class='dud-error'>Unexpected error in tests. Look at console window</div>";
            console.error(ex)
        }
    }

    function fail(testname, input, expected, actual, f) {

        if (!result[testname]) result[testname] = []

        let funname = f ? f.name : "not-known"

        result[testname].push({ state: 'fail', testname, input, expected, actual, funname })
    }

    function success(testname, input, expected, actual, f) {

        if (!result[testname]) result[testname] = []

        let funname = f ? f.name : "not-known"

        result[testname].push({ state: 'success', testname: testname, input: input, expected, actual, funname })
    }

    function hasSameArrayContent(a, b) {
        if (!Array.isArray(a) || !Array.isArray(b))
            return false

        if (a.length !== b.length)
            return false

        for (let i = 0; i < a.length; i++) {
            if (a[i] !== b[i]) {
                return false;
            }
        }
        return true
    }

    function extend(obj, src) {
        Object.keys(src).forEach(function (key) { obj[key] = src[key]; });
        return obj;
    }

    function clone(x) {
        if (Array.isArray(x))
            return x.slice(0)
        else
            return x
    }

    function run(override, inout, ...testmethods) {
        // todo: validera indata

        let defaultSettings = {
            multipleParameters: false,
            testname: testmethods[0].name
        }

        let settings = extend(defaultSettings, override)

        let testname = settings.testname

        for (let x of inout) {
            for (let f of testmethods) {
                // todo: try-catch

                let clonedInput = clone(x.input)

                let actual = settings.multipleParameters ? f(...clonedInput) : f(clonedInput)

                if (samevalue(actual, x.expected))
                    success(testname, x.input, x.expected, actual, f)
                else
                    fail(testname, x.input, x.expected, actual, f)
            }
        }

    }

    // function toggle(t) {
    //     let rows = t.querySelector(".dud-rows")
    //     let current = rows.style.display
    //     let next = current === "none" ? "block" : "none";
    //     rows.style.display = next
    // }

    function render() {

        function getSymbol(state) {

            let symbol = '-';
            if (state === 'success')
                symbol = '✅'
            else if (state === 'fail')
                symbol = '❌'
            else throw "Unexpected state " + state
            return symbol
        }

        let html = "";

        for (let testname of Object.keys(result)) {

            let nrOfSuccess = result[testname].filter(x => x.state === "success").length
            let nrOfFail = result[testname].filter(x => x.state === "fail").length
            let nrOfTests = result[testname].length

            let summary = `${nrOfSuccess} tests pass of ${nrOfTests}`
            if (nrOfSuccess == nrOfTests)
                summary = `All ${nrOfTests} tests passed`

            let groupState = nrOfFail === 0 ? "success" : "fail";

            html += `<div class='dud-group'>`
            html += `<div class='dud-state'>${getSymbol(groupState)}</div>`
            html += `<div class='dud-testname'>${testname}</div>`
            html += `<div class='dud-summary'>${summary}</div>`
            html += `<div class='dud-rows'>`
            for (let x of result[testname]) {

                if (x.state === "fail") {

                    if (viewFailedTestInConsole)
                        console.error("failed test", x)

                    html += `<div class='dud-row'>`
                    html += `<div class='dud-testname'>${x.funname}</div>`
                    html += `<div class='dud-input'>${JSON.stringify(x.input)}</div>`
                    html += `<div class='dud-expected'>${JSON.stringify(x.expected)}</div>`
                    html += `<div class='dud-actual'>${JSON.stringify(x.actual)}</div>`
                    html += `</div>`
                }

            }

            html += `</div>`
            html += `</div>`
        }

        document.getElementById("dud-result").innerHTML = html
    }

    function runfun(testname, fun, ...testfunctions) {

        for (let f of testfunctions) {

            try {
                fun(f)
                success(testname)
            } catch{
                fail(testname)
            }

        }
    }

    function assert(x, y) {
        if (!samevalue(x, y)) {
            console.error("Expected", x, "but got", y)
            throw ''
        }
    }

    function samevalue(x, y) {
        let success = false;

        if (Array.isArray(x) || Array.isArray(y))
            success = hasSameArrayContent(x, y)

        else if (x === y)
            success = true

        return success
    }

    return {
        start,
        run,
        render,
        runfun,
        assert,

        result
    }

})()

