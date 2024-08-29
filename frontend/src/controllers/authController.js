import authService from "../services/authservices"

export const loginUser = async (email,password) =>{
    return await authService.loginUser(email,password);
}

export const signUpUser = async (email,password) =>{
    return await authService.signUpUser(email,password);
}