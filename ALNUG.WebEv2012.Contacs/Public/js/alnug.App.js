ContactManager = Backbone.Router.extend({
    initialize: function () {
        listView = new ContactListView({
            collection: contacts
        });
        contactView = new ContactView({ el: '#form-content' });
    },
    routes: {
        '': 'index',
        'create': 'create',
        'edit/:id': 'edit'
    },
    index: function () {
        listView.render();
        $(contactView.el).empty();
    },
    create: function () {
        var contact = new Contact();
        $(listView.el).empty();
        contactView.model = contact;
        contactView.render();
    },
    edit: function (id) {
        var model = contacts.get(id);
        $(listView.el).empty();
 
        contactView.model = model;
        contactView.render();
    }
});