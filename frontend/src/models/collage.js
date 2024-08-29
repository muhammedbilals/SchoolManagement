class College {
    constructor({ id, collageCode, name, subjects = [], semesters = [], users = null }) {
        this.id = id;
        this.collageCode = collageCode;
        this.name = name;
        this.subjects = subjects;
        this.semesters = semesters;
        this.users = users;
    }

    // Method to transform the data into a different structure
    transform() {
        return {
            collegeId: this.id,
            code: this.collageCode,
            collegeName: this.name,
            numberOfSubjects: this.subjects.length,
            numberOfSemesters: this.semesters.length,
            hasUsers: this.users !== null,
        };
    }

    // Static method to transform an array of colleges
    static transformColleges(colleges) {
        return colleges.map(college => new College(college).transform());
    }
}

export default College;
