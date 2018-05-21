

$(document).ready(function () {
    $("#categoryDD").change(function () {
        var selectedCategoryId = $("#categoryDD").val();
        var jsonData = { categoryId: selectedCategoryId };

        $.ajax(
            {
                url: "/Products/GetByCategory",
                data: jsonData,
                type: "POST",
                success: function (response) {
                    $("#productDD").empty();
                    var options = "<option >Select...</option>";
                    $.each(response,
                        function (key, product) {
                            options += "<option value='" + product.Id + "'>" + product.Name + "</option>"
                        });

                    $("#productDD").append(options);

                },
                error: function (response) {

                }

            });
    });
    var index = 0;
    $("#addButton").click(function () {
        var product = getProductForForm();
        var tableBody = $("#tbProducts");


        var indexCell = "<td style='display:none'><input type='hidden' name='StockInDetails.Index' value='" + index + "' /></td>";
        var productNameCell = "<td><input type='hidden' name='StockInDetails[" + index + "].ProductId' value='" + product.ProductId + "' /> " + product.ProductName + "</td>";
        var qtyCell = "<td><input type='hidden' name='StockInDetails[" + index + "].Qty' value='" + product.Qty + "' /> " + product.Qty + "</td>";
        var tr = "<tr>" + indexCell + productNameCell + qtyCell + "</tr>";
        tableBody.append(tr);
        ++index;
    });



});


function getProductForForm() {
    var productId = $("#productDD").val();
    var productName = $("#productDD option:selected").text();
    var qty = $("#Qty").val();

    return { ProductId: productId, ProductName: productName, Qty: qty }
}

