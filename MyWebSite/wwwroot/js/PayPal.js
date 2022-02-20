

// PayPal
function payPayPal(model) {

    // Create PayPall Function
    function loadPayPalScript(url, callback) {
        const el = document.querySelector(`script[src="${url}"]`);
        if (!el) {
            const s = document.createElement('script');
            s.setAttribute('src', url);
            s.onload = callback;
            document.head.insertBefore(s, document.head.firstElementChild);
        } else {
            el.remove();
            const s = document.createElement('script');
            s.setAttribute('src', url);
            s.onload = callback;
            document.head.insertBefore(s, document.head.firstElementChild);
            $('.payment-window').html = '';
        }
    }

    // Call PayPal Function
    var sundBoxClientID = "AWTbQEyt9Y82E59W6V35ecGdNtMb0C3GKg0BayPnzd_HsTy2V4YSfII2kATpIsberhyaOmKF2g0iPc_m";
    var productionClientID = "ARNBDqppQ6ltJJyjRg8qeXV15Tm6cCCnGgiVsEfk9EqxQ9BlW4DHYE19tQRnQnTas19eC2Tz8--SZYxh";
    loadPayPalScript("https://www.paypal.com/sdk/js?client-id=" + sundBoxClientID + "&currency=EUR", () => { // &commit=false&vault=true
        paypal.Buttons({

            // Setup Transaction
            createOrder(data, actions) {
                return actions.order.create({
                    purchase_units: [
                        {
                            "amount": {
                                "currency_code": "EUR",
                                "value": model.price.toString(),
                            }
                            //"shipping": {
                            //    "address": {
                            //        "address_line_1": "2211 N First Street",
                            //        "address_line_2": "Building 17",
                            //        "admin_area_2": "San Jose",
                            //        "admin_area_1": "CA",
                            //        "postal_code": "95131",
                            //        "country_code": "US",
                            //        "state": "Attika",
                            //        "phone": "6939277783",
                            //        "recipient_name": "Alexandros Platanios"
                            //    }
                            //},
                        }
                    ]
                });
            },

            //createSubscription: function(data, actions) {

            //},

            // On Payment Done
            onApprove(data, actions) {
                //var order = JSON.parse(localStorage.getItem('order'));
                //localStorage.removeItem('order');

                // data.billingToken                   x
                // data.facilitatorAccessToken         x
                // data.orderID                        o
                // data.payerID                        o
                // data.paymentID                      x
                
                console.log("Approved");
                console.log(data); // data.payer.name.given_name

                // Create Order_Key
                var order = {
                    OrderID: data.orderID,
                    PayerID: data.payerID,
                    ProjectId: model.projectID,
                }
                $.ajax({
                    url: "/Home/CreateOrder",
                    type: "POST",
                    data: order,
                    success: function (response) {
                        console.log(response);
                        // TODO: Redirect to new Window to download the payed Project
                        window.open('http://stackoverflow.com', '_blank');
                    },
                    error: function (error) {
                        console.log(error);
                    }
                });
            },

            // On Payment Canceled
            onCancel(data, actions) {
                //var order = JSON.parse(localStorage.getItem('order'));
                //localStorage.removeItem('order');
            },

            // On Transactions Error
            onError(err, actions) {
                console.log("Error:");
                console.log(err);

                //var order = JSON.parse(localStorage.getItem('order'));
                //localStorage.removeItem('order');
            },

            onInit(data, actions) {

            },

            onClick(data, actions) {
                //localStorage.setItem('order', JSON.stringify(order));
            },

            onShippingChange(data, actions) {

            },

            style: {
                //layout: 'vertical',
                //color: 'blue',
                //shape: 'rect',
                //label: 'paypal',

                layout: 'vertical',
                //size: 'responsive',
                color: 'silver',
                shape: 'rect',
                label: 'checkout',
                tagline: 'false',
                fundingicons: 'true',
            },

            funding: {
                allowed: [paypal.FUNDING.CARD, paypal.FUNDING.CREDIT, paypal.FUNDING.ELV],
                disallowed: []
            }

        }).render('.payment-window');

       

    });
}







$(document).ready(function () {

    // When close payment modal
    $('.paymentModal').on('hidden.bs.modal', function () {
        
    });

});