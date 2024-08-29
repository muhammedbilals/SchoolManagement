import api from '../api/api'
import { transformUser } from '../models/user';

const getUsers = async () => {
    try {
        const response = await api.get('/api/user/getusers')
        console.log(response)

        return response.data.map(userData => transformUser(userData));
    } catch (error) {
        console.log('error in login api',error)
    }
}
const getCollagesByUser = async (userId) => {
    try {
        const response = await api.get(`/api/user/${userId}/college`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}


// eslint-disable-next-line import/no-anonymous-default-export
export default {
    getUsers,
    getCollagesByUser
}