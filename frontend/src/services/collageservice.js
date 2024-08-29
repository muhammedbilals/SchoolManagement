import api from '../api/api'

const getColleges = async () => {
    try {
        const response = await api.get('/api/college')
        console.log(response)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const getCollege = async (id) => {
    try {
        const response = await api.get(`/api/college/${id}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const updateCollege = async (collegeId,collegeCode,collegeName) => {
    try {
        const response = await api.put(`/api/college/${collegeId}`,
            {
                collegeCode: collegeCode,
                name: collegeName
            },
            { 
            headers: {
                'Content-Type' : 'application/json',
                // 'Authorization': 'Bearer your_token_here',
            },
        }
        )
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const createCollege = async (collegeCode,collegeName) => {
    try {
        const response = await api.post(`/api/college/`,
            {
                collegeCode: collegeCode,
                name: collegeName
            },
            { 
            headers: {
                'Content-Type' : 'application/json',
                // 'Authorization': 'Bearer your_token_here',
            },
        }
        )
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const deleteCollege = async (collegeId) => {
    try {
        const response = await api.delete(`/api/college/${collegeId}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const addUserToCollage = async (collegeId,userId) => {
    try {
        const response = await api.post(`/api/college/${collegeId}/users/${userId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const removeUserFromCollage = async (collegeId,userId) => {
    try {
        const response = await api.delete(`/api/college/${collegeId}/users/${userId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

// eslint-disable-next-line import/no-anonymous-default-export
export default {
    getColleges,
    getCollege,
    updateCollege,
    createCollege,
    deleteCollege,
    addUserToCollage,
    removeUserFromCollage
}