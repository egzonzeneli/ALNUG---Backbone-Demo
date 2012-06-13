/// <reference path="libs/underscore.js" />
/// <reference path="libs/backbone.js" />
//  <reference path="libs/jsrender.js" />
//  <reference path="libs/jquery-1.7.2.js" />

Contact = Backbone.Model.extend({
    initialize: function(){
    },
    defaults: {
        FirstName: 'Kontakt ',
        LastName: 'i ri',
        Number: '04x000000'
    },
    idAttribute: 'Id',
    url: function () {
        return this.isNew() ? "/api/contacts" : "/api/contacts/" + this.get("Id");
    }
});

Contacts = Backbone.Collection.extend({
    model: Contact,
    url: 'api/contacts'
});
contacts = new Contacts();





