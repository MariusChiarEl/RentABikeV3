/* eslint-disable react/jsx-filename-extension */
import React, { useState } from 'react';
import { TextField, Button } from '@mui/material';
import './App.css';

export function PostBike() {
  const [model, setModel] = useState('');
  const [discount, setDiscount] = useState('');
  const [type, setType] = useState('');
  const [price, setPrice] = useState('');

  const API_URL = 'https://localhost:7246/api/Bike';

  const handleSubmit = (e) => {
    e.preventDefault();

    const formData = {
      model: String(model),
      discount: Number(discount),
      type: String(type),
      price: Number(price),
    };

    console.log(formData);

    fetch(`${API_URL}`, {
      method: 'POST',
      body: JSON.stringify(formData),
      headers: {
        'Content-type': 'application/json; charset=UTF-8',
      },
    })
      .then((res) => res.json())
      .then((data) => {
        console.log('Răspuns de la server:', data);
      })
      .catch((error) => {
        console.error('Eroare:', error);
      });

    setModel('');
    setDiscount('');
    setType('');
    setPrice('');
  };

  return (
    <div className="form-container">
      <h2>Formular</h2>

      <form className="data-form" onSubmit={handleSubmit}>
        <TextField
          id="model"
          name="model"
          label="Model"
          margin="normal"
          value={model}
          onChange={(e) => setModel(e.target.value)}
        />

        <TextField
          id="discount"
          name="discount"
          label="Discount"
          margin="normal"
          value={discount}
          onChange={(e) => setDiscount(e.target.value)}
        />

        <TextField
          id="type"
          name="type"
          label="Type"
          margin="normal"
          value={type}
          onChange={(e) => setType(e.target.value)}
        />

        <TextField
          id="price"
          name="price"
          label="Price"
          margin="normal"
          value={price}
          onChange={(e) => setPrice(e.target.value)}
        />

        <Button variant="contained" margin="normal" type="submit">
          Trimite
        </Button>
      </form>
    </div>
  );
}

export default PostBike;
