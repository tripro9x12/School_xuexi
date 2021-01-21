function greeter(person: string) {
    return `Hello: ${person}`
}
var names: string = "Trí";
document.querySelector('#demo').innerHTML = greeter(names);