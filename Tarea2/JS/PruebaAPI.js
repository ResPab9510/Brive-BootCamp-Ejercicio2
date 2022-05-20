const urlBase = "https://localhost:44393";

const MetodoGet = () => {
    fetch(`${urlBase}/api/Car/all`)
    .then(response => response.json())
    .then(data => console.log("Metodo Get api", data))
};

//const MetodoGet2 = (id) => {
//    fetch(`${urlBase}/api/Car/${id}`)
//     .then(response => response.json())
//     .then(data => console.log("Metodo Get api", data))
//};

const MetodoPost = () => {
     const Car = {
         Id: 19,
         Name: "Rio",
         Model: "Basico",
         Company: "Kia",
         age: 2020,
         createdDate: "2020-05-17"
    }

     fetch(`${urlBase}/api/Car`,{
         method: 'POST',
         body: JSON.stringify(Car),
         headers: {
             'Content-Type': 'application/json'
         }
     })
     .then(response => response.json())
     .then(data => console.log("Metodo POST api", data))
 };

const MetodoPut = () => {
    const car = {
        Id: 5,
        Name: "Camry",
        Model: "Basico",
        Company: "Toyota",
        age: 2021,
        createdDate: "2020-05-17"
     }

     fetch(`${urlBase}/api/Car`,{
         method: 'PUT',
         body: JSON.stringify(car),
         headers: {
             'Content-Type': 'application/json'
         }
     })
     .then(response => response.json())
     .then(data => console.log("Metodo PUT api", data))
 };

const MetodoDelete = (id) => {
     fetch(`${urlBase}/api/Car`,{
         method: 'DELETE',
        body: JSON.stringify(id),
         headers: {
             'Content-Type': 'application/json'
         }
     })
     .then(response => response.json())
     .then(data => console.log("Metodo DELETE api", data))
 };

const MetodoDelete2 = (id) => {
    fetch(`${urlBase}/api/Car/${id}`,{
         method: 'DELETE'
     })
     .then(response => response.json())
     .then(data => console.log("Metodo DELETE api", data))
 };



MetodoGet();
//MetodoGet2(2);
MetodoPost();
MetodoPut();
MetodoDelete(5);
MetodoDelete2(5);