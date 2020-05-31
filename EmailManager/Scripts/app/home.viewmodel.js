function HomeViewModel(app, dataModel) {
    var self = this;

    self.myHometown = ko.observable("");

    Sammy(function () {
        this.get('#home', function () { console.info("Здесь была авторизаций, но мне она показалась лишней, и вообще заготовка под SPA не пригодилась") });
        this.get('/', function () { this.app.runRoute('get', '#home'); });
    });

    return self;
}

$("#userId").change(getEmails);
function getEmails() {

    const source = $("#userId");
    const id = source.val();
    const submit = $("#submit-email");

    window.fetch(`/api/user/${id}`)
        .then(response => response.json())
        .then(function (data) {
            printEmails(data);
            submit.prop("disabled", false);
        })
        .catch(() => {
            console.error("⛔, fail get emails");
            printEmails([]);
            submit.prop("disabled", true);
        });
}

function printEmails(emailsList) {

    const list = $("<ol>");

    emailsList.forEach(function (value) {
        list.append($("<li>").text(value));
    });

    const target = $("#user-emails-list");
    target.html(list);
}

$("#submit-email").click(function (event) {
    event.preventDefault();

    const details = {
        "userId": $("#userId").val(),
        "email": $("#email").val(),
    };

    const headers = new window.Headers({
        "Content-Type":
            "application/json;charset=UTF-8",
    });

    const request = new window.Request("/api/email", {
        method: "POST",
        headers: headers,
        body: JSON.stringify(details)
    });

    window.fetch(request)
        .then(() => getEmails())
        .catch(() => {
            console.error("⛔, fail write email");
        });

});

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
