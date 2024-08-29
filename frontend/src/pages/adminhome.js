import React, { useState, useEffect } from 'react';
import CollageCard from '../components/card';
import { getColleges } from '../controllers/collegeController';

const AdminHome = () => {
  const [selectedTab, setSelectedTab] = useState('Collage');
  const [collages,setColleges] = useState([])
  const userName = 'John Doe';
  const userEmail = 'john.doe@example.com';


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



  const contentSection = () => {
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
        <h2 className="text-3xl font-bold mb-4 text-white">{selectedTab}</h2>
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

  return (
    <div className="flex h-screen">
      <aside className="w-1/4 bg-gray-800 text-white p-4">
        <nav>
          <ul>
            <div className="pb-3 text-white text-left">
              <p className="font-semibold">{userName}</p>
              <p className="text-sm overflow-hidden">{userEmail}</p>
            </div>
            <li
              className={`p-4 cursor-pointer ${selectedTab === 'Collage' ? 'bg-gray-700' : ''}`}
              onClick={() => setSelectedTab('Collage')}
            >
              Collage
            </li>
            <li
              className={`p-4 cursor-pointer ${selectedTab === 'Semester' ? 'bg-gray-700' : ''}`}
              onClick={() => setSelectedTab('Semester')}
            >
              Semester
            </li>
            <li
              className={`p-4 cursor-pointer ${selectedTab === 'Subject' ? 'bg-gray-700' : ''}`}
              onClick={() => setSelectedTab('Subject')}
            >
              Subject
            </li>
          </ul>
        </nav>
      </aside>
      <main className="flex-1 bg-gray-100 p-0">
        {contentSection()}
      </main>
    </div>
  );
};

export default AdminHome;
