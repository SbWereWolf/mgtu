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

    window.fetch(`/api/user/${id}`)
        .then(response => response.json())
        .then(data => printEmails(data))
        .catch(() => {
            console.error("⛔");
            printEmails([]);
        });
});

function printEmails(emailsList) {

    const list = $("<ol>");

    emailsList.forEach(function(value) {
        list.append($("<li>").text(value));
    });

    const target = $("#user-emails-list");
    target.html(list);
}

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
