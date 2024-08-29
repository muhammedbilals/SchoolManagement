import React, { useState, useEffect } from 'react';
import CollageCard from './card';
import { getColleges } from '../controllers/collegeController';


const CollageContent = () => {
  const [collages,setColleges] = useState([])

  useEffect(() => {
    async function loadInitialData() {
      try {
        const data = await getColleges();
        setColleges(data);
      } catch (error) {
        console.error('Failed to load collages:', error);
      }
    }
    loadInitialData();
  }, []);




    // Example data for collage cards


    const handleEdit = (id) => {
      console.log('Edit collage with id:', id);
      // Implement your edit logic here
    };

    const handleDelete = (id) => {
      console.log('Delete collage with id:', id);
      // Implement your delete logic here
    };

    return (
      <div className="w-full h-full p-8 bg-black">
        <h2 className="text-3xl font-bold mb-4 text-white">{'Collages'}</h2>
        <div className="grid grid-cols-1 sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
          {collages.map((collage) => (
            <CollageCard
              key={collage.id}
              collage={collage}
              onEdit={handleEdit}
              onDelete={handleDelete}
            />
          ))}
        </div>
      </div>
    );
  };


export default CollageContent;
