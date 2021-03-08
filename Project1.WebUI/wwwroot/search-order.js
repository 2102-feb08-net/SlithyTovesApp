function navigateToMainMenu() {
    window.location.href = "/index.html"
}

var ordersearch = document.getElementById("getorder");
    
ordersearch.addEventListener('submit' , o => {
    o.preventDefault();
    const search = {
        order: document.getElementById('orderId').value
    };
    
fetch(`orderdetailsbyorderid/${search.order}`)
    .then(response => response.json())
    .then(order => {
        var table = document.getElementById("ordertable");
        order.products.map(product => {
            var row = table.insertRow();
            for(let i = 0; i < 8; i++) {
                switch(i) {
                    case 0: row.insertCell(i).innerHTML = `${order.orderId}`;
                    break;
                    case 1: row.insertCell(i).innerHTML = `${order.orderDate}`;
                    break;
                    case 2: row.insertCell(i).innerHTML = `${order.customerId}`;
                    break;
                    case 3: row.insertCell(i).innerHTML = `${order.subTotal}`;
                    break;
                    case 4: row.insertCell(i).innerHTML = `${product.productId}`;
                    break;
                    case 5: row.insertCell(i).innerHTML = `${product.productName}`;
                    break;
                    case 6: row.insertCell(i).innerHTML = `${product.quantity}`;
                    break;
                    case 7: row.insertCell(i).innerHTML = `${product.unitPrice}`;
                    default:
                    break;
                }
            }
        })         
    });
})