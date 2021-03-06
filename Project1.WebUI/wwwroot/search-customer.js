var customersearch = document.getElementById("getemail");
    
customersearch.addEventListener('submit' , e =>  {
    e.preventDefault();
    const search = {
        email: document.getElementById('email').value
    };
    
fetch(`customerbyemail/${search.email}`)
    .then(response => response.json())
    .then(customer => {
        var table = document.getElementById("custtable");
        var row = table.insertRow(1);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);
        var cell6 = row.insertCell(5);
        cell1.innerHTML = `${customer.customerId}`;
        cell2.innerHTML = `${customer.firstName}`;
        cell3.innerHTML = `${customer.lastName}`;
        cell4.innerHTML = `${customer.phone}`;
        cell5.innerHTML = `${customer.email}`;
        cell6.innerHTML = `${customer.zip}`;
    });
})