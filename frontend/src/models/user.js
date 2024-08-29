export class User{
    constructor({
        id,
        email,
        name
    }){
        this.id =  id;
        this.email =email;
        this.password = name;
    }
}

export const transformUser = (data) =>{
    return new User({
        id : data.id,
        email:data.email,
        name: data.name
    })
}