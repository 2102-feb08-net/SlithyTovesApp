'use strict';

function navigateToMainMenu() {
    window.location.href = "/index.html"
}

const orderform = document.getElementById('orderform');

orderform.addEventListener('submit', event => {
    event.preventDefault();

    const order = {
        orderId: 0,
        customerId: 5,
        storeId: 1,
        orderDate: "2021-03-09T05:13:22.134Z",
        subtotal: 10.99,
            products: [
                {
                    productId: 1,
                    quantity: 1,
                    productName: "To Kill a Mockingbird",
                    unitPrice: 10.99
                },
                {
                    productId: 3,
                    quantity: 1,
                    productName: "Pride and Prejudice and Zombies",
                    unitPrice: 11.99
                }
            ]
        
    };

    placeOrder(order)
        .then(() => {
            successMessage.textContent = 'Order placed successfully.';
            successMessage.hidden = false;
        })
        .catch(error => {
            errorMessage.textContent = error.toString();
            errorMessage.hidden = false;
        })
})

// still need a function to multiply product price * quantity to equal line total
// after I connect to the database and have that info

//function getLineTotal() {
//    let lineArray = document.getElementById('')
//}

//function getSubotal() {
  //  let array = document.getElementById('linetotal');
    //let subtotal = document.getElementById('subtotal').value;
    //for(let i = 0; i < array.length; i++) {
      //  if (parseFloat(array[i].value)) {
        //    subtotal += parseFloat(array[i].value);
        //}
    //}

//}

document.addEventListener('DOMContentLoaded', init);