$(".subscribeButton").click(
    function () {
        if ($(this).text() == 'Subscribed') {
            $(this).text('Subscribe');
            alert("You have unsubscribed to this event!");
        } else {
            $(this).text('Subscribed');
            alert("You have subscribed to this event!");
            
        }

        //alert("you have subscribed");
    });

$(".commentsButton").click(
    function () {
    }
);