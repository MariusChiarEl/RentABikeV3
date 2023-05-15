import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
/* eslint-disable react/jsx-filename-extension */
import React from 'react';
import './App.css';
import PostRezervare, { Register } from './postrezervare';
// eslint-disable-next-line import/no-named-as-default
import Login, { PostBike } from './postbike';
// eslint-disable-next-line import/no-named-as-default

function App() {
  return (
    <div className="App">
      <Router>
        <Routes>
          <Route exact path="/" element={<PostBike />} />
          <Route path="/postbike" element={<PostBike />} />
          <Route path="/postrezervare" element={<PostRezervare />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;

