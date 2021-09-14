// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}


export function getAddressPosition() {
    const elem = document.getElementById("ba-address");
    const rect = elem.getBoundingClientRect();

    for (let key in rect) {
        if (typeof rect[key] !== 'function') {
            var con = `${key} : ${rect[key]}`;
            console.log(con);
        }
    }

    //return rect["top"] + ";" + rect["left"] + ";" + rect["height"];

    return {
        top: rect["top"],
        left: rect["left"],
        height: rect["height"],
        width: rect["width"]
        };
}