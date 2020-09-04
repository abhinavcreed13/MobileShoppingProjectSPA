function CartViewModel(app, dataModel) {
    var self = this;

    dataModel.showCart = ko.observable(false);

    self.cartItems = ko.observableArray();

    Sammy(function () {
        this.get('#cart', function () {
            // Make a call to the protected Web API by passing in a Bearer Authorization Header
            
            $.ajax({
                method: 'get',
                url: "api/DataApi/GetCartItems",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    // telling knockout to update that header
                    dataModel.showCart(true);
                    dataModel.showHome(false);
                    self.cartItems(data);
                }
            });
        });
        this.get('/', function () { this.app.runRoute('get', '#home'); });
    });
    return self;
}

app.addViewModel({
    name: "Cart",
    bindingMemberName: "cart",
    factory: CartViewModel
});
