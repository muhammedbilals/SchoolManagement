import React, { useState, useEffect } from 'react';
import SubjectCard from './subjectcard';
import { getSubjects } from '../controllers/subjectcontroller';

const SubjectContent = () => {
  const [subjects, setSubjects] = useState([]); // Correct plural for clarity

  useEffect(() => {
    async function loadInitialData() {
      try {
        const data = await getSubjects();
        console.log(data);
        setSubjects(data);
      } catch (error) {
        console.error('Failed to load Subjects:', error);
      }
    }
    loadInitialData();
  }, []);

  const handleEdit = (id) => {
    console.log('Edit Subject with id:', id);
    // Implement your edit logic here
  };

  const handleDelete = (id) => {
    console.log('Delete Subject with id:', id);
    // Implement your delete logic here
  };

  return (
    <div className="w-full h-full p-8 bg-black">
      <h2 className="text-3xl font-bold mb-4 text-white">Subject</h2>
      <div className="grid grid-cols-1 sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
        {subjects.map((subject) => ( // Use `subject` instead of `Subject`
          <SubjectCard
            key={subject.id}
            subject={subject} // Correct the prop name
            onEdit={handleEdit}
            onDelete={handleDelete}
          />
        ))}
      </div>
    </div>
  );
};

export default SubjectContent;