// CollageCard.js
import React from 'react';

const CollageCard = ({ collage, onEdit, onDelete }) => {
  return (
    <div className= "bg-gray-700 text-white p-4 rounded-lg shadow-md relative">
      <h3 className="text-xl font-semibold overflow-hidden overflow-ellipsis whitespace-nowrap">{collage.name}</h3>
      <p className="text-sm">{collage.collageCode}</p>
      <div className="absolute bottom-4 right-4 flex flex-col gap-1 ">
        <button
          className="bg-blue-500 hover:bg-blue-600 text-white font-semibold text-sm px-2 rounded"
          onClick={() => onEdit(collage.id)}
        >
          Edit
        </button>
        <button
          className="bg-red-500 hover:bg-red-600 text-white font-medium text-sm px-2 rounded"
          onClick={() => onDelete(collage.id)}
        >
          Delete
        </button>
      </div>
    </div>
  );
};

export default CollageCard;
