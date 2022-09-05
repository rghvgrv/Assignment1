class User{
    constructor(name, address, phone){
        this.name = name;
        this.address = address;
        this.phone = phone;
    }
}


class UserDatabase{
    constructor(){
        this.data = [];
    }
    
    addRecord(row){
        this.data.push(row)
    }
}