import userService from "../services/userservice"

export const loginUser = async () =>{
    return await userService.loginUser();
}