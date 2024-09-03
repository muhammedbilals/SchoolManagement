import api from '../api/api'
import Subject from '../models/subject'

const getSubjects = async () => {
    try {
        const response = await api.get('/api/Subject')
        console.log(response)
        return Subject.transformSubjects(response)
    } catch (error) {
        console.log('error in login api',error)
    }
}

const getSubject = async (id) => {
    try {
        const response = await api.get(`/api/Subject/${id}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const updateSubject = async (SubjectId,SubjectCode,SubjectName) => {
    try {
        const response = await api.put(`/api/Subject/${SubjectId}`,
            {
                SubjectCode: SubjectCode,
                name: SubjectName
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

const createSubject = async (SubjectCode,SubjectName) => {
    try {
        const response = await api.post(`/api/Subject/`,
            {
                SubjectCode: SubjectCode,
                name: SubjectName
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

const deleteSubject = async (SubjectId) => {
    try {
        const response = await api.delete(`/api/Subject/${SubjectId}`)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const addSubjectToCollage = async (SubjectId,Id) => {
    try {
        const response = await api.post(`/api/Subject/${SubjectId}/Subjects/${SubjectId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

const removeSubjectFromCollage = async (collageId,SubjectId) => {
    try {
        const response = await api.delete(`/api/Subject/${collageId}/Subjects/${SubjectId}`,)
        return response.data
    } catch (error) {
        console.log('error in login api',error)
    }
}

// eslint-disable-next-line import/no-anonymous-default-export
export default {
    getSubjects,
    getSubject,
    updateSubject,
    createSubject,
    deleteSubject,
    addSubjectToCollage,
    removeSubjectFromCollage
}