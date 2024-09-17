import React, { useState, useEffect } from 'react';
import SemesterCard from './semstercard';
import { getSemesters } from '../controllers/semesterController';


const SemesterContent = () => {
  const [semester,setSemester] = useState([])

  useEffect(() => {
    async function loadInitialData() {
      try {
        const data = await getSemesters();
        setSemester(data);
      } catch (error) {
        console.error('Failed to load semester:', error);
      }
    }
    loadInitialData();
  }, []);

    // Example data for Semester cards


    const handleEdit = (id) => {
      console.log('Edit Semester with id:', id);
      // Implement your edit logic here
    };

    const handleDelete = (id) => {
      console.log('Delete Semester with id:', id);
      // Implement your delete logic here
    };

    return (
      <div className="w-full h-full p-8 bg-black">
        <h2 className="text-3xl font-bold mb-4 text-white">{'semester'}</h2>
        <div className="grid grid-cols-1 sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
          {semester.map((semester) => (
            <SemesterCard
              key={semester.id}
              semester={semester}
              onEdit={handleEdit}
              onDelete={handleDelete}
            />
          ))}
        </div>
      </div>
    );
  };


export default SemesterContent;
