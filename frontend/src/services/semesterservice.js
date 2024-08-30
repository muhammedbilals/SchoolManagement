import api from '../api/api'

const getSemesters = async () => {
    try {
        const response = await api.get('/api/semester')
        console.log(response)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const getSemester = async (id) => {
    try {
        const response = await api.get(`/api/semester/${id}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const updateSemester = async (semesterId,semesterCode,semesterName) => {
    try {
        const response = await api.put(`/api/semester/${semesterId}`,
            {
                semesterCode: semesterCode,
                name: semesterName
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

const createSemester = async (semesterCode,semesterName) => {
    try {
        const response = await api.post(`/api/semester/`,
            {
                semesterCode: semesterCode,
                name: semesterName
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

const deleteSemester = async (semesterId) => {
    try {
        const response = await api.delete(`/api/semester/${semesterId}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const addSemesterToCollage = async (semesterId,SemesterId) => {
    try {
        const response = await api.post(`/api/semester/${semesterId}/Semesters/${SemesterId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const removeSemesterFromCollage = async (collageId,SemesterId) => {
    try {
        const response = await api.delete(`/api/Semester/${collageId}/Semesters/${SemesterId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

// eslint-disable-next-line import/no-anonymous-default-export
export default {
    getSemesters,
    getSemester,
    updateSemester,
    createSemester,
    deleteSemester,
    addSemesterToCollage,
    removeSemesterFromCollage
}