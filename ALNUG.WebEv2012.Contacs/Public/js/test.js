/// <reference path="libs/underscore.js" />
/// <reference path="libs/backbone.js" />
//  <reference path="libs/jsrender.js" />
//  <reference path="libs/jquery-1.7.2.js" />


User = Backbone.Model.extend({
    defaults: {
        // ...
    },
    initialize: function () {
        this.bind('error', this.showError);
    },
    idAttribute: 'Id',
    validate: function (atts) {
        if (!atts.name || atts.name.length < 6) {
            return "Shfrytëzuesi duhet ti ketë se paku 6 shkronja!"
        }
    },
    showError: function (model,error) {
        alert(error);
    }
});

user = new User();

user.set({ name: 'testi' });


Users = Backbone.Collection.extend({
    model: User,
    initialize: function () {
        this.bind('add', this.notifyMeAboutAdd);
    },
    notifyMeAboutAdd: function (user) {
        alert("Ç'kemi " + user.get('name'));
    }
});



UserListView = Backbone.View.extend({
    initialize: function () {
        // ...
    },
    render: function () {
        // ... 
    },
    events: {
        // ...
    }
});






