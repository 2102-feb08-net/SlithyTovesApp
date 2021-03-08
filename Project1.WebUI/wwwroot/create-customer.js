function navigateToMainMenu() {
    window.location.href = "/index.html"
}

document.getElementById('createcust').addEventListener('click', event => 
    createCustomer(event));


function createCustomer(event) {
    event.preventDefault();
    var newCustForm = document.getElementById('newcust');
    var newCust = {
        firstName: newCustForm.elements['firstName'].value,
        lastName: newCustForm.elements['lastName'].value,
        phone: newCustForm.elements['phone'].value,
        email: newCustForm.elements['email'].value,
        zip: newCustForm.elements['zip'].value
    };
    return fetch(`newcustomer`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newCust)
    }).then(response => {
        debugger;
        if (!response.ok) {
            throw new Error(`Network response was not ok (${response.status})`);
        } else {
            location.reload();
        }
    });
}