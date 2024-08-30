import SemesterService from "../services/collageservice"

export const getSemesters = async () =>{
    return await SemesterService.getSemesters();
}

export const getSemester = async (SemesterId) =>{
    return await SemesterService.getSemester(SemesterId);
}

export const createSemester = async (SemesterCode,SemesterName) =>{
    return await SemesterService.getSemester(SemesterCode,SemesterName);
}

export const updateSemester = async (SemesterId,SemesterCode,SemesterName) =>{
    return await SemesterService.getSemester(SemesterId,SemesterCode,SemesterName);
}

export const deleteSemester = async (SemesterId) =>{
    return await SemesterService.deleteSemester(SemesterId);
}