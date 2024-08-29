import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import './index.css'


import AdminHome from './pages/adminhome';
import AuthPage from './pages/authpage';

const App = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<AuthPage />} />
        <Route path="/homepage" element={<AdminHome />} />
      </Routes>
    </Router>
  );
};

export default App;
