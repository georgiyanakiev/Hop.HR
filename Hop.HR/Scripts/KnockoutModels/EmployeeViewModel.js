


function EmployeeViewModel() { 
    var _this = this;
    
    _this.firstName = ko.observable();
    _this.lastName = ko.observable();
    _this.employeeId = ko.observable();
    _this.login = ko.observable();
    _this.emailAddress = ko.observable();
    _this.phoneNumber = ko.observable();

    


    _this.addNewEmployee = function () { 
        
        var data = { 
            firstName: _this.firstName(),
            lastName: _this.lastName(),
            emailAddress: _this.emailAddress(),
            phoneNumber: _this.phoneNumber()
             
        };
        $.post("/Home/AddNewEmployee", data) 
            
        .done(function (message) { 
            _this.firstName(null);
            _this.lastName(null); 
            _this.emailAddress(null);
            _this.phoneNumber(null);
            _this.login(message);

       
        });
    }
}
 

        
        

    ko.applyBindings(accViewModel);
