import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Header from './components/header/header';
import './index.css'


import MovieHomePage from './pages/moviehome';
import TvHomePage from './pages/tvhome';
import MovieDetailsPage from './pages/movieDetails';

const App = () => {
  return (
    <Router>
      <Header/>
      <Routes>
        <Route path="/" element={<MovieHomePage />} />
        <Route path="/movies" element={ <MovieHomePage/>}/>
        <Route path="/tv-series" element={<TvHomePage />} />
        <Route path="/movie/:id" element={<MovieDetailsPage />} />
      </Routes>
    </Router>
  );
};

export default App;
