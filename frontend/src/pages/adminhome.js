import React, { useState } from 'react';
import CollageContent from '../components/collageview';
import UserContent from '../components/userview';

const AdminHome = () => {
  const [selectedTab, setSelectedTab] = useState('Collage');
  const userName = 'John Doe';
  const userEmail = 'john.doe@example.com';

  const renderTabContent = () => {
    switch (selectedTab) {
      case 'Collage':
        return <CollageContent />;
      case 'Users':
        return <UserContent />;
      default:
        return <CollageContent />;
    }
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
            <li
              className={`p-4 cursor-pointer ${selectedTab === 'Users' ? 'bg-gray-700' : ''}`}
              onClick={() => setSelectedTab('Users')}
            >
              Users
            </li>
          </ul>
        </nav>
      </aside>
      <main className="flex-1 bg-gray-100 p-0">
        {renderTabContent()}
      </main>
    </div>
  );
};

export default AdminHome;
