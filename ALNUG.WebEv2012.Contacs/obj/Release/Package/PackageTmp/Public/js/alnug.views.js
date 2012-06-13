/// <reference path="libs/underscore.js" />
/// <reference path="libs/backbone.js" />
//  <reference path="libs/jsrender.js" />
//  <reference path="libs/jquery-1.7.2.js" />
//  <reference path="alnug.models.js" />

ContactListView = Backbone.View.extend({
	el: $('#list-content'),
	collection: Contacts,
	initialize: function () {
		_.bindAll(this, 'render');
		this.template = $('#contactTile');
		this.collection.bind('reset', this.render);
	},
	events: {
		'click a.large-add': 'AndNewContact',
		'click a.large-white-arrow': 'EditContact'
	},
	AndNewContact: function () {
		app.navigate("create", true);
		return false;
	},
	EditContact: function (evt) {
		var id = $(evt.currentTarget).data('contact-id');
		app.navigate("edit/" + id, true);
		return false;
	},
	render: function () {
		var data = { items: this.collection.toJSON() },
            html = this.template.render(data);
		$(this.el).html(html);
		return this;
	}
});

ContactView = Backbone.View.extend({
	model: Contact,
	initialize: function () {
		_.bindAll(this, 'render');
		this.template = $('#contactForm');
	},
	events: {
	    'click #btnCancel': 'goBack',
	    'click a#submit' : 'save',
	    'click a#btnDelete': 'remove',
        'change input' : 'updateModel'
	},
	goBack: function () {
		app.navigate('', true);
		return false;
	},
	save : function(){
	    this.model.save(this.model.attributes,{
	        success: function(model, response){
	            alert("Kontakti " + model.get("FirstName") + " " + model.get("LastName") + " është ruajtur me sukese");
	            contacts.fetch();
	            app.navigate("",true);
	        },
	        error: function(model,response){
	            alert("Error: " + response.responseText);
	        }
	    });
	    return false;
	},
	remove: function () {
	    var answer = confirm("Kontakti do te fshihet, a jeni i sigurt?");
	    if (answer) {
	        this.model.destroy({
	            success: function () {
	                alert("Kontakti  u fshi me sukses");
	                contacts.fetch();
	                app.navigate("", true);
	            },
	            error: function (model, response) {
	                alert("Error: " + response.responseText);
	            }
	        });
	    }
	},
	updateModel: function (evt) {
	    var field = $(evt.currentTarget);
	    var key = field.data('name');
	    var val = field.val();
	    var data = {};
	    data[key] = val;
	    if (!this.model.set(data)) {
	        field.val(this.model.get(key));
	    }
	},
	render: function () {
		var html = this.template.render(this.model.toJSON());
		$(this.el).html(html);
		return this;
	}
});