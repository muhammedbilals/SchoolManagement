// semesterCard.js
import React from 'react';

const semesterCard = ({ semester, onEdit, onDelete }) => {
  return (
    <div className= "h-20 content-center bg-gray-700 text-white p-4 rounded-lg shadow-md relative">
      {/* <h3 className="text-xl font-semibold overflow-hidden overflow-ellipsis whitespace-nowrap">{semester.email}</h3> */}
      <p className="text-md">{semester.email}</p>
      <div className="absolute bottom-4 right-4 flex flex-col gap-1 ">
        <button
          className="bg-blue-500 hover:bg-blue-600 text-white font-semibold text-sm px-2 rounded"
          onClick={() => onEdit(semester.email)}
        >
          Edit
        </button>
        <button
          className="bg-red-500 hover:bg-red-600 text-white font-medium text-sm px-2 rounded"
          onClick={() => onDelete(semester.id)}
        >
          Delete
        </button>
      </div>
    </div>
  );
};

export default semesterCard;
