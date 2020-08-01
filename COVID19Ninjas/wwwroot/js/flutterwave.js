
$(document).ready(function(){

    var em = document.getElementById('_usersEmail').value;
    var ph = document.getElementById('_usersPhone').value;
    var na = document.getElementById('_usersName').value;
    var tx = document.getElementById('_usersTrnx').value;

    const API_publicKey = "FLWSECK_TEST-7bc7abd1dc997394275759f2107a04ed-X";

    function payWithRave() {

    $("#trnxStatus").html("");

    var x = getpaidSetup({
    PBFPubKey: API_publicKey,

    amount: 1,

    currency: "NGN",
    txref: tx,
    meta: [{
    metaname: "flightID",
    metavalue: "AP1234"
    }],
    customer: {
    email: em,
    phonenumber: ph,
    name: na,
    },
    onclose: function () {
    $("#trnxStatus").html("Transaction was cancelled").addClass("text-danger");
    },
    callback: function (response) {
    var txref = response.data.txRef; // collect txRef returned and pass to a server page to complete status check.
    console.log("This is the response returned after a charge", response);
    if (response.data.chargeResponseCode == "00" || response.data.chargeResponseCode == "0") {
    // redirect to a success page
    debugger;
    saveTrnxRef(response.data.txRef);

    } else {
    debugger;

    saveTrnxRef(response.data.txRef);

    // redirect to a failure page.
    }
    x.close(); // use this to close the modal immediately after payment.
    }
    });
    }


    function saveTrnxRef(dt) {
    $.ajax({
    url: "@Url.Page("/Dashboard")?handler=ReturnFromFW",
    type: 'GET',
    data: {tx_ref: dt},

    success: function (response) {

    }
    });

    }
});
