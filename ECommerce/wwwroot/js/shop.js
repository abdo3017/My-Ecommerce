function GetProductsOfType(CategoryId, TypeId) {
    $.ajax({
        url: "/Shop/GetProductsOfType",
        data: {
            categoryId: CategoryId,
            typeId: TypeId
        },
        success: function (result) {
            $("#content").html(result);
        },
        error: function (error) { console.log(error); }
    });
}

function AddToCart(id) {
    console.log("dfdvbdsf");
    var Quantity = 1;
    $.ajax({
        url: "/Shop/AddToShoppingCart",
        type: "POST",
        data: {
            productId: id,
            quantity: Quantity
        },
        success: function (res) {
            console.log(res);
            message(res);
        }
    });
}

function AddToFavourite(id) {
    $.ajax({
        url: "/Shop/AddToFavourite",
        type: "POST",
        data: {
            productId: id
        },
        success: function (res) {
            console.log(res);
            message(res);
        }
    });
}


function message(check) {

    //if (check == false)
    //danger.style.display = 'block';
    setTimeout(() => {
    }, 2000);
    success.style.display = 'block';

    setTimeout(() => {
        danger.style.display = 'none';
        success.style.display = 'none';
    }, 4000);
}