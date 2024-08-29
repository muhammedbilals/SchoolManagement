import api from '../api/api'

const loginUser = async (email, password) => {
    try {
        const response = await api.post('/api/Auth/login',
            { 
                email: email,
                password: password
            },  
            { 
            headers: {
                'Content-Type' : 'application/json',
                // 'Authorization': 'Bearer your_token_here',
            },
        })
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const signUpUser = async (email, password) => {
    try {
        const response = await api.post('/api/Auth/register',
            {
                email: email,
                password: password
            },
            {
            headers: {
                'Content-Type': 'application/json',
                // 'Authorization': 'Bearer your_token_here',
            },
        })
        return response.data
    } catch (error) {
        console.log('error in signup api',error)
    }
}

// eslint-disable-next-line import/no-anonymous-default-export
export default {
    loginUser,
    signUpUser,
}