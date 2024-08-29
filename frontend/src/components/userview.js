import React, { useState, useEffect } from 'react';
import UserCard from './usercard'; // Note the corrected import path if needed
import { getUsers } from '../controllers/userController';

const UserContent = () => {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    async function loadInitialData() {
      try {
        const data = await getUsers();
        setUsers(data);
      } catch (error) {
        console.error('Failed to load users:', error);
      }
    }
    loadInitialData();
  }, []);

  const handleEdit = (id) => {
    console.log('Edit User with id:', id);
    // Implement your edit logic here
  };

  const handleDelete = (id) => {
    console.log('Delete User with id:', id);
    // Implement your delete logic here
  };

  return (
    <div className="w-full h-full p-8 bg-black">
      <h2 className="text-3xl font-bold mb-4 text-white">Users</h2>
      <div className="grid grid-cols-1 sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
        {users.map((user) => (
          <UserCard
            key={user.id} // Corrected the key prop to lowercase
            user={user}
            onEdit={handleEdit}
            onDelete={handleDelete}
          />
        ))}
      </div>
    </div>
  );
};

export default UserContent;
