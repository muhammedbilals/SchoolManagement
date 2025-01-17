class Subject {
    constructor({ id, subjectCode, courseId, title }) {
        this.id = id;
        this.subjectCode = subjectCode;
        this.courseId = courseId;
        this.title = title;
    }

    transform() {
        return {
            id: this.id,
            subjectCode: this.subjectCode, // Use subjectCode instead of collagesubjectCode
            courseId: this.courseId,
            title: this.title,
        };
    }

    static transformSubjects(subjects) { // Corrected method name and parameter
        return subjects.map(subject => new Subject(subject).transform());
    }
}

export default Subject;