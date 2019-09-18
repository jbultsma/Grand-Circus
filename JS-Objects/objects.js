let person = {
    name: "Joshua",
    age: 25,
    printInfo: function () {
        console.log(this.name);
        console.log(this.age);
    },
    add: function (x, y) {
        let result = x + y;
        return result;
    }   
}

person.printInfo();

let a = person.add(2, 1);
console.log(a);

//console.log(person.name)