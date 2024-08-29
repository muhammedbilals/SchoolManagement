import userService from "../services/userservice"

export const loginUser = async (email,password) =>{
    return await userService.loginUser(email,password);
}

export const signUpUser = async (email,password) =>{
    return await userService.signUpUser(email,password);
}