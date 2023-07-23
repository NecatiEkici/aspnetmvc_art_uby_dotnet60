$(function () {
    $('.fa-heart').click(function () {
        var btn = $(this)
        var id = btn.data("id")
        var type = btn.data("type")
        
        var url = "/like/" + type + "/" + id        

        $.ajax({
            type: 'GET',
            url: url,
            dataType: "html",
            success: function (data) {
                $("#likeCount").text(data)
                if (btn.attr('class')=="fa-sharp fa-solid fa-heart text-danger") {
                    btn.attr('class','fa-sharp fa-solid fa-heart')                   
                } else {
                    btn.attr('class', 'fa-sharp fa-solid fa-heart text-danger')                    
                }
            },
        });
    })
})