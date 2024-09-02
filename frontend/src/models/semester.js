class Semester {
    constructor({ id, code, description, }) {
        this.id = id;
        this.code = code;
        this.description=description;
    }
    transform() {
        return {
            id: this.id,
            code: this.collageCode,
            description: this.description,
        };
    }
}



export default Semester