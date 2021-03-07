function navigateToMainMenu() {
    window.location.href = "/index.html"
}

var ordersearch = document.getElementById("getorder");
    
ordersearch.addEventListener('submit' , o => {
    o.preventDefault();
    const search = {
        order: document.getElementById('orderId').value
    };
    
    fetch(`orderbyorderid/${search.orderId}`)
        .then(response => response.json())
        .then(order => {
            var table = document.getElementById("ordertable");
            var row = table.insertRow(1);
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            var cell4 = row.insertCell(3);
            var cell5 = row.insertCell(4);
            cell1.innerHTML = `${order.orderId}`;
            cell2.innerHTML = `${order.customerId}`;
            cell3.innerHTML = `${order.storeId}`;
            cell4.innerHTML = `${order.orderDate}`;
            cell5.innerHTML = `${order.subtotal}`;
        });
})