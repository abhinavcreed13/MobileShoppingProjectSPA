﻿function HomeViewModel(app, dataModel) {
    var self = this;

    self.myHometown = ko.observable("");

    self.myApiText = ko.observable("");

    self.phoneData = ko.observableArray();

    Sammy(function () {
        this.get('#home', function () {
            // Make a call to the protected Web API by passing in a Bearer Authorization Header
            $.ajax({
                method: 'get',
                url: app.dataModel.dataApiUrl,
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    // telling knockout to update that header
                    self.myApiText(data);

                    $.ajax({
                        method: 'get',
                        url: app.dataModel.getPhoneDataUrl,
                        contentType: "application/json; charset=utf-8",
                        success: function (phoneDataList) {
                            // tell knockout to update UI
                            self.phoneData(phoneDataList);
                        }
                    })
                }
            });
        });
        this.get('/', function () { this.app.runRoute('get', '#home'); });
    });

    self.addToCart = function (record) {
        console.log(record);
    }

    return self;
}

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
