import CollegeService from "../services/collageservice"

export const getColleges = async () =>{
    return await CollegeService.getColleges();
}

export const getCollege = async (collegeId) =>{
    return await CollegeService.getCollege(collegeId);
}

export const createCollege = async (collegeCode,collegeName) =>{
    return await CollegeService.getCollege(collegeCode,collegeName);
}

export const updateCollege = async (collegeId,collegeCode,collegeName) =>{
    return await CollegeService.getCollege(collegeId,collegeCode,collegeName);
}

export const deleteCollege = async (collegeId) =>{
    return await CollegeService.deleteCollege(collegeId);
}