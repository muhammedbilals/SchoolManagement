export class User{
    constructor({
        email,
        password
    }){
        this.email =email;
        this.password = password;
    }
}

export const transformUser = (data) =>{
    return new User({
        email:data.email,
        password: data.password
    })
}