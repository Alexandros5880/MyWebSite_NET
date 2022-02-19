

// PayPal
function payPayPal(price) {

    // Create PayPall Function
    function loadPayPalScript(url, callback) {
        const el = document.querySelector(`script[src="${url}"]`);
        if (!el) {
            const s = document.createElement('script');
            s.setAttribute('src', url);
            s.onload = callback;
            document.head.insertBefore(s, document.head.firstElementChild);
        }
    }

    // Call PayPal Function
    loadPayPalScript('https://www.paypal.com/sdk/js?client-id=AaPpA83J5kFL7jquL9JPPjBM6H7_Pc6DYw3h5TSUhlbpHxKJ5Au7S7XvjcZBzOjtuBXDLQZiIQ70f7yO&currency=EUR', () => {
        paypal.Buttons({

            // Setup Transaction
            createOrder(data, actions) {
                return actions.order.create({
                    purchase_units: [{
                        amount: {
                            "currency_code": "EUR",
                            "value": price.toString(),
                        },
                        //"payer": {
                        //    "name": {
                        //        "given_name": "John",
                        //        "surname": "Doe"
                        //    },
                        //    "email_address": "customer@example.com",
                        //    "payer_id": "QYR5Z8XDVJNXQ"
                        //}
                        //"shipping": {
                        //    "address": {
                        //        "address_line_1": "2211 N First Street",
                        //        "address_line_2": "Building 17",
                        //        "admin_area_2": "San Jose",
                        //        "admin_area_1": "CA",
                        //        "postal_code": "95131",
                        //        "country_code": "US"
                        //    }
                        //}
                    }],
                });
            },

            //createSubscription: function(data, actions) {

            //},

            // On Payment Done
            onApprove(data, actions) {
                
            },

            // On Payment Canceled
            onCancel(data, actions) {
                
            },

            // On Transactions Error
            onError(err, actions) {
                
            },

            onInit(data, actions) {

            },

            onClick(data, actions) {
                
            },

            onShippingChange(data, actions) {

            },

            style: {
                layout: 'vertical',
                color: 'blue',
                shape: 'rect',
                label: 'paypal'
            },

        }).render('.payment-window');

    });
}







$(document).ready(function () {

    // When close payment modal
    $('.paymentModal').on('hidden.bs.modal', function () {
        
    });

});