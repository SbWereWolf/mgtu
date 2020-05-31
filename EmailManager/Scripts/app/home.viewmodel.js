function HomeViewModel(app, dataModel) {
    var self = this;

    self.myHometown = ko.observable("");

    Sammy(function () {
        /* this.get('/', function () { this.app.runRoute('get', '#home'); }); */
    });

    return self;
}

$("#userId").change(function () {
    const id = $("#userId").val();
});

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
