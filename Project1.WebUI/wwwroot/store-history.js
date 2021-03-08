function navigateToMainMenu() {
    window.location.href = "/index.html"
}

var ordersearch = document.getElementById("getstorehistory");
    
ordersearch.addEventListener('submit' , e =>  {
    e.preventDefault();
    const search = {
        order: document.getElementById('id').value
    };
    
    fetch(`ordersbystoreid/${search.order}`)
        .then(response => response.json())
        .then(order => {
            var table = document.getElementById("ordertable");
            
            var numberOfColumns = 5;
            for (let o of order) {
                var row = table.insertRow();
                debugger;
                for(let i = 0; i < numberOfColumns; i++) { 
                    switch(i) {
                        case 0: row.insertCell(i).innerHTML = `${o.storeId}`;
                        break;
                        case 1: row.insertCell(i).innerHTML = `${o.orderId}`;
                        break;
                        case 2: row.insertCell(i).innerHTML = `${o.customerId}`;
                        break;
                        case 3: row.insertCell(i).innerHTML = `${o.orderDate}`;
                        break;
                        case 4: row.insertCell(i).innerHTML = `${o.subtotal}`;
                        default:
                        break;
                    }
                }
            }
        });
        ordertable.hidden = false;
    })