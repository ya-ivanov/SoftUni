function findYoungestPerson(people) {
    var youngestPerson = 0, minAge = people[0].age;
    for (var person in people) {
        if (people[person].age <= minAge){
            youngestPerson = person;
            minAge = people[youngestPerson].age;
        }
    }
    return people[youngestPerson];
}

var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}];

var youngestPerson = findYoungestPerson(persons);
console.log("The youngest person is " + youngestPerson.firstname + " " + youngestPerson.lastname);
