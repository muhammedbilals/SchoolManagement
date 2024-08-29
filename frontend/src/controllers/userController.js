import userService from "../services/userservice"

export const getUsers = async () =>{
    return await userService.getUsers();
}

export const getCollagesByUser = async (userId,collageId) =>{
    return await userService.getCollagesByUser(userId,collageId);
}