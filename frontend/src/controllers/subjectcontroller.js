import SubjectService from "../services/subjectservices"

export const getSubjects = async () =>{
    return await SubjectService.getSubjects();
}

export const getSubject = async (SubjectId) =>{
    return await SubjectService.getSubject(SubjectId);
}

export const createSubject = async (SubjectCode,SubjectName) =>{
    return await SubjectService.getSubject(SubjectCode,SubjectName);
}

export const updateSubject = async (SubjectId,SubjectCode,SubjectName) =>{
    return await SubjectService.getSubject(SubjectId,SubjectCode,SubjectName);
}

export const deleteSubject = async (SubjectId) =>{
    return await SubjectService.deleteSubject(SubjectId);
}