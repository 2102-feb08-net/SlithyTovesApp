var myorder = document.getElementById("findorder");
    
myorder.addEventListener('submit' , o => {
    o.preventDefault();
    const search = {
        order: document.getElementById('order-no').value
    };
    
    fetch(`orderbyorderno/${search.orderno}`)
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